using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationExample;

class Program
{
#pragma warning disable SYSLIB0011 // Variable is declared but never used
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");  
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        Console.WriteLine(path);
        Student s = new Student()
        {
            Name = "John",
            Age = 25,
            Username = "john123",
            Password = "123456",
        };

        string pathBin = path + "student.bin";

    }   
    public static void SerializeStudent(string path, Student s)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            binaryFormatter.Serialize(fs, s);
        }
        Console.WriteLine("Student object serialized successfully");
    }
    private static void DeserializeStudent(string path)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            Student sl = (Student)binaryFormatter.Deserialize(fs);
            Console.WriteLine(sl);
        }
    }
}