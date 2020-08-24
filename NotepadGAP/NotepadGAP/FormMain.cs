using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadGAP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Gerenciador.VerificarRecentsFile();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
            AtualizarHistoricoRecentes();
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            Gerenciador.FileSaved = false;
            Text = Application.ProductName + " - *" + Gerenciador.FileName + Gerenciador.FileExt;
        }

        private void txtConteudo_SelectionChanged(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            int line = txtConteudo.GetLineFromCharIndex(index) + 1;
            statusBar_LabelLinhaColuna.Text = "Lin. " + line + ", Col." + ((index / line) + 1);
        }

        #region Menu Arquivo
        private void mArquivo_Novo_Click(object sender, EventArgs e)
        {
            if (!Gerenciador.FileSaved)
            {
                DialogResult result = MessageBox.Show($"Deseja salvar as alterações em \"{Gerenciador.FileName}{Gerenciador.FileExt}\" antes de sair?", "Salvar...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel || result == DialogResult.Abort)
                    return;
                else if (result == DialogResult.Yes)
                    mArquivo_Salvar_Click(sender, e);
            }

            Gerenciador.FileName = Gerenciador.DefaultFileName;
            Gerenciador.FileExt = Gerenciador.DefaultFileExt;
            Gerenciador.FolderPath = Gerenciador.DefaultFolderPath;

            txtConteudo.Text = "";
            Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
            Gerenciador.FileSaved = true;
        }

        private void mArquivo_NovaJanela_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void mArquivo_Abrir_Click(object sender, EventArgs e)
        {
            if (!Gerenciador.FileSaved)
            {
                DialogResult result1 = MessageBox.Show($"Deseja salvar as alterações em \"{Gerenciador.FileName}{Gerenciador.FileExt}\" antes de sair?", "Salvar...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result1 == DialogResult.Cancel || result1 == DialogResult.Abort)
                    return;
                else if (result1 == DialogResult.Yes)
                    mArquivo_Salvar_Click(sender, e);
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir...";
            dialog.Filter = "texto|*.txt|próprio|*.npgap|todos|*.*";

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo f = new FileInfo(dialog.FileName);
                    Gerenciador.FileName = (f.Name.Contains('.')) ? f.Name.Substring(0, f.Name.LastIndexOf('.')) : f.Name;
                    Gerenciador.FileExt = f.Extension;
                    Gerenciador.FolderPath = f.DirectoryName + "\\";

                    StreamReader stream = new StreamReader(f.FullName, true);
                    Encoding encoding = stream.CurrentEncoding;
                    txtConteudo.Text = stream.ReadToEnd();
                    statusBar_LabelEncoding.Text = encoding.EncodingName;
                    statusBar_LabelLinhaColuna.Text = txtConteudo.SelectionStart.ToString();
                    stream.Close();

                    Gerenciador.AddRecente(f.FullName);
                    AtualizarHistoricoRecentes();
                    Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
                    Gerenciador.FileSaved = true;
                }
                else
                {
                    MessageBox.Show("O arquivo não existe ou foi deletado.", "Erro ao tentar abrir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mArquivo_Salvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar...";
                dialog.Filter = "texto|*.txt|próprio|*.npgap|todos|*.*";
                dialog.CheckPathExists = true;
                dialog.CheckFileExists = false;

                DialogResult result = dialog.ShowDialog();
                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivo_SalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar Como...";
            dialog.Filter = "texto|*.txt|próprio|*.npgap|todos|*.*";
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = false;

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);

                if (File.Exists(dialog.FileName))
                {
                    FileInfo f = new FileInfo(dialog.FileName);
                    Gerenciador.FileName = (f.Name.Contains('.')) ? f.Name.Substring(0, f.Name.LastIndexOf('.')) : f.Name;
                    Gerenciador.FileExt = f.Extension;
                    Gerenciador.FolderPath = f.DirectoryName + "\\";

                    StreamReader stream = new StreamReader(f.FullName, true);
                    Encoding encoding = stream.CurrentEncoding;
                    statusBar_LabelEncoding.Text = encoding.EncodingName;
                    statusBar_LabelLinhaColuna.Text = txtConteudo.SelectionStart.ToString();
                    stream.Close();

                    Gerenciador.AddRecente(f.FullName);
                    AtualizarHistoricoRecentes();
                    Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
                    Gerenciador.FileSaved = true;
                }
                else
                {
                    MessageBox.Show("O arquivo não existe ou foi deletado.", "Erro ao tentar abrir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mArquivo_ConfigurarPagina_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_VisualizarImpressao_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_Fechar_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_Sair_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Menu Editar
        private void mEditar_Recortar_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_Copiar_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_Colar_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_Excluir_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_BuscarNaWeb_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_Localizar_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_LocalizarProxima_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_LocalizarAnterior_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_Substituir_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_IrPara_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_SelecionarTudo_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_DataEHora_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Menu Formatar
        private void mFormatar_QuebraAutomaticaDeLinha_Click(object sender, EventArgs e)
        {

        }

        private void mFormatar_Fonte_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Menu Exibir
        private void mExibir_Zoom_Ampliar_Click(object sender, EventArgs e)
        {

        }

        private void mExibir_Zoom_Reduzir_Click(object sender, EventArgs e)
        {

        }

        private void mExibir_Zoom_RestaurarZoom_Click(object sender, EventArgs e)
        {

        }

        private void mExibir_BarraDeStatus_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Menu Ajuda
        private void mAjuda_ExibirAjuda_Click(object sender, EventArgs e)
        {

        }

        private void mAjuda_EnviarComentarios_Click(object sender, EventArgs e)
        {

        }

        private void mAjuda_Sobre_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void AtualizarHistoricoRecentes()
        {
            if (Gerenciador.GetRecentes().Count < 1)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Enabled = false;
                item.Size = new Size(180, 22);
                item.Text = "(Vázio)";
                mArquivo_Recentes.DropDownItems.Add(item);
            }
            else
            {
                mArquivo_Recentes.DropDownItems.Clear();

                foreach (string file in Gerenciador.GetRecentes())
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.AutoSize = true;
                    item.Enabled = true;
                    item.Size = new Size(180, 22);
                    item.Text = file;
                    mArquivo_Recentes.DropDownItems.Add(item);
                }

                Gerenciador.AtualizarArquivoRecentes();
            }
        }

        private void SalvarArquivo(string path)
        {
            StreamWriter writer = new StreamWriter(path, false);
            try
            {
                writer.Write(txtConteudo.Text);
                Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
                Gerenciador.FileSaved = true;
            }
            catch (Exception) { throw; }
            writer.Close();
        }
    }
}
