using System;

class EmployeeData
{
    
    static void Main()
    {
        string firstNameEmployee = "Amanda";
        string lastNameEmployee = "Johnson";
        byte ageEmployee = 27;
        char genderEmployee= 'f';
        long numberID = 8306112507;
        ulong numberEmployee = 27563571;

        Console.WriteLine("First Name: {0}", firstNameEmployee);
        Console.WriteLine("Last Name: {0}", lastNameEmployee);
        Console.WriteLine("Age: {0}", ageEmployee);
        Console.WriteLine("Gender: {0}", genderEmployee);
        Console.WriteLine("Personal ID: {0}", numberID);
        Console.WriteLine("Unique Employee number: {0}", numberEmployee);
    }
}