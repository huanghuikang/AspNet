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

        }
    }
}
