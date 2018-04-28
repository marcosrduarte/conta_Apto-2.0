namespace ContasApto2._0
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQtdmoradores = new System.Windows.Forms.Label();
            this.lblMoradores = new System.Windows.Forms.Label();
            this.lblAluguel = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblOutros = new System.Windows.Forms.Label();
            this.txbAluguel = new System.Windows.Forms.TextBox();
            this.txbCondominio = new System.Windows.Forms.TextBox();
            this.txbEnergia = new System.Windows.Forms.TextBox();
            this.txbGas = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbOutros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbQtdMoradores = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreODesenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQtdMoradores)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQtdmoradores
            // 
            this.lblQtdmoradores.AutoSize = true;
            this.lblQtdmoradores.Location = new System.Drawing.Point(264, -41);
            this.lblQtdmoradores.Name = "lblQtdmoradores";
            this.lblQtdmoradores.Size = new System.Drawing.Size(174, 17);
            this.lblQtdmoradores.TabIndex = 36;
            this.lblQtdmoradores.Text = "Quantidade de Moradores";
            // 
            // lblMoradores
            // 
            this.lblMoradores.AutoSize = true;
            this.lblMoradores.Location = new System.Drawing.Point(12, 41);
            this.lblMoradores.Name = "lblMoradores";
            this.lblMoradores.Size = new System.Drawing.Size(174, 17);
            this.lblMoradores.TabIndex = 38;
            this.lblMoradores.Text = "Quantidade de Moradores";
            // 
            // lblAluguel
            // 
            this.lblAluguel.AutoSize = true;
            this.lblAluguel.Location = new System.Drawing.Point(116, 94);
            this.lblAluguel.Name = "lblAluguel";
            this.lblAluguel.Size = new System.Drawing.Size(55, 17);
            this.lblAluguel.TabIndex = 39;
            this.lblAluguel.Text = "Aluguel";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(116, 155);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(82, 17);
            this.lblCondominio.TabIndex = 40;
            this.lblCondominio.Text = "Condominio";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(116, 216);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(57, 17);
            this.lblEnergia.TabIndex = 41;
            this.lblEnergia.Text = "Energia";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Location = new System.Drawing.Point(116, 277);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(34, 17);
            this.lblGas.TabIndex = 42;
            this.lblGas.Text = "Gás";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(116, 338);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 43;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblOutros
            // 
            this.lblOutros.AutoSize = true;
            this.lblOutros.Location = new System.Drawing.Point(116, 399);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(51, 17);
            this.lblOutros.TabIndex = 44;
            this.lblOutros.Text = "Outros";
            // 
            // txbAluguel
            // 
            this.txbAluguel.Location = new System.Drawing.Point(119, 122);
            this.txbAluguel.Name = "txbAluguel";
            this.txbAluguel.Size = new System.Drawing.Size(150, 22);
            this.txbAluguel.TabIndex = 45;
            // 
            // txbCondominio
            // 
            this.txbCondominio.Location = new System.Drawing.Point(119, 183);
            this.txbCondominio.Name = "txbCondominio";
            this.txbCondominio.Size = new System.Drawing.Size(150, 22);
            this.txbCondominio.TabIndex = 46;
            // 
            // txbEnergia
            // 
            this.txbEnergia.Location = new System.Drawing.Point(119, 244);
            this.txbEnergia.Name = "txbEnergia";
            this.txbEnergia.Size = new System.Drawing.Size(150, 22);
            this.txbEnergia.TabIndex = 47;
            // 
            // txbGas
            // 
            this.txbGas.Location = new System.Drawing.Point(119, 305);
            this.txbGas.Name = "txbGas";
            this.txbGas.Size = new System.Drawing.Size(150, 22);
            this.txbGas.TabIndex = 48;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(119, 366);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(150, 22);
            this.txbTelefone.TabIndex = 49;
            // 
            // txbOutros
            // 
            this.txbOutros.Location = new System.Drawing.Point(119, 427);
            this.txbOutros.Name = "txbOutros";
            this.txbOutros.Size = new System.Drawing.Size(150, 22);
            this.txbOutros.TabIndex = 50;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 478);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 35);
            this.btnCalcular.TabIndex = 51;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbQtdMoradores
            // 
            this.cmbQtdMoradores.Location = new System.Drawing.Point(15, 61);
            this.cmbQtdMoradores.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.cmbQtdMoradores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbQtdMoradores.Name = "cmbQtdMoradores";
            this.cmbQtdMoradores.Size = new System.Drawing.Size(42, 22);
            this.cmbQtdMoradores.TabIndex = 52;
            this.cmbQtdMoradores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.sobreOAppToolStripMenuItem,
            this.sobreODesenvolvedorToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(386, 28);
            this.menuStrip2.TabIndex = 54;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // sobreOAppToolStripMenuItem
            // 
            this.sobreOAppToolStripMenuItem.Name = "sobreOAppToolStripMenuItem";
            this.sobreOAppToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.sobreOAppToolStripMenuItem.Text = "Sobre o app";
            this.sobreOAppToolStripMenuItem.Click += new System.EventHandler(this.sobreOAppToolStripMenuItem_Click);
            // 
            // sobreODesenvolvedorToolStripMenuItem
            // 
            this.sobreODesenvolvedorToolStripMenuItem.Name = "sobreODesenvolvedorToolStripMenuItem";
            this.sobreODesenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.sobreODesenvolvedorToolStripMenuItem.Text = "Sobre o Desenvolvedor";
            this.sobreODesenvolvedorToolStripMenuItem.Click += new System.EventHandler(this.sobreODesenvolvedorToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(386, 549);
            this.Controls.Add(this.cmbQtdMoradores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblQtdmoradores);
            this.Controls.Add(this.txbOutros);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbGas);
            this.Controls.Add(this.txbEnergia);
            this.Controls.Add(this.txbCondominio);
            this.Controls.Add(this.txbAluguel);
            this.Controls.Add(this.lblOutros);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblEnergia);
            this.Controls.Add(this.lblCondominio);
            this.Controls.Add(this.lblAluguel);
            this.Controls.Add(this.lblMoradores);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmPrincipal";
            this.Text = "Rateio de Despesas 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.cmbQtdMoradores)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQtdmoradores;
        private System.Windows.Forms.Label lblMoradores;
        private System.Windows.Forms.Label lblAluguel;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblOutros;
        private System.Windows.Forms.TextBox txbAluguel;
        private System.Windows.Forms.TextBox txbCondominio;
        private System.Windows.Forms.TextBox txbEnergia;
        private System.Windows.Forms.TextBox txbGas;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbOutros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown cmbQtdMoradores;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreODesenvolvedorToolStripMenuItem;
    }
}

