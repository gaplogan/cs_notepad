namespace NotepadGAP
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Novo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_NovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivo_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Recentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivo_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_SalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivo_ConfigurarPagina = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_VisualizarImpressao = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivo_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Recortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Colar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditar_BuscarNaWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Localizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_LocalizarProxima = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_LocalizarAnterior = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Substituir = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_IrPara = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditar_SelecionarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_DataEHora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar_QuebraAutomaticaDeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar_Fonte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir_Zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir_Zoom_Ampliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir_Zoom_Reduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir_Zoom_RestaurarZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir_BarraDeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda_ExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda_EnviarComentarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mAjuda_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBar_LabelEncoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_LabelZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_LabelLinhaColuna = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContainerPrincipal = new System.Windows.Forms.ToolStripContainer();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.mEditar_Desfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Refazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.ContainerPrincipal.ContentPanel.SuspendLayout();
            this.ContainerPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo,
            this.menuEditar,
            this.menuFormatar,
            this.menuExibir,
            this.menuAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo_Novo,
            this.mArquivo_NovaJanela,
            this.toolStripSeparator1,
            this.mArquivo_Abrir,
            this.mArquivo_Recentes,
            this.toolStripSeparator2,
            this.mArquivo_Salvar,
            this.mArquivo_SalvarComo,
            this.toolStripSeparator3,
            this.mArquivo_ConfigurarPagina,
            this.mArquivo_VisualizarImpressao,
            this.mArquivo_Imprimir,
            this.toolStripSeparator4,
            this.mArquivo_Fechar,
            this.mArquivo_Sair});
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuArquivo.Text = "Arquivo";
            // 
            // mArquivo_Novo
            // 
            this.mArquivo_Novo.Name = "mArquivo_Novo";
            this.mArquivo_Novo.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Novo.Text = "Novo";
            this.mArquivo_Novo.Click += new System.EventHandler(this.mArquivo_Novo_Click);
            // 
            // mArquivo_NovaJanela
            // 
            this.mArquivo_NovaJanela.Name = "mArquivo_NovaJanela";
            this.mArquivo_NovaJanela.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_NovaJanela.Text = "Nova Janela";
            this.mArquivo_NovaJanela.Click += new System.EventHandler(this.mArquivo_NovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivo_Abrir
            // 
            this.mArquivo_Abrir.Name = "mArquivo_Abrir";
            this.mArquivo_Abrir.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Abrir.Text = "Abrir...";
            this.mArquivo_Abrir.Click += new System.EventHandler(this.mArquivo_Abrir_Click);
            // 
            // mArquivo_Recentes
            // 
            this.mArquivo_Recentes.Name = "mArquivo_Recentes";
            this.mArquivo_Recentes.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Recentes.Text = "Recentes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivo_Salvar
            // 
            this.mArquivo_Salvar.Name = "mArquivo_Salvar";
            this.mArquivo_Salvar.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Salvar.Text = "Salvar";
            this.mArquivo_Salvar.Click += new System.EventHandler(this.mArquivo_Salvar_Click);
            // 
            // mArquivo_SalvarComo
            // 
            this.mArquivo_SalvarComo.Name = "mArquivo_SalvarComo";
            this.mArquivo_SalvarComo.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_SalvarComo.Text = "Salvar Como...";
            this.mArquivo_SalvarComo.Click += new System.EventHandler(this.mArquivo_SalvarComo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivo_ConfigurarPagina
            // 
            this.mArquivo_ConfigurarPagina.Name = "mArquivo_ConfigurarPagina";
            this.mArquivo_ConfigurarPagina.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_ConfigurarPagina.Text = "Configurar Página";
            this.mArquivo_ConfigurarPagina.Click += new System.EventHandler(this.mArquivo_ConfigurarPagina_Click);
            // 
            // mArquivo_VisualizarImpressao
            // 
            this.mArquivo_VisualizarImpressao.Name = "mArquivo_VisualizarImpressao";
            this.mArquivo_VisualizarImpressao.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_VisualizarImpressao.Text = "Visualizar Impressão";
            this.mArquivo_VisualizarImpressao.Click += new System.EventHandler(this.mArquivo_VisualizarImpressao_Click);
            // 
            // mArquivo_Imprimir
            // 
            this.mArquivo_Imprimir.Name = "mArquivo_Imprimir";
            this.mArquivo_Imprimir.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Imprimir.Text = "Imprimir";
            this.mArquivo_Imprimir.Click += new System.EventHandler(this.mArquivo_Imprimir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivo_Fechar
            // 
            this.mArquivo_Fechar.Name = "mArquivo_Fechar";
            this.mArquivo_Fechar.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Fechar.Text = "Fechar";
            this.mArquivo_Fechar.Click += new System.EventHandler(this.mArquivo_Fechar_Click);
            // 
            // mArquivo_Sair
            // 
            this.mArquivo_Sair.Name = "mArquivo_Sair";
            this.mArquivo_Sair.Size = new System.Drawing.Size(180, 22);
            this.mArquivo_Sair.Text = "Sair";
            this.mArquivo_Sair.Click += new System.EventHandler(this.mArquivo_Sair_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditar_Desfazer,
            this.mEditar_Refazer,
            this.toolStripSeparator8,
            this.mEditar_Recortar,
            this.mEditar_Copiar,
            this.mEditar_Colar,
            this.mEditar_Excluir,
            this.toolStripSeparator5,
            this.mEditar_BuscarNaWeb,
            this.mEditar_Localizar,
            this.mEditar_LocalizarProxima,
            this.mEditar_LocalizarAnterior,
            this.mEditar_Substituir,
            this.mEditar_IrPara,
            this.toolStripSeparator6,
            this.mEditar_SelecionarTudo,
            this.mEditar_DataEHora});
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(49, 20);
            this.menuEditar.Text = "Editar";
            // 
            // mEditar_Recortar
            // 
            this.mEditar_Recortar.Name = "mEditar_Recortar";
            this.mEditar_Recortar.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Recortar.Text = "Recortar";
            this.mEditar_Recortar.Click += new System.EventHandler(this.mEditar_Recortar_Click);
            // 
            // mEditar_Copiar
            // 
            this.mEditar_Copiar.Name = "mEditar_Copiar";
            this.mEditar_Copiar.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Copiar.Text = "Copiar";
            this.mEditar_Copiar.Click += new System.EventHandler(this.mEditar_Copiar_Click);
            // 
            // mEditar_Colar
            // 
            this.mEditar_Colar.Name = "mEditar_Colar";
            this.mEditar_Colar.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Colar.Text = "Colar";
            this.mEditar_Colar.Click += new System.EventHandler(this.mEditar_Colar_Click);
            // 
            // mEditar_Excluir
            // 
            this.mEditar_Excluir.Name = "mEditar_Excluir";
            this.mEditar_Excluir.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Excluir.Text = "Excluir";
            this.mEditar_Excluir.Click += new System.EventHandler(this.mEditar_Excluir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // mEditar_BuscarNaWeb
            // 
            this.mEditar_BuscarNaWeb.Name = "mEditar_BuscarNaWeb";
            this.mEditar_BuscarNaWeb.Size = new System.Drawing.Size(180, 22);
            this.mEditar_BuscarNaWeb.Text = "Buscar na Web";
            this.mEditar_BuscarNaWeb.Click += new System.EventHandler(this.mEditar_BuscarNaWeb_Click);
            // 
            // mEditar_Localizar
            // 
            this.mEditar_Localizar.Name = "mEditar_Localizar";
            this.mEditar_Localizar.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Localizar.Text = "Localizar";
            this.mEditar_Localizar.Click += new System.EventHandler(this.mEditar_Localizar_Click);
            // 
            // mEditar_LocalizarProxima
            // 
            this.mEditar_LocalizarProxima.Name = "mEditar_LocalizarProxima";
            this.mEditar_LocalizarProxima.Size = new System.Drawing.Size(180, 22);
            this.mEditar_LocalizarProxima.Text = "Localizar Próxima";
            this.mEditar_LocalizarProxima.Click += new System.EventHandler(this.mEditar_LocalizarProxima_Click);
            // 
            // mEditar_LocalizarAnterior
            // 
            this.mEditar_LocalizarAnterior.Name = "mEditar_LocalizarAnterior";
            this.mEditar_LocalizarAnterior.Size = new System.Drawing.Size(180, 22);
            this.mEditar_LocalizarAnterior.Text = "Localizar Anterior";
            this.mEditar_LocalizarAnterior.Click += new System.EventHandler(this.mEditar_LocalizarAnterior_Click);
            // 
            // mEditar_Substituir
            // 
            this.mEditar_Substituir.Name = "mEditar_Substituir";
            this.mEditar_Substituir.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Substituir.Text = "Substituir";
            this.mEditar_Substituir.Click += new System.EventHandler(this.mEditar_Substituir_Click);
            // 
            // mEditar_IrPara
            // 
            this.mEditar_IrPara.Name = "mEditar_IrPara";
            this.mEditar_IrPara.Size = new System.Drawing.Size(180, 22);
            this.mEditar_IrPara.Text = "Ir Para...";
            this.mEditar_IrPara.Click += new System.EventHandler(this.mEditar_IrPara_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // mEditar_SelecionarTudo
            // 
            this.mEditar_SelecionarTudo.Name = "mEditar_SelecionarTudo";
            this.mEditar_SelecionarTudo.Size = new System.Drawing.Size(180, 22);
            this.mEditar_SelecionarTudo.Text = "Selecionar Tudo";
            this.mEditar_SelecionarTudo.Click += new System.EventHandler(this.mEditar_SelecionarTudo_Click);
            // 
            // mEditar_DataEHora
            // 
            this.mEditar_DataEHora.Name = "mEditar_DataEHora";
            this.mEditar_DataEHora.Size = new System.Drawing.Size(180, 22);
            this.mEditar_DataEHora.Text = "Data e Hora";
            this.mEditar_DataEHora.Click += new System.EventHandler(this.mEditar_DataEHora_Click);
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatar_QuebraAutomaticaDeLinha,
            this.mFormatar_Fonte});
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(67, 20);
            this.menuFormatar.Text = "Formatar";
            // 
            // mFormatar_QuebraAutomaticaDeLinha
            // 
            this.mFormatar_QuebraAutomaticaDeLinha.CheckOnClick = true;
            this.mFormatar_QuebraAutomaticaDeLinha.Name = "mFormatar_QuebraAutomaticaDeLinha";
            this.mFormatar_QuebraAutomaticaDeLinha.Size = new System.Drawing.Size(224, 22);
            this.mFormatar_QuebraAutomaticaDeLinha.Text = "Quebra automática de Linha";
            this.mFormatar_QuebraAutomaticaDeLinha.Click += new System.EventHandler(this.mFormatar_QuebraAutomaticaDeLinha_Click);
            // 
            // mFormatar_Fonte
            // 
            this.mFormatar_Fonte.Name = "mFormatar_Fonte";
            this.mFormatar_Fonte.Size = new System.Drawing.Size(224, 22);
            this.mFormatar_Fonte.Text = "Fonte";
            this.mFormatar_Fonte.Click += new System.EventHandler(this.mFormatar_Fonte_Click);
            // 
            // menuExibir
            // 
            this.menuExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibir_Zoom,
            this.mExibir_BarraDeStatus});
            this.menuExibir.Name = "menuExibir";
            this.menuExibir.Size = new System.Drawing.Size(48, 20);
            this.menuExibir.Text = "Exibir";
            // 
            // mExibir_Zoom
            // 
            this.mExibir_Zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibir_Zoom_Ampliar,
            this.mExibir_Zoom_Reduzir,
            this.mExibir_Zoom_RestaurarZoom});
            this.mExibir_Zoom.Name = "mExibir_Zoom";
            this.mExibir_Zoom.Size = new System.Drawing.Size(152, 22);
            this.mExibir_Zoom.Text = "Zoom";
            // 
            // mExibir_Zoom_Ampliar
            // 
            this.mExibir_Zoom_Ampliar.Name = "mExibir_Zoom_Ampliar";
            this.mExibir_Zoom_Ampliar.ShortcutKeyDisplayString = "Ctrl + \'+\'";
            this.mExibir_Zoom_Ampliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibir_Zoom_Ampliar.Size = new System.Drawing.Size(210, 22);
            this.mExibir_Zoom_Ampliar.Text = "Ampliar";
            this.mExibir_Zoom_Ampliar.Click += new System.EventHandler(this.mExibir_Zoom_Ampliar_Click);
            // 
            // mExibir_Zoom_Reduzir
            // 
            this.mExibir_Zoom_Reduzir.Name = "mExibir_Zoom_Reduzir";
            this.mExibir_Zoom_Reduzir.ShortcutKeyDisplayString = "Ctrl + \'-\'";
            this.mExibir_Zoom_Reduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibir_Zoom_Reduzir.Size = new System.Drawing.Size(210, 22);
            this.mExibir_Zoom_Reduzir.Text = "Reduzir";
            this.mExibir_Zoom_Reduzir.Click += new System.EventHandler(this.mExibir_Zoom_Reduzir_Click);
            // 
            // mExibir_Zoom_RestaurarZoom
            // 
            this.mExibir_Zoom_RestaurarZoom.Name = "mExibir_Zoom_RestaurarZoom";
            this.mExibir_Zoom_RestaurarZoom.ShortcutKeyDisplayString = "Ctrl + \'0\'";
            this.mExibir_Zoom_RestaurarZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibir_Zoom_RestaurarZoom.Size = new System.Drawing.Size(210, 22);
            this.mExibir_Zoom_RestaurarZoom.Text = "Restaurar Zoom";
            this.mExibir_Zoom_RestaurarZoom.Click += new System.EventHandler(this.mExibir_Zoom_RestaurarZoom_Click);
            // 
            // mExibir_BarraDeStatus
            // 
            this.mExibir_BarraDeStatus.Checked = true;
            this.mExibir_BarraDeStatus.CheckOnClick = true;
            this.mExibir_BarraDeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibir_BarraDeStatus.Name = "mExibir_BarraDeStatus";
            this.mExibir_BarraDeStatus.Size = new System.Drawing.Size(152, 22);
            this.mExibir_BarraDeStatus.Text = "Barra de Status";
            this.mExibir_BarraDeStatus.Click += new System.EventHandler(this.mExibir_BarraDeStatus_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjuda_ExibirAjuda,
            this.mAjuda_EnviarComentarios,
            this.toolStripSeparator7,
            this.mAjuda_Sobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(50, 20);
            this.menuAjuda.Text = "Ajuda";
            // 
            // mAjuda_ExibirAjuda
            // 
            this.mAjuda_ExibirAjuda.Name = "mAjuda_ExibirAjuda";
            this.mAjuda_ExibirAjuda.Size = new System.Drawing.Size(177, 22);
            this.mAjuda_ExibirAjuda.Text = "Exibir Ajuda";
            this.mAjuda_ExibirAjuda.Click += new System.EventHandler(this.mAjuda_ExibirAjuda_Click);
            // 
            // mAjuda_EnviarComentarios
            // 
            this.mAjuda_EnviarComentarios.Name = "mAjuda_EnviarComentarios";
            this.mAjuda_EnviarComentarios.Size = new System.Drawing.Size(177, 22);
            this.mAjuda_EnviarComentarios.Text = "Enviar Comentários";
            this.mAjuda_EnviarComentarios.Click += new System.EventHandler(this.mAjuda_EnviarComentarios_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(174, 6);
            // 
            // mAjuda_Sobre
            // 
            this.mAjuda_Sobre.Name = "mAjuda_Sobre";
            this.mAjuda_Sobre.Size = new System.Drawing.Size(177, 22);
            this.mAjuda_Sobre.Text = "Sobre";
            this.mAjuda_Sobre.Click += new System.EventHandler(this.mAjuda_Sobre_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar_LabelEncoding,
            this.statusBar_LabelZoom,
            this.statusBar_LabelLinhaColuna});
            this.statusBar.Location = new System.Drawing.Point(0, 439);
            this.statusBar.Name = "statusBar";
            this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // statusBar_LabelEncoding
            // 
            this.statusBar_LabelEncoding.Name = "statusBar_LabelEncoding";
            this.statusBar_LabelEncoding.Size = new System.Drawing.Size(57, 17);
            this.statusBar_LabelEncoding.Text = "Encoding";
            // 
            // statusBar_LabelZoom
            // 
            this.statusBar_LabelZoom.Name = "statusBar_LabelZoom";
            this.statusBar_LabelZoom.Size = new System.Drawing.Size(35, 17);
            this.statusBar_LabelZoom.Text = "100%";
            // 
            // statusBar_LabelLinhaColuna
            // 
            this.statusBar_LabelLinhaColuna.Name = "statusBar_LabelLinhaColuna";
            this.statusBar_LabelLinhaColuna.Size = new System.Drawing.Size(80, 17);
            this.statusBar_LabelLinhaColuna.Text = "Linha, Coluna";
            // 
            // ContainerPrincipal
            // 
            // 
            // ContainerPrincipal.ContentPanel
            // 
            this.ContainerPrincipal.ContentPanel.Controls.Add(this.txtConteudo);
            this.ContainerPrincipal.ContentPanel.Size = new System.Drawing.Size(784, 390);
            this.ContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPrincipal.Location = new System.Drawing.Point(0, 24);
            this.ContainerPrincipal.Name = "ContainerPrincipal";
            this.ContainerPrincipal.Size = new System.Drawing.Size(784, 415);
            this.ContainerPrincipal.TabIndex = 3;
            this.ContainerPrincipal.Text = "toolStripContainer1";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(0, 0);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 390);
            this.txtConteudo.TabIndex = 0;
            this.txtConteudo.Text = "";
            this.txtConteudo.SelectionChanged += new System.EventHandler(this.txtConteudo_SelectionChanged);
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // mEditar_Desfazer
            // 
            this.mEditar_Desfazer.Name = "mEditar_Desfazer";
            this.mEditar_Desfazer.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Desfazer.Text = "Desfazer";
            this.mEditar_Desfazer.Click += new System.EventHandler(this.mEditar_Desfazer_Click);
            // 
            // mEditar_Refazer
            // 
            this.mEditar_Refazer.Name = "mEditar_Refazer";
            this.mEditar_Refazer.Size = new System.Drawing.Size(180, 22);
            this.mEditar_Refazer.Text = "Refazer";
            this.mEditar_Refazer.Click += new System.EventHandler(this.mEditar_Refazer_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ContainerPrincipal);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad GAP";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ContainerPrincipal.ContentPanel.ResumeLayout(false);
            this.ContainerPrincipal.ResumeLayout(false);
            this.ContainerPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Novo;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_NovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Abrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Recentes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Salvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_SalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_ConfigurarPagina;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_VisualizarImpressao;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Fechar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Sair;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Recortar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Copiar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Colar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mEditar_BuscarNaWeb;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Localizar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_LocalizarProxima;
        private System.Windows.Forms.ToolStripMenuItem mEditar_LocalizarAnterior;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Substituir;
        private System.Windows.Forms.ToolStripMenuItem mEditar_IrPara;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mEditar_SelecionarTudo;
        private System.Windows.Forms.ToolStripMenuItem mEditar_DataEHora;
        private System.Windows.Forms.ToolStripMenuItem menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem mFormatar_QuebraAutomaticaDeLinha;
        private System.Windows.Forms.ToolStripMenuItem mFormatar_Fonte;
        private System.Windows.Forms.ToolStripMenuItem menuExibir;
        private System.Windows.Forms.ToolStripMenuItem mExibir_Zoom;
        private System.Windows.Forms.ToolStripMenuItem mExibir_Zoom_Ampliar;
        private System.Windows.Forms.ToolStripMenuItem mExibir_Zoom_Reduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibir_Zoom_RestaurarZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibir_BarraDeStatus;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mAjuda_ExibirAjuda;
        private System.Windows.Forms.ToolStripMenuItem mAjuda_EnviarComentarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mAjuda_Sobre;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripContainer ContainerPrincipal;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_LabelLinhaColuna;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_LabelZoom;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_LabelEncoding;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Desfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Refazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}

