using Lab_5;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Arraylist students = new Arraylist();

        // Add students
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");
        students.Add("David");
        students.Add("Eve");
        Console.WriteLine("After adding students:");
        students.Display();
        Console.WriteLine();

        // Remove student at index 2 (Charlie)
        students.Remove(2);
        Console.WriteLine("After removing student at index 2:");
        students.Display();
        Console.WriteLine();

        // Remove range (remove 2 students starting from index 1)
        students.RemoveRange(1, 2);
        Console.WriteLine("After removing 2 students starting from index 1:");
        students.Display();
        Console.WriteLine();

        // Clear all students
        students.Clear();
        Console.WriteLine("After clearing all students:");
        students.Display();
    }
}
