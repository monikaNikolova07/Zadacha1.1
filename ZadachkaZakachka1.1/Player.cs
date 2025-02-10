using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachkaZakachka1._1
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("value");
                }
                this.name = value;
            }
        }

        private string position;

        public string Position
        {
            get { return position; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("value");
                }
                this.position = value;
            }
        }


        public Player(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}
}
