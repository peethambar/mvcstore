using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DesignCT
{
    /// <summary>
    /// Singleton Pattern Demo
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Show();
            Singleton.Instance.Show();

            Console.ReadKey();
        }
    }
}
