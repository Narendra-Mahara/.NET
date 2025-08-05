// This code demonstrates how to handle exceptions in C#.
// try and catch blocks are used to catch exceptions that may occur during the execution of code.
//finally block can be used to execute code regardless of whether an exception occurred or not.
try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
    Console.WriteLine("Error: "+e.Message);
}finally
{
  Console.WriteLine("The 'try catch' is finished.");
}