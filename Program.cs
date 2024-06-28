using System;

public class Calculator
{
	
    /*
     * adds two numbers together
     * @param x - decimal - value to add to
     * @param y - decimal - value to add
     * returns decimal = x + y
     */
    public decimal add(decimal x, decimal y)
    {
        return x + y;
    }

    /*
     * subtsracts value y from x
     * @param x - decimal - value to subtract from
     * @param y - decimal - value to subtract
     * returns decimal = x - y
     */
    public decimal subtract(decimal x, decimal y){
    	return x - y;
    }

    /*
     * divides value x by value y
     * @param x - decimal - numerator
     * @param y - decimal - denominator
     * returns decimal = x / y
     */
    public decimal divide(decimal x, decimal y){
    	return x / y;
    }

    /*
     * multiplys value x by value y
     * @param x - double - value to multiply
     * @param y - multipler - value to multiply by
     * returns double = x*y
     */
    public decimal multiply(decimal x, decimal y){
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
    public static void printCalculatorOutput(decimal output)
    {
        Console.WriteLine(output); // output to console
    }
}

