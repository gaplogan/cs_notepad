using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            txtConteudo.WordWrap = mFormatar_QuebraAutomaticaDeLinha.Checked;
            statusBar.Visible = mExibir_BarraDeStatus.Checked;
            statusBar_LabelZoom.Text = txtConteudo.ZoomFactor * 100 + "%";
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
            txtConteudo.Rtf = "";
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
                    try
                    {
                        switch (Gerenciador.FileExt)
                        {
                            default:
                                txtConteudo.Text = stream.ReadToEnd();
                                break;
                            case ".txt":
                                txtConteudo.Text = stream.ReadToEnd();
                                break;
                            case ".rtf":
                                txtConteudo.Rtf = stream.ReadToEnd();
                                break;
                        }

                        statusBar_LabelEncoding.Text = encoding.EncodingName;
                        statusBar_LabelLinhaColuna.Text = txtConteudo.SelectionStart.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Formato de arquivo não suportado.");
                    }
                    stream.Close();

                    Gerenciador.AddRecente(f.FullName);
                    AtualizarHistoricoRecentes();
                    Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
                    Gerenciador.FileSaved = true;
                }
                else
                {
                    MessageBox.Show("O arquivo não existe ou foi deletado.", "Erro ao tentar abrir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Gerenciador.DelRecente(dialog.FileName);
                    AtualizarHistoricoRecentes();
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
            mArquivo_Novo_Click(sender, e);
        }

        private void mArquivo_Sair_Click(object sender, EventArgs e)
        {
            mArquivo_Novo_Click(sender, e);
            Application.Exit();
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
            //txtConteudo.SelectionStart;
        }

        private void mEditar_IrPara_Click(object sender, EventArgs e)
        {

        }

        private void mEditar_SelecionarTudo_Click(object sender, EventArgs e)
        {
            txtConteudo.SelectAll();
        }

        private void mEditar_DataEHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (txtConteudo.SelectionStart == txtConteudo.Text.Length)
            {
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++)
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];
                }
                else
                {
                    temp += txtConteudo.Text[i];
                }                
            }

            txtConteudo.Text = temp;
            txtConteudo.SelectionStart = index + dataHora.Length;
        }

        #endregion

        #region Menu Formatar
        private void mFormatar_QuebraAutomaticaDeLinha_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatar_QuebraAutomaticaDeLinha.Checked;
        }

        private void mFormatar_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = txtConteudo.Font;
            dialog.ShowColor = true;
            dialog.AllowScriptChange = true;
            dialog.Color = txtConteudo.ForeColor;

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                txtConteudo.Font = dialog.Font;
                txtConteudo.ForeColor = dialog.Color;
            }
        }

        #endregion

        #region Menu Exibir
        private void mExibir_Zoom_Ampliar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.1f;
            if (txtConteudo.ZoomFactor > 10f) txtConteudo.ZoomFactor = 10f;
            statusBar_LabelZoom.Text = Math.Round(txtConteudo.ZoomFactor * 100) + "%";
        }

        private void mExibir_Zoom_Reduzir_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor -= 0.1f;
            if (txtConteudo.ZoomFactor < 0.2f) txtConteudo.ZoomFactor = 0.2f;
            statusBar_LabelZoom.Text = Math.Round(txtConteudo.ZoomFactor * 100) + "%";
        }

        private void mExibir_Zoom_RestaurarZoom_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1;
            statusBar_LabelZoom.Text = Math.Round(txtConteudo.ZoomFactor * 100) + "%";
        }

        private void mExibir_BarraDeStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibir_BarraDeStatus.Checked;
        }

        #endregion

        #region Menu Ajuda
        private void mAjuda_ExibirAjuda_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/TechCursoseTutoriais");
        }

        private void mAjuda_EnviarComentarios_Click(object sender, EventArgs e)
        {
            new FormEnviarComentarios().ShowDialog();
        }

        private void mAjuda_Sobre_Click(object sender, EventArgs e)
        {
            new FormSobre().ShowDialog();
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
                    item.Click += new EventHandler((object sender, EventArgs e) => 
                    {
                        if (!Gerenciador.FileSaved)
                        {
                            DialogResult result = MessageBox.Show($"Deseja salvar as alterações em \"{Gerenciador.FileName}{Gerenciador.FileExt}\" antes de sair?", "Salvar...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Cancel || result == DialogResult.Abort)
                                return;
                            else if (result == DialogResult.Yes)
                                mArquivo_Salvar_Click(sender, e);
                        }

                        if (File.Exists(file))
                        {
                            FileInfo f = new FileInfo(file);
                            Gerenciador.FileName = (f.Name.Contains('.')) ? f.Name.Substring(0, f.Name.LastIndexOf('.')) : f.Name;
                            Gerenciador.FileExt = f.Extension;
                            Gerenciador.FolderPath = f.DirectoryName + "\\";

                            StreamReader stream = new StreamReader(f.FullName, true);
                            Encoding encoding = stream.CurrentEncoding;
                            try
                            {
                                switch (Gerenciador.FileExt)
                                {
                                    default:

                                        break;
                                    case ".txt":
                                        txtConteudo.Text = stream.ReadToEnd();
                                        break;
                                    case ".rtf":
                                        txtConteudo.Rtf = stream.ReadToEnd();
                                        break;
                                }
                                
                                statusBar_LabelEncoding.Text = encoding.EncodingName;
                                statusBar_LabelLinhaColuna.Text = txtConteudo.SelectionStart.ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Formato de arquivo não suportado.");
                            }                            
                            stream.Close();

                            Gerenciador.AddRecente(f.FullName);
                            AtualizarHistoricoRecentes();
                            Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
                            Gerenciador.FileSaved = true;
                        }
                        else
                        {
                            MessageBox.Show("O arquivo não existe ou foi deletado.", "Erro ao tentar abrir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Gerenciador.DelRecente(file);
                            AtualizarHistoricoRecentes();
                        }
                    });
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
                string ext = (path.Contains('.'))? path.Substring(path.LastIndexOf('.')): "";
                switch (Gerenciador.FileExt)
                {
                    default:
                        writer.Write(txtConteudo.Text);
                        break;
                    case ".txt":
                        writer.Write(txtConteudo.Text);
                        break;
                    case ".rtf":
                        writer.Write(txtConteudo.Rtf);
                        break;
                }
                Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
                Gerenciador.FileSaved = true;
            }
            catch (Exception) { throw; }
            writer.Close();
        }
    }
}
