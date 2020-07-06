using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//窗体应用必须导入的命名空间

namespace ATM自助存取款终端
{
    public delegate void Warning();
    
    public partial class FrmLogin : Form
    {
        public event Warning BigMoneyFetched;
        static BankDataBase user = new BankDataBase();
        static BankDataBase transferuser = new BankDataBase();
        public static int Transnum;//确认转账的是哪个账号
        public static int Choose;//确认登录操作的是哪个账号
        
        public FrmLogin()
        {
            InitializeComponent();//此方法不能丢,否则窗体不能正常显示控件
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        FrmSelectTransactionItem frmSelect = new FrmSelectTransactionItem();//FrmSelectTransactionItem为跳转页面的窗体名称
        private void btnLogin_Click(object sender, EventArgs e)
        {
            BankDataBase userAccount = new BankDataBase();
            if (txtAccount.Text == "")
            {
                MessageBox.Show("请输入账号");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("请输入密码");
            }
            else if (PIN(txtAccount.Text, txtPassword.Text))
            {
                frmSelect.Show();//输入正确,页面跳转
                //MessageBox.Show(Choose.ToString());测试代码
            }
            else
            {
                MessageBox.Show("账号或密码输入错误,请重新输入");
            }     
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //判断账户密码是否存在,如果存在是否输入正确
        bool PIN(string account,string password)//用string类型好从txt_中传参,不然还要类型转换
        {
            for(int i = 0;i < user.accounts.Length;i++)
            {
                if (user.accounts[i].accountNumber.ToString() == account)
                {
                    if (user.accounts[i].pwd.ToString() == password)
                    {
                        Choose = i;
                        return true;
                    }
                }
            }
            return false;
        }
        //返回总余额
        public string TotalBalance()
        {
            return user.accounts[Choose].totalBalance.ToString();
        }
        public string AvailableBalance()
        {
            return user.accounts[Choose].availableBlance.ToString();
        }
        //取款函数
        public virtual void Withdraw(string s)
        {
            decimal sl = decimal.Parse(s);
            BigMoneyFetched += new Warning(MoneyWarning);
            if (sl > 10000) BigMoneyFetched();//触发事件
            if(user.accounts[Choose].availableBlance >= sl)//判断指定账户可用余额
            {
                user.accounts[Choose].totalBalance -= sl;//总余额
                user.accounts[Choose].availableBlance -= sl;//可用余额
                FrmShowBalance f2 = new FrmShowBalance();
                f2.Show();
            }
            else
            {
                MessageBox.Show("余额不足!");
                FrmWithdraw frmWithdraw = new FrmWithdraw();
                frmWithdraw.Show();
            }
        }
        //存款函数
        
        public virtual void Deposit(string s)
        {
            Random random = new Random();
            int num = random.Next(1, 4);
            try
            {
                if(num == 1)
                {
                    throw new BadCashException("有坏的钞票");
                }
                decimal sl = decimal.Parse(s);
                user.accounts[Choose].totalBalance += sl;
                MessageBox.Show("存款成功");
                FrmShowBalance f2 = new FrmShowBalance();
                f2.Show();
            }
            catch
            {
                MessageBox.Show("有坏的钞票!请整理后再次放入");
                FrmDeposit frmDeposit = new FrmDeposit();
                frmDeposit.Show();
            }
        }
        //确认转账账户
         public bool PINTran(string aimaccount)
        {
            for (int i = 0; i < transferuser.accounts.Length; i++)
            {
                if (transferuser.accounts[i].accountNumber.ToString() == aimaccount)
                {                                     
                     Transnum = i;
                     return true;                    
                }
            }
            return false;
        }
        //转账函数
        public void TransfrerAccount(string s)
        {
            decimal s2 = decimal.Parse(s);
            user.accounts[Choose].totalBalance -= s2;
            user.accounts[Choose].availableBlance -= s2;
            transferuser.accounts[Transnum].totalBalance += s2;
            MessageBox.Show("转账成功!");

        }
        //委托方法
        public void MoneyWarning()
        {           
            MessageBox.Show("取款数大于10000!","警告");
        }
        //自定义异常
        public class BadCashException : Exception //子类BadCashException继承自父类Exception
        {
            public BadCashException(string message) : base(message)
            {
                //message = "";
            }
        }

    }
   public class Credit:Account//Credit继承于Account类
    {
        public int creditAccountNumber;//信用账户
        public int creditPwd;//信用账户密码
        public int creditAmount;//信用额度
        Credit()
        {
        }
        
    }
    public class Creditstratch: FrmLogin//复写信用账户的Deposit方法
    {
        public override void  Deposit(string s)
        {
            BankDataBase user = new BankDataBase();
            Random random = new Random();
            int num = random.Next(1, 4);
            try
            {
                if (num == 1)
                {
                    throw new BadCashException("有坏的钞票");
                }
                decimal sl = decimal.Parse(s);
                user.accounts[3].totalBalance += sl;//处理信用账户
                MessageBox.Show("存款成功");
                FrmShowBalance f2 = new FrmShowBalance();
                f2.Show();
            }
            catch
            {
                MessageBox.Show("有坏的钞票!请整理后再次放入");
                FrmDeposit frmDeposit = new FrmDeposit();
                frmDeposit.Show();
            }
        }
    }


}
