using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM自助存取款终端
{
    public partial class FrmWithdrawalSuccessful : Form
    {
        public FrmWithdrawalSuccessful()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("0.00");
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContinueWithdrawal_Click(object sender, EventArgs e)
        {
            FrmWithdraw frmWithdraw = new FrmWithdraw();
            frmWithdraw.Show();
            this.Close();
        }

        private void btnBackToFrmSelectTransactionItem_Click(object sender, EventArgs e)
        {
            FrmSelectTransactionItem frmSelectTransactionItem = new FrmSelectTransactionItem();
            frmSelectTransactionItem.Show();
            this.Close();
        }

        private void txtAmount1_TextChanged(object sender, EventArgs e)
        {
            


        }
           
        

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            FrmShowBalance frmShowBalance = new FrmShowBalance();
            //Account useraccount = new Account();
            frmShowBalance.Show();
            
            this.Close();
        }

        public  void FrmWithdrawalSuccessful_Load(object sender, EventArgs e)
        {
          
        }
    }
}
