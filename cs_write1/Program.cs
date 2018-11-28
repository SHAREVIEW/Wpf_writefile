using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace cs_write1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream afile = new FileStream("log.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(afile);
                bool truth = true;
                sw.Write("HEY,4554545");
                sw.Write($"It is now {DateTime.Now.ToLongDateString()}" );
                sw.Write($"it is {truth}");
                sw.Write(" 45646444444444444");
                sw.Close();

            }
            catch(IOException e)
            {
                WriteLine("error");
                WriteLine(e.ToString());
                ReadLine();
                return;

            }
            
        }

     
        private static void ReadLine()
        {
            throw new NotImplementedException();
        }

        private static void WriteLine(string v)
        {
            throw new NotImplementedException();
        }
    }
}
