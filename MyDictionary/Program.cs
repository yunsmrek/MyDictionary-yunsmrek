using System;

namespace MyDictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Student = new MyDictionary<int, string>();

            Student.Add(1, "Yunus Emre Kılıç");
            Student.Add(2, "Buğrahan Yalçınkaya");
            Student.Add(3, "Berkay Yazıcı");
            Console.WriteLine(Student.Count);
        }
    }
}
