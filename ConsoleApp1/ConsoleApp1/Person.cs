
internal class Person
{
    public string Name;
    public string Surname;
    public int Age;
    public string Email;

    public Person():this("Guest","Guestov")
    {

    }
    public Person(string Name)
    {
        this.Name = Name;
    }
    public Person(string Name,string Surname):this(Name)
    {
        this.Surname = Surname;
    }

    public void GetValue()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Surname);
    }
}
