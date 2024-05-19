using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name, fathername, mothername, gender, dob, address, city, state, voterid,userid,password;
        int select;

        Console.WriteLine("             VOTER REGISTRATION          ");
        Console.WriteLine("                       ");
        Console.WriteLine("       WELCOME TO THE VOTER WEB PORTAL  ");
        Console.WriteLine("                       ");
        Console.WriteLine("ARE YOU A NEW REGISTER");

        Console.WriteLine("1.YES");
        Console.WriteLine("2.NO");
        Console.Write("SELECT:");
        select = Convert.ToInt32(Console.ReadLine());
        if (select == 1)
        {
            Console.WriteLine("         WELCOME TO THE REGISTARTION  ");
            Console.Write("NAME        :");
            name = Console.ReadLine();
            Console.Write("MOTHER NAME :");
            mothername = Console.ReadLine();
            Console.Write("FATHER NAME :");
            fathername = Console.ReadLine();
            Console.Write("GENDER      :");
            gender = Console.ReadLine();
            Console.Write("DOB         :");
            dob = Console.ReadLine();
            Console.Write("ADDRESS     :");
            address = Console.ReadLine();
            Console.Write("CITY        :");
            city = Console.ReadLine();
            Console.Write("STATE       :");
            state = Console.ReadLine();
            Console.Write("VOTERID:");
            voterid = Console.ReadLine();
            Console.WriteLine("    REGISTRATION IS COMPLETED");
            Console.WriteLine("    DHANYAVADHALLU ");
            Console.WriteLine("                       ");
            Console.WriteLine("    PLEASE LOGIN IN TO YOUR ID ");
            Console.WriteLine("1.YES");
            Console.WriteLine("2.NO");
            Console.Write("SELECT:");
            select = Convert.ToInt32(Console.ReadLine());
            if (select == 1)
            {
                Console.Write("USERID:");
                userid = Console.ReadLine();
                if (userid != voterid)
                {
                    Console.WriteLine(" PLEASE ENTER A VALID VOTER ID");
                }
                Console.Write("PASSWORD:");
                password = Console.ReadLine();
                if (password != userid)
                {
                    Console.WriteLine("PLEASE ENTER A VALID PASSWORD");
                }
                Console.WriteLine(" SELECT PARTY TO VOTE");
                Console.WriteLine("1.JSP");
                Console.WriteLine("2.TDP");
                Console.WriteLine("3.YSRCP");
                Console.WriteLine("SELECT:");
                select= Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    Console.WriteLine(" YOUR SUCCESFULLY VOTED TO JSP");
                }
                if (select == 2)
                {
                    Console.WriteLine(" YOUR SUCCESFULLY VOTED TO TDP");
                }
                if (select == 3)
                {
                    Console.WriteLine(" YOUR SUCCESFULLY VOTED TO YSRCP");
                }
                Console.WriteLine(" THANK YOU ");
            }

            else if (select < 1)
            {
                Console.WriteLine(" PLEASE ENTER A VALID CHOICE ");

                

            }
            else if (select > 2)
            {
                Console.WriteLine(" PLEASE ENTER A VALID CHOICE ");
            }
            else if(select==2)
            {
                Console.WriteLine(" THANK YOU ");
            }

        else if (select < 1)
        {
                Console.WriteLine(" PLEASE ENTER A VALID CHOICE ");
        }
        else if (select > 2)
            {
                Console.WriteLine(" PLEASE ENTER VALID CHOICE ");
            }
        else if (select == 2)
            {
                Console.WriteLine(" PLEASE LOGIN TO THE PAGE");
            }


        }
    }
}