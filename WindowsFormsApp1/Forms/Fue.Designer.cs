
namespace WindowsFormsApp1.Forms
{
    partial class Fue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicializaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGestaoEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstabelecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemAoNivelNacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maioresEmpresasPorVVNEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 138);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicializaçãoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.tabelasToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicializaçãoToolStripMenuItem
            // 
            this.inicializaçãoToolStripMenuItem.Name = "inicializaçãoToolStripMenuItem";
            this.inicializaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.inicializaçãoToolStripMenuItem.Text = "Inicialização";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGestaoEmpresas,
            this.consultarEmpresaToolStripMenuItem,
            this.listaDeEmpresasToolStripMenuItem,
            this.listaDeEstabelecimentoToolStripMenuItem,
            this.arquivoToolStripMenuItem,
            this.listagemAoNivelNacionalToolStripMenuItem,
            this.maioresEmpresasPorVVNEToolStripMenuItem,
            this.estatísticasToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // tsmiGestaoEmpresas
            // 
            this.tsmiGestaoEmpresas.Name = "tsmiGestaoEmpresas";
            this.tsmiGestaoEmpresas.Size = new System.Drawing.Size(250, 22);
            this.tsmiGestaoEmpresas.Text = "Gestão de Empresas";
            this.tsmiGestaoEmpresas.Click += new System.EventHandler(this.tsmiGestaoEmpresas_Click);
            // 
            // consultarEmpresaToolStripMenuItem
            // 
            this.consultarEmpresaToolStripMenuItem.Name = "consultarEmpresaToolStripMenuItem";
            this.consultarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.consultarEmpresaToolStripMenuItem.Text = "Consultar Empresa";
            this.consultarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpresaToolStripMenuItem_Click);
            // 
            // listaDeEmpresasToolStripMenuItem
            // 
            this.listaDeEmpresasToolStripMenuItem.Name = "listaDeEmpresasToolStripMenuItem";
            this.listaDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listaDeEmpresasToolStripMenuItem.Text = "Lista de Empresas";
            // 
            // listaDeEstabelecimentoToolStripMenuItem
            // 
            this.listaDeEstabelecimentoToolStripMenuItem.Name = "listaDeEstabelecimentoToolStripMenuItem";
            this.listaDeEstabelecimentoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listaDeEstabelecimentoToolStripMenuItem.Text = "Lista de Estabelecimento";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // listagemAoNivelNacionalToolStripMenuItem
            // 
            this.listagemAoNivelNacionalToolStripMenuItem.Name = "listagemAoNivelNacionalToolStripMenuItem";
            this.listagemAoNivelNacionalToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.listagemAoNivelNacionalToolStripMenuItem.Text = "Listagem ao Nivel Nacional";
            // 
            // maioresEmpresasPorVVNEToolStripMenuItem
            // 
            this.maioresEmpresasPorVVNEToolStripMenuItem.Name = "maioresEmpresasPorVVNEToolStripMenuItem";
            this.maioresEmpresasPorVVNEToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.maioresEmpresasPorVVNEToolStripMenuItem.Text = "Maiores empresas por VVN e NPS";
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 312);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Fue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fue";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicializaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstabelecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemAoNivelNacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maioresEmpresasPorVVNEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmiGestaoEmpresas;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}