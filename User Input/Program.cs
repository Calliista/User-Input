using System.Diagnostics.CodeAnalysis;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            //Tutorial
            string name, username, firstName, lastName, loginName, namep3, item, item2;
            int age, ageTut, grade, studentID, agep3;
            double salary, gradeAverage, prompt1, prompt2, prompt3, price, price2, discountedPrice, total, totalPrice, tax, discount;

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

            //Part 4
            Console.WriteLine("prompt1:");
            prompt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prompt2:");
            prompt2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prompt3:");
            prompt3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((prompt1 + prompt2 + prompt3) / 2);

            //Part 5

            Console.WriteLine("item name:");
            item = Console.ReadLine();
            Console.WriteLine("item price:");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("2nd item name:");
            item2 = Console.ReadLine();
            Console.WriteLine("2nd item price");
            Double.TryParse(Console.ReadLine(), out price2);
            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            total = price + price2;
            discount = total * 0.2;
            discountedPrice = total - discount;
            tax = total * 0.13;
            totalPrice = discountedPrice + tax;
            Console.WriteLine("Total price: " + totalPrice.ToString("C" ));
            Console.WriteLine("Discount (20%) " + discount.ToString("C "));
            Console.WriteLine("Subtotal: " +  discountedPrice.ToString("C" ));
            Console.WriteLine("Tax (13%)" + tax.ToString("C" ));
            Console.WriteLine("total Owed: " + totalPrice);


            //Int32.TryParse(Console.Readline(), out ___)
        }
    }
}
