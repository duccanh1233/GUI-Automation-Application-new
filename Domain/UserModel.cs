using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserData userData = new UserData();
        
        //Thuộc tính
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        //private string lastName;
        private string position;
        private string email;

 
        public UserModel()
        {
        }

        public UserModel(int idUser, string loginName, string password, string firstName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.position = position;
            this.email = email;
        }

        //Methods
        public string editUserProfile()
        {
            try
            {
                userData.editProfile(idUser, loginName, password, firstName,email);
                LoginUser(loginName, password);
                return "Your profile has been successfully updated";
            }
            catch (Exception ex)
            {
                return "Username is already registered, try another" + ex;
            }
        }


        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

    }
}
