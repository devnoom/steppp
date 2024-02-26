using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02
{
    public class Pawn : Places,IMoveable, IKiller
    {
        public string Name { get; set; }
        public int intplace { get; set; }
        public char charplace { get; set; }
        public Tuple<char , int> place { get; set; }
        public Guid Identity { get; set; }
        public Pawn(char ch, int pl, string name)
        {
            Identity = new Guid();
            charplace = ch;
            intplace = pl;
            Name = name;
            //Tuple<char, int> tuple = Tuple.Create(ch, pl);
            //place = tuple;

        }
        public void Kill()
        {
            throw new NotImplementedException();
        }
        public string ToString()
        {
            return Name;
        }
        public void Move()
        {

            if(intplace == 2)
            {
                Console.WriteLine("Choose Place 1 ujrit win an orit ");
                if ("2" == Console.ReadLine())
                {
                    intplace += 2;
                    return;
                }
                else if ("1" == Console.ReadLine())
                {
                    intplace += 1;
                    return;
                }
               
               
            }
            if (intplace < 7)
            {
                Console.WriteLine("shegidzlia gadaxvide ");
                Console.WriteLine($"{charplace} {intplace + 1}");
                return;
            }
            
        }
        //public  void Movable(List<object> list)
        //{
        //    foreach(object item in list)
        //        if(object)
        //}
    }
}
