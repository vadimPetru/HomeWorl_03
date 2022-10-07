using HomeWorkWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using HomeWorkWebApp.Enum;
using Newtonsoft.Json;



namespace HomeWorkWebApp.Controllers
{

    public class UserController : Controller
    {
        
        public const string FILENAME = "DataBase.json";
       

        [HttpGet]
        public IActionResult InputDateAboutUser()
        {
            return View();
        }
     
        [HttpPost]
        public IActionResult Handler(string button ,string Surname , string Name , string Patronomic,
                string Gender , string DateOfBirth ,  string AboutYourself)
        {
            
            if (button == nameof(NamesButtons.Send))
            {
                UserInfo user = new(Surname, Name, Patronomic, Gender, DateOfBirth, AboutYourself);
                
                
                    using (StreamWriter writer = new StreamWriter(FILENAME, true))
                    {
                        string Line = JsonConvert.SerializeObject(user);
                        writer.WriteLine(Line);
                    }
                
               

            }
            return View(nameof(Views.InputDateAboutUser));

        }

        public IActionResult Serialization(string button2)
        {


            List<UserInfo> users = new();

            if (button2 == nameof(NamesButtons.ShowAuthorizedUsers))
            {
                try
                {

                    string[] lines = System.IO.File.ReadAllLines(FILENAME);
                    foreach (var item in lines)
                    {
                        users.Add(JsonConvert.DeserializeObject<UserInfo>(item));
                    }
                }
                catch
                {
                   
                }
                
               
               
            }

            return View(nameof(Views.Serialization), users);


        }



    }
}
