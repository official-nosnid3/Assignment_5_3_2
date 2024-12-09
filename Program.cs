namespace Assignment_5_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 5.3.2
             * 
             * You are climbing a staircase. It takes n steps to reach the top.
             * Each time you can either climb 1 or 2 steps. In how many distinct 
             * ways can you climb to the top?
             */
            
            int stepCount = 7;

            climbStaircase(stepCount);
        }

        static void climbStaircase(int StepCount_)
        {
            // returns the number of distinct ways the staircase can be climbed

            int number1 = 0;
            int number2 = 1;
            int nthSteps = 0; // # of disctinct ways

            if (StepCount_ == 0)
            {
                nthSteps = 0;
            }
            else if (StepCount_ == 1)
                nthSteps = 1;
            else
            {
                for (int i = 0; i < StepCount_; i++)
                {
                    nthSteps = number1 + number2;
                    number1 = number2;
                    number2 = nthSteps;
                }
            }

            Console.WriteLine($"A staircase with {StepCount_} steps can be climbed in {nthSteps} distinct ways.");
        }
    }
}
