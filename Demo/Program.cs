using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            #region Part 01 Conditional Statments - If, Switch [Numeric Datatypes]

            ////Example 1

            //Console.WriteLine("please Enter an Month Numbers Existed in 1st Quarter");
            //int.TryParse(Console.ReadLine(), out int MonthNumbers);

            //if (MonthNumbers == 1)
            //{
            //    Console.WriteLine("Hello january");
            //}
            //else if (MonthNumbers == 2)
            //{
            //    Console.WriteLine("Hello febraury");
            //}
            //else if (MonthNumbers == 3)
            //{
            //    Console.WriteLine("Hello march");
            //}
            //else
            //{
            //    Console.WriteLine("The Entered Month Number Is Not Existed in 1st Quarter");
            //}

            ////Example 2

            //Console.WriteLine("please Enter an Month Numbers Existed in 1st Quarter");
            //int.TryParse(Console.ReadLine(), out int MonthNumbers);
            //switch (MonthNumbers)
            //{
            //    case 1:
            //        Console.WriteLine("Hello january");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello febraury");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello march");
            //        break;
            //    default:
            //        Console.WriteLine("The Entered Month Number Is Not Existed in 1st Quarter");
            //        break;

            #endregion

            #region Part 02 Switch [Numeric Datatypes (Comparsion Operators)]

            ////Example 1

            //Console.WriteLine("please Enter your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //if (Age > 22)
            //{
            //    Console.WriteLine("your Age is Greater than 22");
            //}
            //else if (Age < 22)
            //{
            //    Console.WriteLine("your Age is less than 22");
            //}
            //else
            //{
            //    Console.WriteLine("your Age equals 22");
            //}

            ////Example 2

            //Console.WriteLine("please Enter your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //switch (Age)
            //{
            //    case > 22:
            //        Console.WriteLine("your Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("your Age is less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("your Age equals 22");
            //        break;
            //}

            #endregion

            #region Part 03 Conditional Statments - If, Switch [String Datatype]

            ////Example 1

            //Console.WriteLine("please Enter your Name : ");
            //string Name = Console.ReadLine() ?? "No Name";

            //if (Name == "Nada")
            //{
            //    Console.WriteLine("Hello Nada");
            //}
            //else if (Name == "Nour")
            //{
            //    Console.WriteLine("Hello Nour");
            //}
            //else if (Name == "Alia")
            //{
            //    Console.WriteLine("Helli Alia");
            //}
            //else if (Name == "Selem")
            //{
            //    Console.WriteLine("Hello Selem");
            //}
            //else if (Name == "Ali")
            //{
            //    Console.WriteLine("Hello Ali");
            //}

            ////Example 2

            //Console.WriteLine("please Enter your Name : ");
            //string Name = Console.ReadLine() ?? "No Name";
            //switch (Name)
            //{
            //    case "Nada":
            //        Console.WriteLine("Hello Nada");
            //        break;
            //    case "Nour":
            //        Console.WriteLine("Hello Nour");
            //        break;
            //    case "Alia":
            //        Console.WriteLine("Hello Alia");
            //        break;
            //    case "Selem":
            //        Console.WriteLine("Hello Selem");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("Hello Ali");
            //        break;
            //}

            #endregion

            #region Part 05 Evolution of Switch in C# 7.0

            ////Example 1

            //Object input = new object();
            //input = 5.5;
            //input = new person() { Id = 100, Name = "ahmed" };
            //switch (input)
            //{
            //    case int localinput:
            //        Console.WriteLine("integer input");
            //        break;
            //    case double localinput:
            //        Console.WriteLine("double input");
            //        break;
            //    case person person when person.Id == 100:
            //        Console.WriteLine(person.Name);
            //        break;
            //    default:
            //        Console.WriteLine("unkhown input");
            //        break;

            #endregion

            #region Part 05 Switch with goto

            ////Example 1

            //Console.WriteLine("Please Enter your Budget: ");
            //int Budget = int.Parse(Console.ReadLine());
            //switch (Budget)
            //{
            //    case 3000:
            //        Console.WriteLine("option 3");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 2");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 1");
            //        break;
            //}

            #endregion

            #region Part 06 Evolution of Switch in C# 7.0 (Continued)

            //Console.WriteLine("please Enter your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //switch (Age)
            //{
            //    case int when Age > 22 && Age < 30:  // In C# 7, more than one condition was used using when.
            //        Console.WriteLine("your Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("your Age is less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("your Age equals 22");
            //        break;
            //}

            #endregion

            #region Part 07 Evolution of Switch in C# 8.0

            //Example 1
            //switch expression

            //Console.WriteLine("please enter an option : ");
            //string option = Console.ReadLine() ?? "0";
            //string Message = string.Empty;
            //Message = option switch
            //{
            //    "1" => " Using Option 1 ",
            //    "2" => " Using Option 2 ",
            //    "3" => " Using Option 3 ",
            //    _ => " unsupported option ",
            //};
            //Console.WriteLine(Message);

            ////Example 2

            //person person = new person() { Id = 10, Name = "nada", Age = 23 };
            //switch (person)
            //{
            //    case { Id: 10, Name: "nada", Age: 23 }:
            //        Console.WriteLine("Hello nada , your age is 23");
            //        break;
            //    default:
            //        Console.WriteLine("unknown person");
            //        break;
            //}

            #endregion

            #region Part 08 Evolution of Switch in C# 9.0

            //Console.WriteLine("please enter the name , age , Id : ");
            //string name = Console.ReadLine() ?? "no name";
            //int age = int.Parse(Console.ReadLine()) ;
            //int Id = int.Parse(Console.ReadLine());
            //person person = new person() { Id = 10, Name = "nada", Age = 23 };
            //string Message = "";
            //Message = person switch
            //{
            //    { Id: 10, Name: "nada", Age: 23 } => "Hello nada , your age is 23",
            //    _ => "unknown person"
            //};
            //Console.WriteLine(Message);

            #endregion

            #region Part 09 Loop Statements

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Part 10 Loop Statements - For, Foreach

            //Example 1 

            //int[] Num = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < Num.Length; i++)
            //{
            //    if (Num[i] == 5)
            //        break;
            //    Console.WriteLine(Num[i]);
            //}

            //Example 2

            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //foreach (int numbers in Numbers)
            //{
            //    Console.WriteLine(numbers);
            //}

            #endregion

            #region Part 11 Loop Statements - Do While, While

            //Example 1

            //int Number;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Please enter an even number");
            //} while (!int.TryParse(Console.ReadLine(), out Number) || Number % 2 == 1);

            //Examble 2

            //int x = 1;
            //while (x <= 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            #endregion

            #region Part 12 String

            //Example 1

            //string Name;
            //Name = new string("Nada");
            //Name = "Nada"; // syntax suger
            //Console.WriteLine(Name);
            //Console.WriteLine($"Hashcode ={Name.GetHashCode()}");
            //string Name2 = "Ahmed";
            //Console.WriteLine(Name2);
            //Console.WriteLine($"Hashcode ={Name2.GetHashCode()}");

            //Example 2

            //string Name1 = "Nada";
            //string Name2 = "Nour";
            //Console.WriteLine($"Name1 ={Name1}");
            //Console.WriteLine($"Hashcode ={Name1.GetHashCode()}");
            //Console.WriteLine($"Name2 ={Name2}");
            //Console.WriteLine($"Hashcode ={Name2.GetHashCode()}");
            //Console.WriteLine("------------------------------------");
            //Name2 = Name1;
            //Console.WriteLine($"Name1 ={Name1}");
            //Console.WriteLine($"Hashcode ={Name1.GetHashCode()}");
            //Console.WriteLine($"Name2 ={Name2}");
            //Console.WriteLine($"Hashcode ={Name2.GetHashCode()}");

            //Example 3

            //string Name1 = "Nada";
            //string Name2 = "Nour";
            //Name2 = Name1;
            //Name1 = "Alia";
            //Console.WriteLine(Name2); //print Nada becauce string is an Immutable type can't be changed 

            #endregion

            #region Part 13 StringBuilder

            //Example 1

            //Stringbuilder is a Class {Reference Type}
            //stringbuilder is mutable string

            //StringBuilder Message;
            //Message = new StringBuilder("Hello");
            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"Hashcode of Message: {Message.GetHashCode()}");

            //Console.WriteLine("----------------------------------------------------");

            //Message.Append(" Nada");
            //Console.WriteLine($"Message : {Message}");
            //Console.WriteLine($"Hashcode of Message: {Message.GetHashCode()}");

            //Example 2 : StringBuilder Methods

            //StringBuilder Message;
            //Message = new StringBuilder("Hello");
            //Message.Append("  Nada");
            //Message.AppendLine(" Mosalam");
            //Message.AppendLine("My Age is 23");
            //Message.Remove(0, 6);
            //Message.Insert(0, "Hi");
            //Message.Clear();
            //Message.AppendFormat("{0}, {1}", true, "a");
            //Message.AppendJoin(";", "NADA", "MOSALAM");
            //Console.WriteLine($"Message : {Message}");

            #endregion
        }
    }
}
