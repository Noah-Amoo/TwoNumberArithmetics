//                      DOING CALCULATIONS
//  The code uses both a method and a class to generate the same result. This helps to visualize
//  how the same code base could be set up as either a function/method which can be called in the
//  Main method to perform the arithmetics, or as a class whose object can be created in the Main
//  to achieve the same results.
Console.Write("Enter your first number:\t");
double num1 = int.Parse(Console.ReadLine());

Console.Write("Enter your second number:\t");
double num2 = int.Parse(Console.ReadLine());

Console.Write($"Enter +, -, / or x to perform the arithmetic calculation:\t ");
string arithOperator = Console.ReadLine();

var dc = new DoingCalculations(num1, num2, arithOperator);

Console.WriteLine(dc.GetResult());

//              METHOD TO PERFOM THE ARITHMETICS
static double PerformArithmetic(double num1, double num2)
{
    double result = 0;
    //  To perform the various switch cases, you must copy read the arithOperator variable here.
    //  In other words, cut and paste line 13 here.
    switch (arithOperator)
    {
        case "+":
            result = num1 + num2;
            break;

        case "-":
            result = num1 - num2;
            break;

        case "x":
            result = num1 * num2;
            break;

        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Number cannot be divided by 0");
            }
            result = num1 / num2;
            break;

    }

    return result;
}


//              CLASS TO PERFORM THE ARITHMETICS
//  The DoingCalculations class calls the GetResults method to output the final results of the arithmetic.
//  The Constructor, which bears the same name as the class, helps to set the values to the field members.
class DoingCalculations
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    public string Operation { get; set; }

    public DoingCalculations(double fnum, double snum, string operation)
    {
        FirstNumber = fnum;
        SecondNumber = snum;
        Operation = operation;
    }

    public double GetResult()
    {
        double result = 0;
        switch (Operation)
        {
            case "+":
                result = FirstNumber + SecondNumber;
                break;

            case "-":
                result = SecondNumber - FirstNumber;
                break;

            case "*":
                result = FirstNumber * SecondNumber;
                break;

            case "/":
                result = SecondNumber / FirstNumber;
                break;

            default:
                break;
        }

        return result;
    }
}

