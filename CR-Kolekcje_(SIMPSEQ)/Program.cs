namespace SIMPSEQ
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static void Print(int[] a, int[] b)
        {
            var A = new SortedSet<int>(a);
            A.ExceptWith(b);
            if(A.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}



