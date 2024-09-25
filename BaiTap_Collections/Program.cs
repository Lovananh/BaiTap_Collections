using System;
using System.Collections.Generic;

interface IExecutable
{
    void Execute();
}

class Program1 : IExecutable
{
    public void Execute()
    {
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong so nguyen : ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Nhap so nguyen thu  {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();

        Console.WriteLine("danh sach tang dan:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

class Program2 : IExecutable
{
    public void Execute()
    {
        Dictionary<string, int> hashtable = new Dictionary<string, int>();
        Console.Write("Nhap so luong nguoi: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            int age = int.Parse(Console.ReadLine());

            hashtable[name] = age;
        }

        Console.WriteLine("Danh sach ten va tuoi:");
        foreach (var entry in hashtable)
        {
            Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
        }
    }
}

class Program3 : IExecutable
{
    public void Execute()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();
        Console.Write("Nhap so luong hoc sinh: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap diem: ");
            int score = int.Parse(Console.ReadLine());

            students[name] = score;
        }

        Console.WriteLine("hien thi danh sach:");
        foreach (var student in students)
        {
            Console.WriteLine($"Ten: {student.Key}, Điem: {student.Value}");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {

        var programs = new IExecutable[]
        {
            new Program1(),
            new Program2(),
            new Program3()
        };


        foreach (var program in programs)
        {
            program.Execute();
            Console.WriteLine();
        }
    }
}
