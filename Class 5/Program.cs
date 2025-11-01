using Class_5.ExtentionMethods;

namespace Class_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Fatima34";
            char let = 'a';
            var result=str.GetValueIndexes(let);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
