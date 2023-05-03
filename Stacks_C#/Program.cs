namespace Stacks_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stacks are generic collections
            Stack<int> myStack = new Stack<int> ();
            // Inserting a object at the top of the stack, using Push();
            myStack.Push (1);
            myStack.Push (2);
            myStack.Push (3);
            myStack.Push (4);
            // Peek the element of the top without removing it 
            Console.WriteLine($"Top value in the stack is: {myStack.Peek()}");
            // Pop, to remove an item from the top of the stack
            int myStackItem = myStack.Pop();
            Console.WriteLine($"Popped Item: {myStackItem}");
            Console.WriteLine($"Top value in the stack is: {myStack.Peek()}");
            // If Pop(); is used when there are no items in the stack, it will trigger an error.

            //Creating a loop that removes every item from the stack

            //Creating the stack
            Stack<int> anotherStack = new Stack<int> ();

            //Adding values to it
            anotherStack.Push(1);
            anotherStack.Push(2);
            anotherStack.Push(3);
            anotherStack.Push(4);
            anotherStack.Push(5);

            Console.WriteLine("Starts here");

            //Creating the loop to remove items
            while(anotherStack.Count > 0)
            {
                Console.WriteLine($"Top value in the stack is: {anotherStack.Peek()}");
                anotherStack.Pop();
                Console.WriteLine($"The items in the stack are in a total of: {anotherStack.Count}");
            }

            //Reverse a integer array
            int[] ints = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> intStack = new Stack<int>();
            foreach(int item in ints)
            {
                intStack.Push(item);
            }
            foreach(int stuff in intStack)
            {
                Console.WriteLine(stuff);
            }

            

        }
    }
}