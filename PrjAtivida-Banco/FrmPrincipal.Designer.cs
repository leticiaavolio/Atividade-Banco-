namespace PrjAtivida_Banco
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            contasToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            fecharContaToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            sacarToolStripMenuItem = new ToolStripMenuItem();
            depositarToolStripMenuItem = new ToolStripMenuItem();
            transferirToolStripMenuItem = new ToolStripMenuItem();
            verSaldoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contasToolStripMenuItem, operaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1124, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contasToolStripMenuItem
            // 
            contasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, fecharContaToolStripMenuItem });
            contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            contasToolStripMenuItem.Size = new Size(56, 20);
            contasToolStripMenuItem.Text = "Contas";
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(144, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // fecharContaToolStripMenuItem
            // 
            fecharContaToolStripMenuItem.Name = "fecharContaToolStripMenuItem";
            fecharContaToolStripMenuItem.Size = new Size(144, 22);
            fecharContaToolStripMenuItem.Text = "Fechar Conta";
            fecharContaToolStripMenuItem.Click += fecharContaToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sacarToolStripMenuItem, depositarToolStripMenuItem, transferirToolStripMenuItem, verSaldoToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // sacarToolStripMenuItem
            // 
            sacarToolStripMenuItem.Name = "sacarToolStripMenuItem";
            sacarToolStripMenuItem.Size = new Size(180, 22);
            sacarToolStripMenuItem.Text = "Sacar";
            sacarToolStripMenuItem.Click += sacarToolStripMenuItem_Click;
            // 
            // depositarToolStripMenuItem
            // 
            depositarToolStripMenuItem.Name = "depositarToolStripMenuItem";
            depositarToolStripMenuItem.Size = new Size(180, 22);
            depositarToolStripMenuItem.Text = "Depositar";
            depositarToolStripMenuItem.Click += depositarToolStripMenuItem_Click;
            // 
            // transferirToolStripMenuItem
            // 
            transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            transferirToolStripMenuItem.Size = new Size(180, 22);
            transferirToolStripMenuItem.Text = "Transferir";
            transferirToolStripMenuItem.Click += transferirToolStripMenuItem_Click;
            // 
            // verSaldoToolStripMenuItem
            // 
            verSaldoToolStripMenuItem.Name = "verSaldoToolStripMenuItem";
            verSaldoToolStripMenuItem.Size = new Size(180, 22);
            verSaldoToolStripMenuItem.Text = "Ver Saldo";
            verSaldoToolStripMenuItem.Click += verSaldoToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 590);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contasToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem fecharContaToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem sacarToolStripMenuItem;
        private ToolStripMenuItem depositarToolStripMenuItem;
        private ToolStripMenuItem transferirToolStripMenuItem;
        private ToolStripMenuItem verSaldoToolStripMenuItem;
    }
}