namespace Collection_Assignment4_Stack
{
    internal class Program
    {
        static void Main()
        {
            // Stack for Undo
            Stack<string> undoStack = new Stack<string>();

            // Stack for Redo (Bonus)
            Stack<string> redoStack = new Stack<string>();

            // Push actions
            undoStack.Push("Type A");
            undoStack.Push("Type B");
            undoStack.Push("Delete B");
            undoStack.Push("Type C");
            undoStack.Push("Bold Text");

            Console.WriteLine("All Actions:");
            foreach (var action in undoStack)
            {
                Console.WriteLine(action);
            }

            // Undo last 3 actions
            Console.WriteLine("\nUndoing last 3 actions...");
            for (int i = 0; i < 3; i++)
            {
                if (undoStack.Count > 0)
                {
                    string undoneAction = undoStack.Pop();
                    redoStack.Push(undoneAction); // store for redo
                    Console.WriteLine($"Undone: {undoneAction}");
                }
            }

            // Display current top action
            Console.WriteLine("\nCurrent Top Action:");
            if (undoStack.Count > 0)
            {
                Console.WriteLine(undoStack.Peek());
            }

            // BONUS: Redo last undone action
            Console.WriteLine("\nRedoing last action...");
            if (redoStack.Count > 0)
            {
                string redoAction = redoStack.Pop();
                undoStack.Push(redoAction);
                Console.WriteLine($"Redone: {redoAction}");
            }

            // Final State
            Console.WriteLine("\nFinal Undo Stack:");
            foreach (var action in undoStack)
            {
                Console.WriteLine(action);
            }
        }
    }
}
