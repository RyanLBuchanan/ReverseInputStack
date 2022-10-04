/* C# program to reverse
String using Stack */
using System.Text;
// stack

namespace ReverseInputStack;

class Stack
{
    public int size;
    public int top;
    public char[] a;

    // function to check if stack is empty
    public Boolean isEmpty() { return (top < 0); }

    public Stack(int n)
    {
        top = -1;
        size = n;
        a = new char[size];
    }

    // function to push element in Stack
    public Boolean push(char x)
    {
        if (top >= size)
        {
            Console.WriteLine("Stack Overflow");
            return false;
        }
        else
        {
            a[++top] = x;
            return true;
        }
    }

    // function to pop element from stack
    public char pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return ' ';
        }
        else
        {
            char x = a[top--];
            return x;
        }
    }
}

class GFG
{
    // function to reverse the string
    public static void Reverse(StringBuilder stringBuilder)
    {
        // Create a stack of capacity
        // equal to length of string
        int n = stringBuilder.Length;
        Stack obj = new Stack(n);

        // Push all characters of string
        // to stack
        int i;
        for (i = 0; i < n; i++)
            obj.push(stringBuilder[i]);

        // Pop all characters of string
        // and put them back to str
        for (i = 0; i < n; i++)
        {
            char ch = obj.pop();
            stringBuilder[i] = ch;
        }
    }

    // Driver code
    public static void Main(String[] args)
    {
        string input = "";

        while (input != "-1")
        {
            Console.WriteLine("Please enter text to be reversed (enter -1 to quit): ");
            input = Console.ReadLine();

            if (input == "-1")
            {
                return;
            }

            // Create a new string
            StringBuilder stringBuilder = new StringBuilder(input);

            // Call Reverse method on string input
            Reverse(stringBuilder);

            // Display reversed string
            Console.WriteLine($"{input} reversed is {stringBuilder}.\n");
        }
    }
}

// This code is contributed by Rajput-Ji




//using System.Text;

//namespace ReverseInputStack
//{
//    internal class ReverseInputTest
//    {
//        public int size;
//        public int top;
//        public char[] chars;

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter text to be reversed: ");
//            string input = Console.ReadLine();


//            // Create a new string
//            StringBuilder stringBuilder = new StringBuilder(input);

//            // Call Reverse method on string input
//            Reverse(stringBuilder);

//            // Display reversed string
//            Console.WriteLine($"{input} reversed is {stringBuilder}");
//        }

//        public static void Reverse(StringBuilder stringBuilder)
//        {
//            // Create a stack of capacity equal to length of string
//            int n = stringBuilder.Length;
//            Stack obj = new Stack(n);

//            // Push all characters of string to stack
//            int i; 
//            for (i = 0; i < n; i++)
//            {
//                obj.Push(stringBuilder[i]);
//            }

//            // Pop all characters of string and put them back on stringBuilder
//            for (i = 0; i < n; i++)
//            {
//                char ch = obj.Pop();
//                stringBuilder[i] = ch;
//            }
//        }

//        // Method to check if stack is empty
//        public Boolean IsEmpty()
//        {
//            return (top < 0);
//        }

//        public void Stack(int n)
//        {
//            top = -1;
//            size = n;
//            chars = new char[size];
//        }

//        // Push method
//        public Boolean Push(char x)
//        {
//            if (top >= size)
//            {
//                Console.WriteLine("Stack Overflow");
//                return false;
//            }
//            else
//            {
//                chars[++top] = x;
//                return true;
//            }
//        }

//        // Method to pop element from stack
//        public char Pop()
//        {
//            if (top < 0)
//            {
//                Console.WriteLine("Stack Underflow");
//                return ' ';
//            }
//            else
//            {
//                char x = chars[top--];
//                return x;
//            }
//        }
//    }
//}
