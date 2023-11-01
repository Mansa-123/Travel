using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMsystem
{
    public class AddEmp
    {
        public static void Add(string name1, string name2, DateTime dob, string add, int phone)
        {
            Console.WriteLine("{0,15}", "Add Employee");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("1.Enter First Name:\n");
            name1 = Console.ReadLine();
            Console.WriteLine("1.Enter Last Name:\n");
            name2 = Console.ReadLine();
            Console.WriteLine("2.Enter Date of Birth:\n");
            dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("3.Address:\n");
            add = Console.ReadLine();
            Console.WriteLine("4.Contact:\n");
            phone = int.Parse(Console.ReadLine());


            Console.WriteLine("Congrats {0} your added successfully!!!", name1);
            Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", "First Name", "Last Name", "DOB", "Address", "Contact");
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", name1, name2, dob, add, phone);


        }


    }
}
//static void Main(string[] args)
//{
//    int choice, choice1, choice2;
//    string name2;

//    Console.WriteLine("{0,15}", "Main Menu");
//    Console.WriteLine("-------------------------\n");
//    Console.WriteLine("1.Manage Employees\n");
//    Console.WriteLine("2.Manage Travel Request\n");
//    Console.WriteLine("3.Exit\n");

//    Console.WriteLine("Enter Number of your choice: ");
//    choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine("{0,15}", "Manage Employees");
//            Console.WriteLine("-------------------------\n");
//            Console.WriteLine("1.Add Employee\n");
//            Console.WriteLine("2.Edit Employee\n");
//            Console.WriteLine("3.Delete Employee\n");
//            Console.WriteLine("4.View Employee\n");
//            Console.WriteLine("5.Go Back\n");

//            Console.WriteLine("Enter Number of your choice: ");
//            choice1 = int.Parse(Console.ReadLine());
//            switch (choice1)
//            {
//                case 1:
//                    Console.WriteLine("{0,15}", "Add Employee");
//                    Console.WriteLine("-------------------------\n");
//                    Console.WriteLine("1.Enter First Name:\n");
//                    string name1 = Console.ReadLine();
//                    Console.WriteLine("1.Enter Last Name:\n");
//                    name2 = Console.ReadLine();
//                    Console.WriteLine("2.Enter Date of Birth:\n");
//                    DateTime dob = DateTime.Parse(Console.ReadLine());
//                    Console.WriteLine("3.Address:\n");
//                    string add = Console.ReadLine();
//                    Console.WriteLine("4.Contact:\n");
//                    int phone = int.Parse(Console.ReadLine());


//                    Console.WriteLine("Congrats {0} your added successfully!!!", name1);
//                    Console.WriteLine("\n{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", "First Name", "Last Name", "DOB", "Address", "Contact");
//                    Console.WriteLine("----------------------------");
//                    Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", name1, name2, dob, add, phone);

//                    break;
//                case 2:
//                    Console.WriteLine("{0,15}", "Edit Employee");

//                    Console.WriteLine("----------------------------\n");

//                    Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", "First Name", "Last Name", "DOB", "Address", "Contact");
//                    Console.WriteLine("----------------------------");
//                    Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, -10} {4, -10}", name1, name2, dob, add, phone);

//                    Console.WriteLine("1.Add Employee\n");
//                    Console.WriteLine("2.Edit Employee\n");
//                    Console.WriteLine("3.Delete Employee\n");
//                    Console.WriteLine("4.View Employee\n");
//                    Console.WriteLine("5.Go Back\n");

//                    Console.WriteLine("Enter Number of your choice: ");
//                    choice1 = int.Parse(Console.ReadLine());
//                    break;

//            }
//            break;
//        case 2:
//            Console.WriteLine("{0,15}", "Travel Requests");
//            Console.WriteLine("-------------------------\n");
//            Console.WriteLine("1.Raise Travel Request\n");
//            Console.WriteLine("2.View Travel Request\n");
//            Console.WriteLine("3.Delete Travel Request\n");
//            Console.WriteLine("4.Approve Travel Request\n");
//            Console.WriteLine("5.Confirm Booking\n");
//            Console.WriteLine("6.Go Back\n");

//            Console.WriteLine("Enter Number of your choice: ");
//            choice2 = int.Parse(Console.ReadLine());
//            break;
//        case 3:
//            System.Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }

//}
//    }