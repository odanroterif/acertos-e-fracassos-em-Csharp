using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança
{
    public class status
    {
        private bool carstatus;

        public bool on()
        {
            carstatus = true;

            return carstatus;
        }
        public bool off()
        {
            carstatus = false;

            return carstatus;
        }
    }
    public class car : status
    {
        public void rotation()
        {

        }    
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            car CAR = new car();

            Console.WriteLine(CAR.off());
            Console.ReadLine();
        }
    }
}
