using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace beginC
{
    class Program
    {
         class C									//创建一个类C
        {
            public int Value = 0;						//声明一个公共int类型的变量Value
        }
        static void Main(string[] args)
        {
            //One
            int intOne = 300;							//声明一个int类型的变量intOne
            byte btOne = 220;                           //声明一个byte类型的变量btOne
            Console.WriteLine("intOne={0}", intOne);		//输出int类型变量intOne
            Console.WriteLine("btOne={0}", btOne);		//输出byte类型变量btOne
            Console.ReadLine();
            //two
            int v1 = 0;								//声明一个int类型的变量v1，并初始化为0
            int v2 = v1;								//声明一个int类型的变量v2，并将v1赋值给v2
            v2 = 927;									//重新将变量v2赋值为927
            C r1 = new C();								//使用new关键字创建引用对象
            C r2 = r1;									//使r1等于r2
            r2.Value = 112;								//设置变量r2的Value值
            Console.WriteLine("Values:{0},{1}", v1, v2);			//输出变量v1和v2
            Console.WriteLine("Refs:{0},{1}", r1.Value, r2.Value);  //输出引用类型对象的Value值
            Console.ReadLine();
             //three:调用for语句循环输出数字
            for(int i = 0;i <= 20; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
            //four:变量和常量
            //数据类型有：sbyte,short,int,long,byte,ushort,uint,ulong,float,double,decimal,char
            int myint = 100;
            const int cint= 1200;
            Console.WriteLine("变量：{0}", myint);
            Console.WriteLine("常量：{0}", cint);
            myint = 200;
            Console.WriteLine("变量再次赋值：{0}", myint);
            Console.ReadLine();
            //five:
            //装箱：将值类型隐式转换为引用类型
            //拆箱：允许将引用类型显示转换为值类型
            int i1 = 300;
            Object obj = i1;
            Console.WriteLine("装箱前：{0},装箱后{1}", i1, obj);
            i1 = 500;
            Object obj1 = i1;
            Console.WriteLine("变量:{0},装箱后:{1}", i1, obj);
            Console.ReadLine();
            int t2 = (int)obj1;
            Console.WriteLine("拆箱前：{0},拆箱后{1}", i1, obj1);
            Console.ReadLine();
            //six:+=意义是先加后赋值
            int i2 = 200;
            i2 += 11;
            Console.WriteLine(i2);
            Console.ReadLine();
            //seven:输入一个年份查是否闰年
            Console.WriteLine("请输入一个年份：");
            string str = Console.ReadLine();
            int year = Int32.Parse(str);
            bool isleapyear = ((year % 400) == 0)||((year%4 == 0)&&(( year % 100) == 0));
            string yearno = isleapyear ? "是" : "不是";
            Console.WriteLine("{0}年{1}闰年",year,yearno);
            Console.ReadLine();
            //eight:判断语句：if,switch(case后接常量)
            const int a = 18;
            const int b = 30;
            const int c = 50;
            int upnum = 0;
            string abc = "请输入你的年龄：";
            Console.WriteLine("请输入你的年龄：");
            upnum = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}", abc, upnum);
            if (upnum <= a)
            {
                Console.WriteLine("你的年龄还小");
            }
            else
            {
                if (upnum > a && upnum <= b)
                {
                    Console.WriteLine("黄金时期");
                }
                else
                {
                    if (upnum > b && upnum <= c)
                    {
                        Console.WriteLine("还可提升");
                    }
                    else
                    {
                        Console.WriteLine("要休息了，最美西阳红");
                    }
                }
            }
            Console.ReadLine();
            //nine:for,while,do...while循环
            int[] nums = new int[6] { 60, 52, 41, 753, 95, 2 };
            //int s = 0;
            //while (s < 6)
            //{
            //    Console.WriteLine("nums{0}的值为：{1}", s, nums[s]);
            //    s++;
            //}
            for (int s = 0; s < 6; s++)
            {
                Console.WriteLine("nums{0}的值为：{1}", s, nums[s]);
            }
            Console.ReadLine();
            //ten:集合：ArrayList
            ArrayList mylist = new ArrayList();
            mylist.Add("宝龙公司");
            mylist.Add("C#");
            mylist.Add("ASP");
            mylist.Add(".NET");
            mylist.Add("JAVA");
            Console.WriteLine("课程列表：");
            foreach (string listn in mylist)
            {
                Console.WriteLine("{0}", listn);
            }
            Console.ReadLine();
            //eleven:简单判断用户是否登录成功
            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();    //定义一个string变量，用来存储用户名
            Console.WriteLine("请输入密码：");
            string pass = Console.ReadLine();    //定义一个string变量，用来存储用户密码
            bool boolT = (name == "abc" && pass == "123");
            string login = boolT ? "登录成功" : "登录不成功";
            Console.WriteLine(login);           //输出登录信息
            Console.ReadLine();
            //twelve:123456的加密和解密
            Console.Write("*****加密*****\n\n下面对密码：123456进行加密\n\n");
            Console.Write("请输入加密的密钥：");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n密钥为：");
            int bykey = 123456 ^ key;
            Console.Write(bykey + "\n\n");
            Console.Write("\n\n\n\n****************解密*****************\n\n请输入密钥 进行解密：   ");
            int key1 = Convert.ToInt32(Console.ReadLine());
            int bykey1 = bykey ^ key1;
            if (123456 == bykey1)
            {
                Console.Write("\n密码{0}\n解密成功\n\n\n", key1);
            }
            else
            {
                Console.Write("\n解密失败！！！！   \n\n\n");
            }
            Console.ReadLine();
            //thirteen:简单计算器
            System.Console.Title = "制作简单计算器";						//设置控制台标题
            System.Console.Write("输入第1个数字：");					//提示用户输入第一个数值
            double d = double.Parse(System.Console.ReadLine());			//得到第一个数值
            System.Console.Write("输入第2个数字：");					//提示用户输入第二个数值
            double d2 = double.Parse(System.Console.ReadLine());			//得到第二个数值
            System.Console.Write("输入第3个数字：");					//提示用户输入第三个数值
            double d3 = double.Parse(System.Console.ReadLine());			//得到第三个数值
            System.Console.Clear();								//清空控制台内所有字符
            System.Console.WriteLine("最后计算的结果：{0} + {1} + {2} = {3}", d, d2, d3, d + d2 + d3);	//输出计算结果
            System.Console.ReadLine();
        }
    }
}
