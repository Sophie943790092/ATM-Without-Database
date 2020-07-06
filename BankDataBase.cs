using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM自助存取款终端
{
    class BankDataBase//作为一个银行的总数据库,储存多名用户的账户信息
    {
        public Account[] accounts;//Account类型的数组 
        public BankDataBase()//构造函数
        {
            accounts = new Account[3];//卡号, 密码, 可用余额, 总余额
            accounts[0] = new Account(12345, 654321, 20000.00M, 22000.00M);//创建三个Account类的对象,保存在accounts数组中(相当于有三个客户的信息储存在数据库中)
            accounts[1] = new Account(56789, 987654, 20000.00M, 50000.00M);
            accounts[2] = new Account(943790092, 123456, 10000.00M, 10000.00M);//信用账户:卡号,密码,信用额度,信用额度
        }
       
        
    }
}
