using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS___Async_Await
{
    internal class Encapsulation
    {
        public void Main()
        {
            Info info = new Info();
            info.StudentName = "Suyog Vasage";
            Console.WriteLine(info.StudentName);
        }
    }

    public class Info
    {
        private String name;

        public String StudentName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
