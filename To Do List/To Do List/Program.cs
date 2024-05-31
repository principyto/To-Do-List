using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the NOT PERSISTENT To Do List");
        List<string> tasks = new List<string>();
        string option = "";

        while (option != "e")
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("Enter 1 to add a task to the list");
            Console.WriteLine("Enter 2 to remove  a task from the list");
            Console.WriteLine("Enter 3 to view the list");
            Console.WriteLine("enter e to exist the program");
            option = Console.ReadLine();

            if(option == "1") 
            {
                Console.WriteLine("Please enter the task");
                tasks.Add(Console.ReadLine());
            }
            else if(option == "2")
            {
                Console.WriteLine("Which element would you like to remove?");
                for(int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine(i + " : " + tasks[i]);
                }
                int remove = Convert.ToInt32(Console.ReadLine());
                tasks.RemoveAt(remove);
            }
            else if (option == "3")
            {
                Console.WriteLine("Which element would you like to remove?");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine(i + " : " + tasks[i]);
                }
            }
        }
    }
}


