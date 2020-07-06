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
    public partial class FrmWithdraw : Form
    {
        public FrmWithdraw()
        {
            InitializeComponent();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            FrmSelectTransactionItem frmSelectTransactionItem = new FrmSelectTransactionItem();
            frmSelectTransactionItem.Show();
            this.Close();
        }

        private void btnWithdraw100_Click(object sender, EventArgs e)
        {

            Button a = (Button)sender;//判断按下的是哪个按钮
            if (txtWithdrawalAmount.Text == "")
            {
                txtWithdrawalAmount.Text = a.Text;//在文本框中显示btnWithdraw100的text值
            }


        }

        private void btnWithdraw300_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;//判断按下的是哪个按钮
            if (txtWithdrawalAmount.Text == "")
            {
                txtWithdrawalAmount.Text = a.Text;//在文本框中显示btnWithdraw300的text值
            }
        }

        private void btnWithdraw1000_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;//判断按下的是哪个按钮
            if (txtWithdrawalAmount.Text == "")
            {
                txtWithdrawalAmount.Text = a.Text;//在文本框中显示btnWithdraw1000的text值
            }
        }

        private void btnWithdraw2000_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;//判断按下的是哪个按钮
            if (txtWithdrawalAmount.Text == "")
            {
                txtWithdrawalAmount.Text = a.Text;//在文本框中显示btnWithdraw2000的text值
            }
        }

        private void btnWithdraw3000_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;//判断按下的是哪个按钮
            if (txtWithdrawalAmount.Text == "")
            {
                txtWithdrawalAmount.Text = a.Text;//在文本框中显示btnWithdraw3000的text值
            }
        }

        private void btnWithdraw5000_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;//判断按下的是哪个按钮
            if (txtWithdrawalAmount.Text == "")
            {
                txtWithdrawalAmount.Text = a.Text;//在文本框中显示btnWithdraw5000的text值
            }
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            FrmLogin f1 = new FrmLogin();
            f1.Withdraw(txtWithdrawalAmount.Text);
            this.Close();
        }

        public void FrmWithdraw_Load(object sender, EventArgs e)
        { 

        }

        private void txtWithdrawalAmount_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
