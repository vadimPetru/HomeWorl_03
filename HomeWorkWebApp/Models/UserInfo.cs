namespace HomeWorkWebApp.Models
{
    public class UserInfo
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Education { get; set; }

        public List<UserInfo> users = new();

        public UserInfo(string surname , string name , string age  , string education)
        {
            Surname = surname;
            Name = name;
            Age = age;
            Education = education;
        }
        public UserInfo() 
        {

        }
        public override string ToString()
        {
            return $"{Surname} {Name} вам {Age} лет. Ваше образование {Education}";
        }
    }
}
