using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class UsersModel
    {
        public string name;
        public string surname;
        public int age = 0;
        public bool isHasCar = true;

        public UsersModel(string name, string surname, int age, bool hasCar)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

            isHasCar = hasCar;
        }

        public UsersModel()
        {

        }

    }
}