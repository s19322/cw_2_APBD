using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace cw_2
{
   public class ReadData
    {
        string pathData;
        string pathOut;
        string dataFormat;
        System.IO.StreamWriter files;

        public ReadData(string pathData = "data.csv", string pathOut = "result.xml", string dataFormat = "XML")
        {
            this.pathData = pathData;
            this.pathOut = pathOut;
            this.dataFormat = dataFormat;

            List<Student> list = new List<Student>();

            string fullpath = "";

            try
            {
                fullpath = @"C:\Users\THINK\Desktop\data.csv";// + pathData;????
            } catch (ArgumentException argumentEx)
            {
                Console.WriteLine("podana sciezka jest niepoprawna. Blad :" + argumentEx);
            }
            //wczytywanie z pliku

            var file = new FileInfo(fullpath);

            using (var stream = new StreamReader(file.OpenRead()))
            {
                string line = null;
                int countStud = 0;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] kolumny = line.Split(',');//jedna linia czyli jeden student
                   countStud++;
                        if (kolumny.Length < 9)
                        {
                            try
                            {
                                //W using bloku obiekt jest tylko do odczytu i nie można go modyfikować ani ponownie przypisywać.
                                if (countStud == 0)
                                    using (files = new System.IO.StreamWriter(@"C:\Users\THINK\Desktop\log.txt"))
                                    {
                                        foreach (string linee in kolumny)
                                            files.WriteLine(linee);
                                        
                                    }
                                else
                                    foreach (string linee in kolumny)
                                        files.WriteLine(linee);
                              
                            }
                            catch (FileNotFoundException fileEx)
                            {
                                Console.WriteLine("nie znalezniono pliku log.txt. Blad : " + fileEx);

                            }
                        } else
                            
                 list.Add(new Student
                 {
                     Name = kolumny[0],
                     Surname = kolumny[1],
                     Stud_mode = kolumny[2],
                     Mode = kolumny[3],
                     Id_student = Int32.Parse(kolumny[4]),
                     Date = kolumny[5],
                     Email = kolumny[6],
                     Mothers_name = kolumny[7],
                     Father_name = kolumny[8]
                 });
                    }
                }
            IEnumerable<Student> studensNonDup = list.Distinct(new StudentCompare());
            List<Student> list2 = new List<Student>();
            foreach (var stud in studensNonDup)
                list2.Add(stud);

                using (FileStream writer = new FileStream(@"resul.xml", FileMode.Create))
                {

                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                                                  // new XmlRootAttribute("uczelnia"));
                    serializer.Serialize(writer, list2);
                 //   serializer.Serialize(writer, list);
                }


            }
        }
    }


                
