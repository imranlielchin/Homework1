namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //string reqem = Console.ReadLine(); 
            //int firstNumber = int.Parse(reqem);
            //string ikinciReqem = Console.ReadLine();
            //int secondNumber = int.Parse(ikinciReqem);
            //Console.WriteLine(firstNumber + secondNumber);
            

            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);
            Console.WriteLine(firstNumber % secondNumber);
        }
    }
}
