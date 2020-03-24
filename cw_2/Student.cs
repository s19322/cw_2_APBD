using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace cw_2
{
    internal class Student
    {
        [XmlElement(ElementName ="Student")]
        [XmlAttribute(AttributeName ="name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Surname")]
        public string Surname { get; set; }
        [XmlAttribute(AttributeName = "studies ")]
        public string Stud_mode { get; set; }
        [XmlAttribute(AttributeName = "studeis mode")]
        public string Mode { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public int Id_student { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "email")]
        public string Email { get; set; }
        [XmlAttribute(AttributeName = "mothers name")]
        public string Mothers_name { get; set; }
        [XmlAttribute(AttributeName = "fathers name")]
        public string Father_name { get; set; }

    }
}

