using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class PrinterWindows
    {
        public string NamaPrinter { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Printer display dimension : ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer printing......");
        }
    }
}
