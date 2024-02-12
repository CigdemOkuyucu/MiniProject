using System.Reflection;

public class Book
{
    public string Name;
    public int NumberOfPages;

    public Book(string name, int num)
    {
        this.Name = name;
        this.NumberOfPages = num;
    }

    public string Info() => $"{this.Name} : {this.NumberOfPages}";
}