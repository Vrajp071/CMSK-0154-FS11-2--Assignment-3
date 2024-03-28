//Name - Vraj pareshkumar Patel
// id - 3154641

using system;

public class BaseClass
{
    public virtual bool IsValidated()
    {
        return false;
    }
}

public class Person : BaseClass
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Person(string firstName = "", string lastName = "")
    {
        FirstName = firstName;
        LastName = lastName;

        if (FirstName == null) FirstName = "";
        if (LastName == null) LastName = "";
    }

    public override bool IsValidated()
    {
        if (FirstName.Length > 0 && LastName.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person bob = new Person();
        Console.WriteLine(bob.IsValidated());

        Person kim = new Person("kim", "smith");
        Console.WriteLine(kim.IsValidated());
    }
}
