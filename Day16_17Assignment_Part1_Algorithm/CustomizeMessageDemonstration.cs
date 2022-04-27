using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day16_17Assignment_Part1_Algorithm
{
    internal class CustomizeMessageDemonstration
    {
        public static string fName, lName, mobileNo;
        public static bool FirstNameValidation(string fName) // Creating a method for First name validation
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(fName, pattern))
                return true;
            else
                return false;
        }
        public static bool LastNameValidation(string lName) // Creating a method for Last name validation
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(lName, pattern))
                return true;
            else
                return false;
        }
        public static bool MobileNumberValidation(string mobileNo) // Creating a method for Mobile Number validation
        {
            string pattern = "^[9][1][-][6-9][0-9]{9}$"; // Regex for Mobile number validation
            //If Mobile Number entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(mobileNo, pattern))
                return true;
            else
                return false;
        }
        public static void FirstName()
        {
            Firstname:
            Console.WriteLine("\nEnter your First Name:");
            fName = Console.ReadLine();
            bool checkFirstName = CustomizeMessageDemonstration.FirstNameValidation(fName); //Calling method to check first name is valid or not with argument
            if (!checkFirstName)//If not valid then ask user to enter first name again
            {
                Console.WriteLine("\nYour First Name is not Valid");
                Console.WriteLine("\nYour First name should start with Capital Letter only and has minimum 3 Character and no space between letters");               
                goto Firstname;
            }
        }
        public static void LastName()
        {
            // User Last name validation
            Lastname:
            Console.WriteLine("\n\nEnter your last name : ");
            lName = Console.ReadLine(); //storing last name entered by user in variable
            bool checkLastName = CustomizeMessageDemonstration.LastNameValidation(lName); //Calling method to check last name is valid or not with argument
            if (!checkLastName)//If not valid then ask user to enter last name again
            {
                Console.WriteLine("\nYour Last Name is not Valid");
                Console.WriteLine("\nYour Last name should start with Capital Letter only and has minimum 3 Character and no space between letters");
                goto Lastname;
            }
        }
        public static void MobileNumber()
        {
            //user Mobile Number validation
            Mobilenumber:
            Console.WriteLine("\n\nEnter your Mobile Number : ");
            mobileNo = Console.ReadLine(); //storing mobile number entered by user in variable
            bool checkMobileNo = CustomizeMessageDemonstration.MobileNumberValidation(mobileNo); //Calling method to check mobile number is valid or not with argument
            if (!checkMobileNo)//If not valid then ask user to enter mobile number again
            {
                Console.WriteLine("\nYour Mobile Number should be in Format like 91-XXXXXXXXXX only");
                Console.WriteLine("\nYour Mobile Number is not Valid");                
                goto Mobilenumber;
            }
        }
        public static void Message()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine($"\nHello {fName}, We have your full name as \"{fName} {lName}\" in our system.your contact number is {mobileNo}.\nPlease, let us know in case of any clarification Thank you BridgeLabz {dateTime.ToString("dd/MM/yyyy")}.");
        }
        public static void UpdateDetails()
        {
            Console.WriteLine("\nDo you want to update any details? Y or n");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch == 'Y' || ch == 'y')
            {
                Again:
                Console.WriteLine("\n\nWhich field you want to update ?");
                Console.WriteLine("1.First Name\n2.Last Name\n3.Mobile no");
                int n = Convert.ToInt32(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        FirstName();
                        Console.WriteLine("\nYour first name successfully updated");
                        break;
                    case 2:
                        LastName();
                        Console.WriteLine("\nYour last name successfully updated");
                        break;
                    case 3:
                        MobileNumber();
                        Console.WriteLine("\nYour Mobile number successfully updated");
                        break;
                    default:
                        Console.WriteLine("\nEnter valid choice");
                        break;
                }
                Console.WriteLine("\n\nIf you want to update again then press 1 otherwise press 0");
                int c  = Convert.ToInt32(Console.ReadLine());
                if(c == 1)
                {
                    goto Again;
                }
                

            }
        }
    }
}
