using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterDemo.Adaptee
{
    public class Employee
    {
        Employee() { }
        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }

    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            employees.Add(new Employee(1, "John"));
            employees.Add(new Employee(2, "Alice"));
            employees.Add(new Employee(3, "Bob"));
        }

        public virtual string GetAllEmployees()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(employees.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, employees, emptyNamespaces);
                    return stream.ToString();
                }
            }
        }
    }
}
