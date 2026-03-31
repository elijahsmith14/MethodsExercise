namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! what is your favorite color?");
            string favcolor = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Favirote band?");
            string favband = Console.ReadLine();

            Console.WriteLine(
                $"one day, {userName} was walking through the woods while wearing a {favcolor} t-shirt. {userName} saw a {favAnimal} listening to {favband}");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numone, int numTwo)
        {
            return numone - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }
            
            return sum;
        }

        static void Main(string[] args)

        {
            //Madlib();
            //Console.WriteLine(Add(2, 2));
            //int addedNums = Add(2, 2);
            //Console.WriteLine(addedNums);
            //Console.WriteLine(Subtract(2, 2));
            //Console.WriteLine(Multiply(2, 2));
            //Console.WriteLine(Divide(2, 2));
            Console.WriteLine(Sum(5, 5, 5));
        }
    }
}