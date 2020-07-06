using System;
using System.Windows.Forms;

namespace ATM自助存取款终端
{
    public partial class FrmShowBalance : Form
    {
        public FrmShowBalance()
        {
            InitializeComponent();
            FrmLogin f1 = new FrmLogin();
            txtavailableBlance.Text = f1.AvailableBalance();
            txtotalBalance.Text = f1.TotalBalance();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //BankDataBase bankDataBase = new BankDataBase();
           // Account useraccount = new Account();
            //FrmLogin frmLogin = new FrmLogin();

            //decimal totalbalance = bankDataBase.GetTotalBalance(int.Parse(frmLogin.txtAccount.Text));
            //txtotalBalance.Text = totalbalance.ToString();
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWithdraw2_Click(object sender, EventArgs e)
        {
            FrmWithdraw frmWithdraw = new FrmWithdraw();
            frmWithdraw.Show();
            this.Close();
        }

        private void btnExit5_Click(object sender, EventArgs e)
        {
            FrmSelectTransactionItem frmSelectTransactionItem = new FrmSelectTransactionItem();
            frmSelectTransactionItem.Show();
            this.Close();
        }

        private void txtavailableBlance_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmShowBalance_Load(object sender, EventArgs e)
        {
           // BankDataBase bankDataBase = new BankDataBase();
            //Account useraccount = new Account();
            //FrmLogin frmLogin = new FrmLogin();

            //decimal totalbalance = bankDataBase.GetTotalBalance(int.Parse(frmLogin.txtAccount.Text));
            //txtotalBalance.Text = totalbalance.ToString();
        }

        private void btnDeposit2_Click(object sender, EventArgs e)
        {
            FrmDeposit frmDeposit = new FrmDeposit();
            frmDeposit.Show();
            this.Close();
        }
    }
}
