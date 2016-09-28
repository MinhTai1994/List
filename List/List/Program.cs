using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a =new Element<int>(6);
            Element<int> b = new Element<int>(19);
            Element<int> c = new Element<int>(30);
            List<int> list1 = new List<int>();
            list1.addfirst(a);
            list1.addfirst(b);
            list1.addfirst(c);
            list1.PrintList();
            Element<string> chu1 = new Element<string>("tai");
            Element<string> chu2 = new Element<string>("minh");
            Element<string> chu3 = new Element<string>("trinh");
            List<string> list2 = new List<string>();
            list2.addfirst(chu1);
            list2.addfirst(chu2);
            list2.addfirst(chu3);
            Console.WriteLine(" ");
            list2.PrintList();
            Console.ReadKey();
        }
    }
}
