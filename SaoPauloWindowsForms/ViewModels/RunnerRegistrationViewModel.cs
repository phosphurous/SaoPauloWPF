using SaoPauloWindowsForms.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaoPauloWindowsForms.ViewModels
{
    class RunnerRegistrationViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordAgain { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Gender> ListGender { get; set; }
        public string SelectedGender { get; set; }

        public List<Country> ListCountry { get; set; }
        public string SelectedCountry { get; set; }

        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string PasswordAgain { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //public string Gender { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime DateOfBirth { get; set; }
        //public string CountryCode { get; set; }
    }
}
