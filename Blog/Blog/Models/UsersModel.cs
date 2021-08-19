using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class UsersModel
    {
        [Display(Name = "Возраст")]
        [Range(7, 70, ErrorMessage="Вам необходимо ввести возраст от 7 до 70")]
        public int age { get; set; }
        
        [Display(Name = "Имя")]
        [Required(ErrorMessage ="поле обяязательно для заполнения")]
        public string name { get; set; }
        
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "поле обяязательно для заполнения")]
        public string surname { get; set; }
        
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "поле обяязательно для заполнения")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Подтверждение E-mail")]
        [DataType(DataType.EmailAddress)]
        [Compare("Email", ErrorMessage ="Подтверждение Email неверное")]
        public string ConfirmEmail { get; set; }
        
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "поле обяязательно для заполнения")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength =8, ErrorMessage ="Пароль должен быть больше 8 символов и меньше 50")]
        public string Password { get; set; }

        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Подтверждение Email неверное")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}