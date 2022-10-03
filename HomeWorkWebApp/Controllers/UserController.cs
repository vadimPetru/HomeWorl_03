
using HomeWorkWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Xml.Serialization;



namespace HomeWorkWebApp.Controllers
{

    public class UserController : Controller
    {
        XmlSerializer xml = new XmlSerializer(typeof(UserInfo));
        
        [HttpGet]
        public IActionResult InputDateAboutUser()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SecondTask(string button ,string Surname , string Name , string Age , string Education)
        {
            int path = 0;
            if (button == "Send")
            {

                UserInfo user = new(Surname, Name, Age, Education);
                while (System.IO.File.Exists(@$"Database\{path}.xml"))
                {
                    path++;
                }
                if(!System.IO.File.Exists(@$"Database\{path}.xml"))
                {
                    using (Stream filestream = new FileStream(@$"Database\{path}.xml", FileMode.OpenOrCreate))
                        xml.Serialize(filestream, user);
                }
               

                //string[] array = { Surname, Name, Age, Education," " };
                //if(System.IO.File.Exists("database.txt") == true)
                //{
                //    foreach(var item in array)
                //    {
                //        System.IO.File.AppendAllText("database.txt", item);
                //    }

                //}
                //else
                //{
                //    System.IO.File.Create("database.txt");
                //    foreach (var item in array)
                //    {
                //        System.IO.File.AppendAllText("database.txt", item);
                //    }

                //}
               



            }
            return View("InputDateAboutUser");


        }

        public IActionResult Serialization(string button2)
        {
            DataBase data = new();
            if (button2 == "ShowAuthorizedUsers")
            {
                DirectoryInfo directoryInfo = new(@$"C:\Users\6ddd1\source\repos\HomeWorl_03\HomeWorkWebApp\Database\");
                foreach(var item in directoryInfo.GetFiles())
                {
                    using( Stream filestream = new FileStream(@$"C:\Users\6ddd1\source\repos\HomeWorl_03\HomeWorkWebApp\Database\{item.Name}", FileMode.OpenOrCreate))
                    {

                      UserInfo user = xml.Deserialize(filestream) as UserInfo;
                        data.users.Add(user);
                     }

                   
                }
               

            }

            return View("Serialization",data);

        }



    }
}
