namespace XTreeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();

            // Get a list of random numbers.
            for (int i = 0; i < 40; i++)
            {
                list.Add(rnd.Next(1000));
            }

            // Add the list to a tree.
            Tree a = new Tree();

            foreach (var k in list)
            {
                a.Add(k, k + 1);
            }

            a.Print();
        }


    }
}

