
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IPG512F1_Keanan_Flowerday.Models
{
    public class User
    {
        #region Properties
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public Pizza FavPizza { get; set; }

        public List<int> Roles {
            get {
                if(this.UserRoles == "")
                    return new List<int> { };
                List<string> _list = this.UserRoles.Split(',').ToList();
                if (_list.Count >0)
                {
                    return _list.Select(i => Convert.ToInt32(i)).ToList();
                }
                return new List<int> { };
                
            }
            set {
                this.UserRoles = value.Select(i => i.ToString()).Aggregate((i, j) => i + ',' + j);
            }
        }

        public string UserRoles { get; set; }
        #endregion


        #region Behaviours
        public void Update(User _user)
        {
            this.Name = _user.Name ?? this.Name;
            this.Surname = _user.Surname ?? this.Surname;
            // this.Address = _user.Address ?? this.Address;
            this.Username = _user.Username ?? this.Username;
            // this.FavPizza = _user.FavPizza ?? this.FavPizza;
            this.Password = _user.Password ?? this.Password;
        }

        public bool Validate(User _user)
        {
            if (this.Username.ToLower() != _user.Username.ToLower())
                return false;
            if (this.Password != _user.Password)
                return false;

            return true;
        }

        public string NameToString()
        {
            //if (this.Surname != "" || this.Surname != null)
            //	return this.Name + " " + this.Surname;
            //else
            return this.Name;
        }
        #endregion




    }
    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RedirectURL { get; set; }
    }
}