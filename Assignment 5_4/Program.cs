using System;

public class CustomException : Exception
{
    public CustomException() : base("This is a custom exception.")
    {
       
    }
}

class Program
{
    static void Main()
    {
        try
        {
            
            int someCondition = 42;

            if (someCondition == 42)
            {
                
                throw new CustomException();
            }

           

            Console.WriteLine("No exception occurred.");

        }
        catch (CustomException ex)
        {
            
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Exception: {ex.Message}");
        }
        finally
        {
            
            Console.WriteLine("Finally block executed.");
        }
    }
}
