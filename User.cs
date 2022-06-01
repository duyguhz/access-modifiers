using System;
namespace AccessModifiers
{
    public class User
    {

        private string _userName;
        private string  _password;
       

        public string UserName
        {
            get => _userName;
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                    _userName = value;
                    
            }
        }
        public string Password
        {
            get => _password;
            set
            { 
                if (value.Length >= 8 && value.Length <= 25)
                {
                    bool hasUpper = false;
                    bool hasLower = false;
                    bool hasDigit = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsUpper(value[i]))
                        
                            hasUpper = true;
                        
                        if (char.IsLower(value[i]))
                        
                            hasLower = true;
                        
                        if (char.IsDigit(value[i]))
                        
                            hasDigit = true;

                        
                    }
                    if (hasUpper && hasLower && hasDigit)
                        _password = value;







                    }
                }
                    
                   
                    


                    

            }
        }
    }
