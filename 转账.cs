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
    public partial class FrmTransferAccount : Form
    {
        public FrmTransferAccount()
        {
            InitializeComponent();
        }

        private void btnExit7_Click(object sender, EventArgs e)
        {
            FrmSelectTransactionItem frmSelectTransactionItem = new FrmSelectTransactionItem();
            frmSelectTransactionItem.Show();
            this.Close();
        }

        private void btnConfirm3_Click(object sender, EventArgs e)
        {
            FrmLogin f1 = new FrmLogin();
            if (f1.PINTran(txtYollon.Text)) 
            {                
                f1.TransfrerAccount(txtTransferAmount.Text);//调用转账函数
            }
            
        }
    }
}
