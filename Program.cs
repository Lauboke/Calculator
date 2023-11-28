using System;

class Program
{
//lets see if this will work
static void Main(string[] args)
{
    //set variables:

    int num1;
    int num2;
    int result;
    string operation;

    Console.WriteLine("Calculator");
    Console.ReadLine();

    //get input from users:

    Console.WriteLine("Enter Your First Number : ");
    num1 = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Enter Your Second Number : ");
    num2 = Convert.ToInt32(Console.ReadLine());

    //get operation type

    Console.WriteLine("Which kind of operation do you want ! (+ , - , / , * )");
    operation = Console.ReadLine();

    //conditions on operation:

    if (operation == "+"){
        result = num1 + num2;
        Console.WriteLine(num1 + "+" + num2 + "=" + result);
        Console.ReadLine();
    }

    else if (operation == "-"){
        result = num1 - num2;
        Console.WriteLine(num1 + "-" + num2 + "=" + result);
        Console.ReadLine();
    }

    else if (operation == "/"){
        result = num1 / num2;
        Console.WriteLine(num1 + "/" + num2 + "=" + result);
        Console.ReadLine();
    }

    else if (operation == "*"){
        result = num1 * num2;
        Console.WriteLine(num1 + "*" + num2 + "=" + result);
        Console.ReadLine();
    }

    else {
        Console.WriteLine("Select the correct operation");
        Console.ReadLine();
    }


}
}

