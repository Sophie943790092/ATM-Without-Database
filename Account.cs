using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM自助存取款终端
{
    public class Account//储存单个用户的账户信息
    {
        public int accountNumber;//卡号
        public int pwd;//密码
        public decimal availableBlance;//可用余额
        public decimal totalBalance;//总余额
        public Account(int theAccountNumber, int thePwd, decimal theAvailableBalance, decimal theTotalBalance)//Account类的带参构造函数
        {
            accountNumber = theAccountNumber;//传参 
            pwd = thePwd;
            availableBlance = theAvailableBalance;
            totalBalance = theTotalBalance;
        }
        public Account()
        {

        }
       
    }
    
}
