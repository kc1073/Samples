using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    class Program
    {


        static void Main(string[] args)
        {
            var eg = new Example();
            eg.MyProperty = 42;
            eg.RegisterClickHandler();
            eg.InvokeClickHandler("Hello world");
        }
    }

    public class Example
    {

        public int MyProperty { get; set; }

        delegate void ClickHandler(String arg, EventArgs e);
        event ClickHandler click;

        public void RegisterClickHandler()
        {
            click += new ClickHandler(MyHandler);
        }

        public void InvokeClickHandler(string arg)
        {
            click(arg, new EventArgs());
        }

        private void MyHandler(string arg, EventArgs e)
        {
            int prop = MyProperty;
            Console.WriteLine("In MyHandler with arg: {0} and {1}", arg, prop);
        }




    }
}
