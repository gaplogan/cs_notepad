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
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + " - " + Gerenciador.FileName + Gerenciador.FileExt;
        }

        #region Menu Arquivo
        private void mArquivo_Novo_Click(object sender, EventArgs e)
        {
            if (!Gerenciador.FileOpen)
            {
                MessageBox.Show($"Deseja salvar as alterações em \"{Gerenciador.FileName}{Gerenciador.FileExt}\" antes de sair?", "Salvar...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void mArquivo_NovaJanela_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void mArquivo_Abrir_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_Recentes_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void mArquivo_SalvarComo_Click(object sender, EventArgs e)
        {

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
    }
}
