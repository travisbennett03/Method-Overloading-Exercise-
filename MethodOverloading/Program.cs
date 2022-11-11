namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal decimal1, decimal decimal2)
        {
            return decimal1 + decimal2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            string response = "";

            if(isTrue)
            {
                sum = num1 + num2;

                if(sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;    
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));

            Console.WriteLine();

            Console.WriteLine(Add(5, 7, true));

            Console.WriteLine();

            Console.WriteLine(Add(-6, 3, true));
        }
    }
}
