using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class HROfficer
    {
        private string filter;
        private int element;

        public HROfficer(string filter, int element)
        {
            this.filter = filter;
            this.element = element;
        }

        public string Filter { get => filter; set => filter = value; }
        public int Element { get => element; set => element = value; }
    }
}
