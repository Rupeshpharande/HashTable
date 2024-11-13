using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("IND", 91);
            ht.Add("USA", 1);
            ht.Add("AUS", 63);

            ht.Remove("IND");
           

            foreach (DictionaryEntry items in ht)
            {
                Console.WriteLine(items.Key + " "+items.Value);
            }
        }
    }
}
