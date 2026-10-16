namespace TombokSzamokkal
{
    internal class Program
    {
        static Random r = new Random();
        static int[] tomb = new int[15];
        static void Feltolt()
        {
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);

            }
            foreach(int item in tomb)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
            
        }


        static void Main(string[] args)
        {
            Feltolt();
        }
    }
}
