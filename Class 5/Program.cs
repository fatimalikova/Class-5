using Class_5.ExtentionMethods;
using Class_5.Task_3;

namespace Class_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "Fatima34";
            //char let = 'a';
            //var result = str.GetValueIndexes(let);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //string sentence = "Salam Fatima Malikova. Necəsən? Bu testdir.";
            //Console.WriteLine(sentence.GetFirstSentence());

            //string text = "Salam Fatima!";
            //Console.WriteLine(text.GetSecondWord());

            //string sentence1 = "Salam Kamran Necəsən Kamran";
            //Console.WriteLine(sentence1.Match_Count("Kamran"));

            //int number = 3483;
            //Console.WriteLine(number.Polindrome());

            StudentClass st1 = new StudentClass { Fullname = "Abbas Quliyev", GroupNo = "P216", Age = 18 };
            StudentClass st2 = new StudentClass { Fullname = "Leyla Huseynova", GroupNo = "Y401", Age = 20 };

            st1.DoHomeWork();
            st2.DoHomeWork();
        }
    }
}
