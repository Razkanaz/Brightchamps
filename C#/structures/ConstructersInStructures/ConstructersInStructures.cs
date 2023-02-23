namespace structures;

struct Employee
{
    public int ID, Age;

    public Employee(int I, int A)
    {
        this.Age = A;
        this.ID = I;
    }
}

class struc
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(427, 90);
        Console.WriteLine($"ID = {emp.ID}\nAge = {emp.Age}");
        Console.ReadKey();

    }
}