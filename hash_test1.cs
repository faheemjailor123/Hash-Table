using System;

namespace HashTables_BST_Day15
{
    class Program
    {
        public static void CountingWordFrequency(string sentence)         
        {
            MyMapNode<string, int> hashtable = new MyMapNode<string, int>(10);      
            string[] words = sentence.Split();                
            foreach (string word in words)
            {
                if (hashtable.Exists(word))                    
                {
                    hashtable.Add(word, hashtable.Get(word) + 1);           
                    }
                else
                {
                    hashtable.Add(word, 1);
                }
            }
            Console.WriteLine("Displaying after add operation\n");
            hashtable.Display();
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            CountingWordFrequency("to be or not to be");
         

        }
    }
}
