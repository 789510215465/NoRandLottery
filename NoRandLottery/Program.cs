using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoRandLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> word = new List<string>();
            word.Add("A");
            word.Add("B");
            word.Add("C");
            word.Add("D");
            word.Add("E");

            Console.WriteLine( word[0] + word[1] + word[2] + word[3] + word[4]);

            string tmp = word[1] ;
            word[1] = word[4] ;
            word[4] = tmp;

            Console.WriteLine(word[0] + word[1] + word[2] + word[3] + word[4]);

            Console.ReadKey();
        }
        
    }
}
