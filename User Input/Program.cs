namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            //Tutorial
            string name, username, firstName, lastName, loginName, namep3;
            int age, ageTut, grade, studentID, agep3;
            double salary, gradeAverage;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
            Console.WriteLine("Your username is " + username);
            Console.ReadLine();
            Console.WriteLine("Enter your age:");
            ageTut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + ageTut);
            Int32.TryParse(Console.ReadLine(), out ageTut);

            //Assignment
            //Part 1
            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hi {name}! How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So you're {age} eh? That's not old at all! How much do you make {name}?");
            Double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine($"{salary}! I hope that's per hour and not per year!");

            //Part 2
            Console.WriteLine("First name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Grade (9-12):");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student ID:");
            studentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("login:");
            loginName = Console.ReadLine();
            Console.WriteLine("Average:");
            Double.TryParse(Console.ReadLine(), out gradeAverage);

            Console.WriteLine("Your Information:");
            Console.WriteLine("\t\tLogin:\t\t" + loginName);
            Console.WriteLine("\t\tID:\t\t" + studentID);
            Console.WriteLine($"\t\tLogin:\t\t {lastName}, {firstName} ");
            Console.WriteLine("\t\tAverage:\t\t" + gradeAverage);
            Console.WriteLine("\t\tGrade (9-12):\t\t" + grade);

            //Part 3
            Console.WriteLine("Hello. What is your name?");
            namep3 = Console.ReadLine();
            Console.WriteLine($"Hi {namep3}! How old are you?");
            agep3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Did you know that in five years you will be {agep3 + 5} years old? And five years ago you were {agep3 - 5}! Imagine that!");

        }
    }
}
