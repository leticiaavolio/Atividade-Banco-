using PrjAtivida_Banco.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjAtivida_Banco.forms;

namespace PrjAtivida_Banco
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarConta frmCriarConta = new FrmCriarConta();
            frmCriarConta.MdiParent = this;
            frmCriarConta.Show();
        }

        private void fecharContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSacar frmSacar = new FrmSacar();
            frmSacar.MdiParent = this;
            frmSacar.Show();
        }

        private void sacarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSacar frmSacar = new FrmSacar();
            frmSacar.MdiParent = this;
            frmSacar.Show();
        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepositar frmDepositar = new FrmDepositar();
            frmDepositar.MdiParent = this;
            frmDepositar.Show();
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransferir frmTransferir = new FrmTransferir();
            frmTransferir.MdiParent = this;
            frmTransferir.Show();
        }

        private void verSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerSaldo frmVerSaldo = new FrmVerSaldo();
            frmVerSaldo.MdiParent = this;
            frmVerSaldo.Show();
        }
    }
}
