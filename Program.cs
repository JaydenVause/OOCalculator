using System;

public class Calculator
{
	
    /*
     * adds two numbers together
     * @param x - double - value to add to
     * @param y - double - value to add
     * returns double = x + y
     */
    public double add(double x, double y)
    {
        return x + y;
    }

    /*
     * subtsracts value y from x
     * @param x - double - value to subtract from
     * @param y - double - value to subtract
     * returns double = x - y
     */
    public double subtract(double x, double y){
    	return x - y;
    }

    /*
     * divides value x by value y
     * @param x - double - numerator
     * @param y - double - denominator
     * returns double = x / y
     */
    public double divide(double x, double y){
    	return x / y;
    }

    /*
     * multiplys value x by value y
     * @param x - double - value to multiply
     * @param y - multipler - value to multiply by
     * returns double = x*y
     */
    public double multiply(double x, double y){
    	return x * y;
    }
}

public class Program
{
    public static void Main()
    {
        Calculator myCalculator = new Calculator();

	printCalculatorOutput(myCalculator.add(2, 4)); // add
	printCalculatorOutput(myCalculator.subtract(4, 2)); // subtract
	printCalculatorOutput(myCalculator.divide(5, 2)); // divide
	printCalculatorOutput(myCalculator.multiply(10, 2)); // multiply

    }


    // Method for printing calculator output
    public static void printCalculatorOutput(double output)
    {
        Console.WriteLine(output); // output to console
    }
}

