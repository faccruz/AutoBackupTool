namespace AutoBackupTool
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpCaminhos = new System.Windows.Forms.GroupBox();
            this.btnSelecionarDestino = new System.Windows.Forms.Button();
            this.btnSelecionarOrigem = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.grpPastas = new System.Windows.Forms.GroupBox();

            // Instanciação dos novos componentes
            this.btnAddCustomPath = new System.Windows.Forms.Button();
            this.flowCustomPaths = new System.Windows.Forms.FlowLayoutPanel();

            this.chkFavorites = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkVideos = new System.Windows.Forms.CheckBox();
            this.chkPictures = new System.Windows.Forms.CheckBox();
            this.chkDownloads = new System.Windows.Forms.CheckBox();
            this.chkDocuments = new System.Windows.Forms.CheckBox();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnIniciarBackup = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar(); // Instanciação da Progress

            this.grpCaminhos.SuspendLayout();
            this.grpPastas.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpCaminhos
            // 
            this.grpCaminhos.Controls.Add(this.btnSelecionarDestino);
            this.grpCaminhos.Controls.Add(this.btnSelecionarOrigem);
            this.grpCaminhos.Controls.Add(this.txtDestino);
            this.grpCaminhos.Controls.Add(this.lblDestino);
            this.grpCaminhos.Controls.Add(this.txtOrigem);
            this.grpCaminhos.Controls.Add(this.lblOrigem);
            this.grpCaminhos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCaminhos.Location = new System.Drawing.Point(12, 12);
            this.grpCaminhos.Name = "grpCaminhos";
            this.grpCaminhos.Size = new System.Drawing.Size(600, 110);
            this.grpCaminhos.TabIndex = 0;
            this.grpCaminhos.TabStop = false;
            this.grpCaminhos.Text = " Origem e Destino ";

            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrigem.Location = new System.Drawing.Point(15, 28);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(103, 15);
            this.lblOrigem.Text = "Perfil/Origem (HD):";

            // 
            // txtOrigem
            // 
            this.txtOrigem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrigem.Location = new System.Drawing.Point(125, 25);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(380, 23);
            this.txtOrigem.TabIndex = 1;

            // 
            // btnSelecionarOrigem
            // 
            this.btnSelecionarOrigem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelecionarOrigem.Location = new System.Drawing.Point(511, 24);
            this.btnSelecionarOrigem.Name = "btnSelecionarOrigem";
            this.btnSelecionarOrigem.Size = new System.Drawing.Size(75, 25);
            this.btnSelecionarOrigem.TabIndex = 2;
            this.btnSelecionarOrigem.Text = "Buscar...";
            this.btnSelecionarOrigem.UseVisualStyleBackColor = true;
            this.btnSelecionarOrigem.Click += new System.EventHandler(this.btnSelecionarOrigem_Click);

            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(15, 68);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(103, 15);
            this.lblDestino.Text = "Destino (Pendrive):";

            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestino.Location = new System.Drawing.Point(125, 65);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(380, 23);
            this.txtDestino.TabIndex = 3;

            // 
            // btnSelecionarDestino
            // 
            this.btnSelecionarDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelecionarDestino.Location = new System.Drawing.Point(511, 64);
            this.btnSelecionarDestino.Name = "btnSelecionarDestino";
            this.btnSelecionarDestino.Size = new System.Drawing.Size(75, 25);
            this.btnSelecionarDestino.TabIndex = 4;
            this.btnSelecionarDestino.Text = "Buscar...";
            this.btnSelecionarDestino.UseVisualStyleBackColor = true;
            this.btnSelecionarDestino.Click += new System.EventHandler(this.btnSelecionarDestino_Click);

            // 
            // grpPastas
            // 
            this.grpPastas.Controls.Add(this.flowCustomPaths);
            this.grpPastas.Controls.Add(this.btnAddCustomPath);
            this.grpPastas.Controls.Add(this.chkFavorites);
            this.grpPastas.Controls.Add(this.chkMusic);
            this.grpPastas.Controls.Add(this.chkVideos);
            this.grpPastas.Controls.Add(this.chkPictures);
            this.grpPastas.Controls.Add(this.chkDownloads);
            this.grpPastas.Controls.Add(this.chkDocuments);
            this.grpPastas.Controls.Add(this.chkDesktop);
            this.grpPastas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpPastas.Location = new System.Drawing.Point(12, 130);
            this.grpPastas.Name = "grpPastas";
            this.grpPastas.Size = new System.Drawing.Size(600, 165);
            this.grpPastas.TabIndex = 1;
            this.grpPastas.TabStop = false;
            this.grpPastas.Text = " Seleção de Conteúdo ";

            // Checkboxes padrão
            this.chkDesktop.Checked = true;
            this.chkDesktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDesktop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDesktop.Location = new System.Drawing.Point(20, 26);
            this.chkDesktop.Name = "chkDesktop";
            this.chkDesktop.Size = new System.Drawing.Size(120, 20);
            this.chkDesktop.Text = "Área de Trabalho";

            this.chkDocuments.Checked = true;
            this.chkDocuments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDocuments.Location = new System.Drawing.Point(160, 26);
            this.chkDocuments.Name = "chkDocuments";
            this.chkDocuments.Size = new System.Drawing.Size(120, 20);
            this.chkDocuments.Text = "Documentos";

            this.chkDownloads.Checked = true;
            this.chkDownloads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDownloads.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDownloads.Location = new System.Drawing.Point(300, 26);
            this.chkDownloads.Name = "chkDownloads";
            this.chkDownloads.Size = new System.Drawing.Size(120, 20);
            this.chkDownloads.Text = "Downloads";

            this.chkPictures.Checked = true;
            this.chkPictures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPictures.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPictures.Location = new System.Drawing.Point(440, 26);
            this.chkPictures.Name = "chkPictures";
            this.chkPictures.Size = new System.Drawing.Size(120, 20);
            this.chkPictures.Text = "Imagens";

            this.chkVideos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkVideos.Location = new System.Drawing.Point(20, 52);
            this.chkVideos.Name = "chkVideos";
            this.chkVideos.Size = new System.Drawing.Size(120, 20);
            this.chkVideos.Text = "Vídeos";

            this.chkMusic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMusic.Location = new System.Drawing.Point(160, 52);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(120, 20);
            this.chkMusic.Text = "Músicas";

            this.chkFavorites.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFavorites.Location = new System.Drawing.Point(300, 52);
            this.chkFavorites.Name = "chkFavorites";
            this.chkFavorites.Size = new System.Drawing.Size(120, 20);
            this.chkFavorites.Text = "Favoritos";

            // Botão Adicionar Pasta Customizada
            this.btnAddCustomPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomPath.Location = new System.Drawing.Point(20, 82);
            this.btnAddCustomPath.Name = "btnAddCustomPath";
            this.btnAddCustomPath.Size = new System.Drawing.Size(130, 25);
            this.btnAddCustomPath.Text = "+ Adicionar Pasta";
            this.btnAddCustomPath.UseVisualStyleBackColor = true;
            this.btnAddCustomPath.Click += new System.EventHandler(this.btnAddCustomPath_Click);

            // FlowLayoutPanel para os caminhos extras
            this.flowCustomPaths.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCustomPaths.Location = new System.Drawing.Point(160, 82);
            this.flowCustomPaths.Name = "flowCustomPaths";
            this.flowCustomPaths.Size = new System.Drawing.Size(426, 72);
            this.flowCustomPaths.TabIndex = 10;
            this.flowCustomPaths.AutoScroll = true;

            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpLog.Location = new System.Drawing.Point(12, 305);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(600, 180);
            this.grpLog.TabIndex = 2;
            this.grpLog.TabStop = false;
            this.grpLog.Text = " Progresso e Log ";

            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.ForeColor = System.Drawing.Color.LightGreen;
            this.txtLog.Location = new System.Drawing.Point(12, 22);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(574, 145);
            this.txtLog.TabIndex = 0;

            // 
            // btnIniciarBackup
            // 
            this.btnIniciarBackup.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIniciarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarBackup.ForeColor = System.Drawing.Color.White;
            this.btnIniciarBackup.Location = new System.Drawing.Point(344, 495);
            this.btnIniciarBackup.Name = "btnIniciarBackup";
            this.btnIniciarBackup.Size = new System.Drawing.Size(150, 35);
            this.btnIniciarBackup.TabIndex = 3;
            this.btnIniciarBackup.Text = "INICIAR BACKUP";
            this.btnIniciarBackup.UseVisualStyleBackColor = false;
            this.btnIniciarBackup.Click += new System.EventHandler(this.btnIniciarBackup_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(500, 495);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 495);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 35);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Visible = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 540);
            this.Controls.Add(this.progressBar1); // <--- ADICIONADO AQUI NA LISTA DE CONTROLES
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciarBackup);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpPastas);
            this.Controls.Add(this.grpCaminhos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoBackup Portable Tool";
            this.grpCaminhos.ResumeLayout(false);
            this.grpCaminhos.PerformLayout();
            this.grpPastas.ResumeLayout(false);
            this.grpPastas.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpCaminhos;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Button btnSelecionarOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnSelecionarDestino;

        private System.Windows.Forms.GroupBox grpPastas;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkDocuments;
        private System.Windows.Forms.CheckBox chkDownloads;
        private System.Windows.Forms.CheckBox chkPictures;
        private System.Windows.Forms.CheckBox chkVideos;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkFavorites;

        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;

        private System.Windows.Forms.Button btnIniciarBackup;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Button btnAddCustomPath;
        private System.Windows.Forms.FlowLayoutPanel flowCustomPaths;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}