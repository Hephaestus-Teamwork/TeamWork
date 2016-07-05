using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork.Structure
{
    public struct StructureForPlayer
    {
        private string body;
        private int x;

        public StructureForPlayer(string body, int x)
            : this()
        {
            this.Body = body;
            this.X = x;
        }
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
    }
}
