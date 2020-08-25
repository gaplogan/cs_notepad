namespace NotepadGAP
{
    partial class FormSobre
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
            this.linkYoutube = new System.Windows.Forms.LinkLabel();
            this.linkFacebook = new System.Windows.Forms.LinkLabel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.linkUdemy = new System.Windows.Forms.LinkLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkYoutube
            // 
            this.linkYoutube.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkYoutube.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkYoutube.Location = new System.Drawing.Point(42, 119);
            this.linkYoutube.Name = "linkYoutube";
            this.linkYoutube.Size = new System.Drawing.Size(500, 40);
            this.linkYoutube.TabIndex = 0;
            this.linkYoutube.TabStop = true;
            this.linkYoutube.Text = "Canal do Youtube";
            this.linkYoutube.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkYoutube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYoutube_LinkClicked);
            // 
            // linkFacebook
            // 
            this.linkFacebook.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFacebook.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkFacebook.Location = new System.Drawing.Point(42, 172);
            this.linkFacebook.Name = "linkFacebook";
            this.linkFacebook.Size = new System.Drawing.Size(500, 40);
            this.linkFacebook.TabIndex = 1;
            this.linkFacebook.TabStop = true;
            this.linkFacebook.Text = "Página do Facebook";
            this.linkFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFacebook_LinkClicked);
            // 
            // linkGitHub
            // 
            this.linkGitHub.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGitHub.Location = new System.Drawing.Point(42, 225);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(500, 40);
            this.linkGitHub.TabIndex = 2;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "Repositório do GitHub";
            this.linkGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // linkUdemy
            // 
            this.linkUdemy.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkUdemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUdemy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkUdemy.Location = new System.Drawing.Point(42, 66);
            this.linkUdemy.Name = "linkUdemy";
            this.linkUdemy.Size = new System.Drawing.Size(500, 40);
            this.linkUdemy.TabIndex = 3;
            this.linkUdemy.TabStop = true;
            this.linkUdemy.Text = "Perfil de Instrutor na Udemy";
            this.linkUdemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkUdemy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUdemy_LinkClicked);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(197, 287);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(191, 60);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sobre o Desenvolvedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.linkUdemy);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.linkFacebook);
            this.Controls.Add(this.linkYoutube);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormSobre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkYoutube;
        private System.Windows.Forms.LinkLabel linkFacebook;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.LinkLabel linkUdemy;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
    }
}