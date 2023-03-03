
internal class Student : Person
{
    //Field || Fields
    //Constructor Instance aldığımız zaman işə düşür
    //constroctur bir methotddur
    //constrocturin amma return type olmur
    //əslində arxa tərəfdə bizim obyektimizi yaradn methoddur

    public Student(string name):base(name)
    {
    }

    public Student (string name,string surname):base(name,surname)
    {

    }
 
    #region Overloading
    //public void GetValue()
    //{
    //    Console.WriteLine(Name);
    //}
    //public void GetValue(int num)
    //{
    //    Console.WriteLine(Surname);
    //}
    //public void GetValue(string num)
    //{
    //    Console.WriteLine(Age);
    //}
    #endregion
}
