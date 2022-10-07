using HomeWorkWebApp.Enum;

namespace HomeWorkWebApp.Models
{
    public class UserInfo
    {
        public string? _surname;
        public string? _name;
        public string? _patronomic;
        public string? _dateOfBirth;
        public string? _gender;
        public string? _aboutYourself;
        
        public string Surname
        {

            get { return _surname; }
            set { _surname = value ?? nameof(Explanation.NotFound); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value ?? nameof(Explanation.NotFound); }
        }

        public string Patronomic
        {
            get { return _patronomic; }
            set { _patronomic = value ?? nameof(Explanation.NotFound); }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth ; }
            set { _dateOfBirth = value ?? nameof(Explanation.NotFound); }
        }

        public string Gender { 
            get{ return _gender; }
            set { _gender = value ?? nameof(Explanation.NotFound); }
        }

        public string AboutYourself
        {
            get { return _aboutYourself; }
            set { _aboutYourself = value ?? nameof(Explanation.NotFound); }
        }


        public UserInfo(string surname , string name , string patronomic, string gender  , string dateOfBirth,
            string aboutYourself)
        {
            _surname = surname;
            _name = name;
            _patronomic = patronomic;
            _gender = gender;
            _dateOfBirth= dateOfBirth;
            _aboutYourself = aboutYourself;
           
        }
        public UserInfo()
        {

        }
        public override string ToString()
        {
            return $"Фамилия:{Surname}\nИмя:{Name}\nОтчество:{Patronomic}\nПол:{Gender}\nДата рождения:{DateOfBirth}\nИнформация о себе:{AboutYourself}";











        }
    }
}
