using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackupTool
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        private List<string> _pastasCustomizadas = new List<string>();

        public Form1()
        {
            InitializeComponent();
            CarregarUsuariosLocais();
        }

        private void CarregarUsuariosLocais()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            txtOrigem.Text = userProfile;
            txtDestino.Text = Application.StartupPath;
        }

        private void btnSelecionarOrigem_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta do perfil do usuário (ex: C:\\Users\\Nome)";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOrigem.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnSelecionarDestino_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta de destino do backup (ex: Pendrive)";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestino.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnAddCustomPath_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione uma pasta adicional para o backup";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminho = folderDialog.SelectedPath;
                    if (!_pastasCustomizadas.Contains(caminho))
                    {
                        _pastasCustomizadas.Add(caminho);
                        AdicionarItemPainelCustomizado(caminho);
                    }
                }
            }
        }

        private void AdicionarItemPainelContent(string caminho) { } // Placeholder se necessário

        private void AdicionarItemPainelCustomizado(string caminho)
        {
            var panelItem = new Panel
            {
                Width = 400,
                Height = 22,
                Margin = new Padding(0, 2, 0, 2)
            };

            var lblCaminho = new Label
            {
                Text = caminho,
                Width = 330,
                Height = 20,
                AutoEllipsis = true,
                Font = new System.Drawing.Font("Segoe UI", 8.5F)
            };

            var btnRemover = new Button
            {
                Text = "X",
                Width = 25,
                Height = 20,
                Left = 335,
                ForeColor = System.Drawing.Color.Red,
                FlatStyle = FlatStyle.Flat
            };

            btnRemover.Click += (s, ev) =>
            {
                _pastasCustomizadas.Remove(caminho);
                flowCustomPaths.Controls.Remove(panelItem);
            };

            panelItem.Controls.Add(lblCaminho);
            panelItem.Controls.Add(btnRemover);
            flowCustomPaths.Controls.Add(panelItem);
        }

        private async void btnIniciarBackup_Click(object sender, EventArgs e)
        {
            string origem = txtOrigem.Text.Trim();
            string destinoBase = txtDestino.Text.Trim();

            if (!Directory.Exists(origem) || !Directory.Exists(destinoBase))
            {
                MessageBox.Show("Verifique os caminhos de origem e destino.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeUsuario = new DirectoryInfo(origem).Name;
            string pastaBackupFinal = Path.Combine(destinoBase, $"Backup_{nomeUsuario}_{DateTime.Now:yyyyMMdd_HHmmss}");

            List<string> pastasParaCopiar = ObterPastasSelecionadas();

            if (pastasParaCopiar.Count == 0 && _pastasCustomizadas.Count == 0)
            {
                MessageBox.Show("Selecione ao menos uma pasta para realizar o backup.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ativa estado de processamento
            btnIniciarBackup.Enabled = false;
            btnCancelar.Enabled = true;
            progressBar1.Visible = true; // Mostra a animação de "não travado"
            txtLog.Clear();
            _cts = new CancellationTokenSource();

            Log($"--- INICIANDO BACKUP: {nomeUsuario} ---");
            Log($"Destino: {pastaBackupFinal}\n");

            await Task.Run(() => ExecutarBackupProcess(origem, pastaBackupFinal, pastasParaCopiar, _pastasCustomizadas, _cts.Token));

            // Restaura estado normal
            progressBar1.Visible = false;
            btnIniciarBackup.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private List<string> ObterPastasSelecionadas()
        {
            var pastas = new List<string>();
            if (chkDesktop.Checked) pastas.Add("Desktop");
            if (chkDocuments.Checked) pastas.Add("Documents");
            if (chkDownloads.Checked) pastas.Add("Downloads");
            if (chkPictures.Checked) pastas.Add("Pictures");
            if (chkVideos.Checked) pastas.Add("Videos");
            if (chkMusic.Checked) pastas.Add("Music");
            if (chkFavorites.Checked) pastas.Add("Favorites");
            return pastas;
        }

        private void ExecutarBackupProcess(string origem, string destinoBase, List<string> pastasPadrao, List<string> pastasCustom, CancellationToken token)
        {
            // 1. Copia pastas padrão do perfil
            foreach (var pasta in pastasPadrao)
            {
                if (token.IsCancellationRequested)
                {
                    Log("\n[!] Operação cancelada pelo usuário.");
                    return;
                }

                string caminhoOrigem = Path.Combine(origem, pasta);
                string caminhoDestino = Path.Combine(destinoBase, pasta);

                if (Directory.Exists(caminhoOrigem))
                {
                    Log($"[+] Copiando {pasta}...");
                    CopiarComRobocopy(caminhoOrigem, caminhoDestino);
                }
                else
                {
                    Log($"[-] Ignorado: {pasta} (Não encontrado)");
                }
            }

            // 2. Copia pastas customizadas adicionadas na lista
            foreach (var customOrigem in pastasCustom)
            {
                if (token.IsCancellationRequested)
                {
                    Log("\n[!] Operação cancelada pelo usuário.");
                    return;
                }

                if (Directory.Exists(customOrigem))
                {
                    string nomeCustom = new DirectoryInfo(customOrigem).Name;
                    string customDestino = Path.Combine(destinoBase, "Outros", nomeCustom);

                    Log($"[+] Copiando customizada: {nomeCustom}...");
                    CopiarComRobocopy(customOrigem, customDestino);
                }
            }

            Log("\n==========================================");
            Log("BACKUP FINALIZADO COM SUCESSO!");
            Log("==========================================");
            MessageBox.Show("Backup concluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopiarComRobocopy(string origem, string destino)
        {
            try
            {
                Directory.CreateDirectory(destino);

                var psi = new ProcessStartInfo
                {
                    FileName = "robocopy.exe",
                    Arguments = $"\"{origem}\" \"{destino}\" /E /R:1 /W:1 /MT:8 /NP /NJH /NJS",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                using (var process = Process.Start(psi))
                {
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Log($"[ERRO] Falha ao copiar {origem}: {ex.Message}");
            }
        }

        private void Log(string mensagem)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => Log(mensagem)));
            }
            else
            {
                txtLog.AppendText(mensagem + Environment.NewLine);
            }
        }
    }
}