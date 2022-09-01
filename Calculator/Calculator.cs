namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
     



        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
      



        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
      



        public double Power(double x, double exponent)
        {
            Accumulator = Math.Pow(x, exponent);
            return Accumulator;
        }
      



        public double Divide(double a_dividend, double b_divisor)
        {
            if(b_divisor == 0)
            {
                Console.WriteLine("division by zero error.");
                return 0;
            }
            else
            {
                Accumulator = (a_dividend / b_divisor);
                return Accumulator;
            }
        }
        public double Divide(double divisor)
        {
            if (Accumulator == 0)
            {
                Console.WriteLine("division by zero error.");
                return 0;
            }
            else
            {
                Accumulator = (Accumulator / divisor);
                return Accumulator;
            }
        }


        public void Clear()
        {
            Accumulator = 0;
        }


    }
}