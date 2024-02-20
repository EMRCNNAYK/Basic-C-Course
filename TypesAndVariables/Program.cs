namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            //int   32 bit
            int number1 = 10;
            Console.WriteLine("Number 1 is {0} " ,number1);

            //long  64 bit
            //long takes up twice as much memory as int    !! long>int !!
            long number2 = 2147483648;
            Console.WriteLine("Number 2 is {0} ", number2);

            //short  16 bit  -32768/32767
            short number3 = 32767;            
            Console.WriteLine("Number 3 is {0} ", number3);

            //byte   8 bit   0/255
            byte number4 = 33;
            Console.WriteLine("Number 4 is {0} ", number4);

            //bool  return true/false  use  if/else if/else block
            bool condition = true;

            //char
            char character= 'A';
            Console.WriteLine("Character is {0} ", character);

            //double  64 bit
            double number5 = 35.5;
            Console.WriteLine("Number 5 is {0} ", number5);

            //decimal
            decimal number6 = 35.5m;
            Console.WriteLine("Number 6 is {0} ", number6);

            //var        It is not variable but is used to keep it variable
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number 7 is {0} ", number7);

            //enum writeline
            Console.WriteLine(Days.Friday);

            Console.ReadLine();
        }
    }
    //enum
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}