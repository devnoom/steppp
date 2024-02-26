using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02
{
    public class Knight: IMoveable, IKiller
    {
        public int intplace { get; set; }
        public char charplace { get; set; }
        public Guid Identity { get; set; }
        public Knight(char ch, int pl)
        {
            Identity = new Guid();
            charplace = ch;
            intplace = pl;
        }
        public void Kill()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {

            if (intplace == 2)
            {

            }

        }
    }
}
