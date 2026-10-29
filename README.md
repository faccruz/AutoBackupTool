# AutoBackup Portable Tool 🛠️📂

O **AutoBackup Portable Tool** é uma aplicação desktop leve, desenvolvida em **C# .NET (WinForms)**, criada especificamente para técnicos de informática agilizarem o processo de backup de dados de clientes durante manutenções, formatações ou migrações de sistemas.

A ferramenta foi desenhada para ser 100% *portable* (executável único), rodando diretamente de um pendrive sem necessitar de instalação ou de runtimes pré-instalados na máquina de destino.

---

## 🚀 Funcionalidades

* **Portabilidade Extrema (Single-File):** Compilado num único ficheiro `.exe` autónomo (Self-Contained), pronto para ser executado a partir de qualquer suporte removível.
* **Seleção de Perfil Inteligente:** Deteta automaticamente o caminho do utilizador atual (`C:\Users\Nome`), com suporte para selecionar perfis de outras unidades (como em docks de discos rígidos externos).
* **Seleção de Conteúdos Padrão:** Checkboxes para escolher rapidamente as pastas essenciais:
  * Área de Trabalho (Desktop)
  * Documentos
  * Downloads
  * Imagens
  * Vídeos
  * Músicas
  * Favoritos
* **Adição de Pastas Customizadas Dinâmicas:** Interface interativa (`FlowLayoutPanel`) para adicionar caminhos específicos adicionais com remoção individual fácil.
* **Alta Performance e Resiliência:** Utiliza o motor do **Robocopy** por baixo dos panos para garantir cópias rápidas, multi-threaded (`/MT:8`) e tolerantes a ficheiros bloqueados.
* **Feedback Visual em Tempo Real:** 
  * Caixa de log integrada com histórico detalhado.
  * Barra de progresso animada (*Marquee*) para indicar atividade contínua e evitar a sensação de travamento.
* **Segurança e Controlo:** Botão de cancelamento a qualquer momento através de tokens assíncronos (`CancellationToken`).

---

## 💻 Tecnologias Utilizadas

* **Linguagem:** C# (.NET 8 / .NET 9)
* **Interface Gráfica:** Windows Forms (WinForms)
* **Motor de Cópia:** Robocopy (nativo do Windows)
* **Arquitetura:** Processamento assíncrono (`async/await` e `Task.Run`) para manter a interface fluida.

---

## 📦 Como Compilar (Gerar o Executável Portable)

Se precisares de recompilar a aplicação a partir do código-fonte, abre o terminal na pasta do projeto e executa o seguinte comando de publicação:

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=false
O executável otimizado ficará disponível em:bin\Release\net8.0-windows\win-x64\publish\AutoBackupTool.exe

⚙️ Como Utilizar em Bancada
Copia o ficheiro AutoBackupTool.exe para a raiz do teu pendrive de suporte técnico.

Na máquina do cliente, liga o pendrive e executa o programa.

Confirma a Origem (Perfil do utilizador ou diretório do disco do cliente) e o Destino (a pasta no teu pendrive).

Seleciona as pastas pretendidas ou adiciona diretórios personalizados extras.

Clica em INICIAR BACKUP e acompanha o progresso em tempo real pelo log.

📝 Licença
Este projeto é de uso livre para técnicos de informática e profissionais de suporte de TI. Sinta-se à vontade para adaptar e melhorar conforme as necessidades do seu fluxo de trabalho.