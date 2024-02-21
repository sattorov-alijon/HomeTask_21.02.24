var Person1=new Person();
Person1.FirstName="Alijon";
Person1.LastName="Sattorov";
Person1.Age=22;
Person1.Address="Hamadoni";

System.Console.WriteLine(Person1.GetFullName());
System.Console.Write("My birth year is ");
System.Console.WriteLine(Person1.GetBirthYear());
System.Console.WriteLine(Person1.Address);







class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Address;
    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName}";
    }
    public int GetBirthYear()
    {
        return Age;
    }    


}