using AdapterDemo.Adaptee;
using AdapterDemo.Target;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AdapterDemo.Adapter
{
    public class EmployeeAdapter: EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returXml = base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
