namespace Practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("airchiet peri");
         //   string choosen = Console.ReadLine();
            List<object> list = new List<object>();
            //if(choosen == "tetri")
            //{

                Pawn pawn1 = new Pawn('a',2,"pawn1");
                Pawn pawn2 = new Pawn('b', 2, "pawn2");
                King king = new King('e', 1);
                Knight knight1 = new Knight('b', 1);
                Knight knight2 = new Knight('g', 1);
                Rook rook1 = new Rook('a', 1);
                Rook rook2 = new Rook('a', 1);
                list.Add(king);
                list.Add(king);
                list.Add(king);
                list.Add(king);
                list.Add(king);
                 Console.WriteLine("airchie pigura ritic ginda tamashi");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
          //  Console.WriteLine(pawn1.intplace);
        }
    }
}