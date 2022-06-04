Regex_User_Registration.RegularExpression regex = new Regex_User_Registration.RegularExpression();
Console.WriteLine("1 - Enter First Name");
Console.WriteLine("2 - Enter Last Name");
Console.WriteLine("3 - Enter Enail-id");
int select =Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        Console.WriteLine("Enter First Name");
        string fName = Console.ReadLine();
        regex.name(fName);
        break;
    case 2:
        Console.WriteLine("Enter Last Name");
        string lName = Console.ReadLine();
        regex.name(lName);
        break;
    case 3:
        Console.WriteLine("Enter Enail-id");
        string id = Console.ReadLine();
        regex.email(id);
        break;

}
