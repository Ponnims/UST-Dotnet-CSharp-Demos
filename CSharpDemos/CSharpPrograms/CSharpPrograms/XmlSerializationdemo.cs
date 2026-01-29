using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace CSharpPrograms
{
    internal class XmlSerializationdemo
    {
        //string filePath = "student.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(Student));

        public void SerializeStudent(Student student, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate)) 
            {
                serializer.Serialize(fs, student);
            }
        }

        public Student DeserializeStudent(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (Student)serializer.Deserialize(fs);

                fs.Close();
            }
        }
    }

    class Ssample
    {
        static void Main(string[] args)
        {
            XmlSerializationdemo xmlDemo = new XmlSerializationdemo();
            Student student = new Student() { Id = 1, Name = "Jane Doe", Course = "Mathematics" };
            // Serialize the student object to XML
            xmlDemo.SerializeStudent(student, "student.xml");
            Console.WriteLine("Student serialized to XML.");
            // Deserialize the student object from XML
            Student deserializedStudent = xmlDemo.DeserializeStudent("student.xml");
            Console.WriteLine("Student deserialized from XML:");
            Console.WriteLine($"ID: {deserializedStudent.Id}, Name: {deserializedStudent.Name}, Course: {deserializedStudent.Course}");
        }
    }
}
