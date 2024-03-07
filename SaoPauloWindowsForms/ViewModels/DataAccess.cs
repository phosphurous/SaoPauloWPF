using SaoPauloWindowsForms.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaoPauloWindowsForms.ViewModels
{
    class DataAccess
    {
        //public static VolunteerManagementViewModel GetVolunteerManagementViewModel()
        //{
        //    using (var ctx = new DBModel())
        //    {
        //        var volunteerList = ctx.Volunteers
        //            .Include(i => i.Country)
        //            .Select(i => i).ToList();

        //        var lookupList = new List<string>()
        //        {
        //        "First Name",
        //        "Last Name",
        //        "Country",
        //        "Gender",
        //        };
        //        VolunteerManagementViewModel model = new VolunteerManagementViewModel()
        //        {
        //            ListVolunteer = volunteerList,
        //            ListSortBy = lookupList,
        //            SelectedSortBy = lookupList.FirstOrDefault(),
        //            TotalVolunteers = volunteerList.Count
        //        };
        //        return model;
        //    }
        //}

        public static List<EF.Gender> GetAllGenders()
        {
            using (var ctx = new EF.DBModel())
            {
                return ctx.Genders.Select(i => i).ToList();
            }
        }
        public static List<EF.Country> GetAllCountries()
        {
            using (var ctx = new EF.DBModel())
            {
                var countryList = ctx.Countries.Select(i => i).ToList();
                return countryList;
            }
        }

        public static User AttemptLogin(string useremail, string password)
        {
            using (var ctx = new DBModel())
            {
                var user = ctx.Users.Select(i => i)
                    .Include(i => i.Runners)
                    .Include(i => i.Runners.Select(r => r.Registrations))
                    .Where(i => i.Email == useremail).FirstOrDefault();

                if (user != null)
                {
                    if (user.Password == password)
                        return user;
                }
                return null;
            }
        }

        public static bool RegisterRunner(RunnerRegistrationViewModel data)
        {
            using (var ctx = new DBModel())
            {
                var email = ctx.Users.Where(s => s.Email == data.Email).FirstOrDefault();

                if (email != null)
                {
                    return false;
                }
                else
                {
                    ctx.Users.Add(new EF.User()
                    {
                        Email = data.Email,
                        FirstName = data.FirstName,
                        LastName = data.LastName,
                        Password = data.Password,
                        RoleId = "R"
                    });
                    ctx.Runners.Add(new EF.Runner()
                    {
                        Email = data.Email,
                        Gender = data.SelectedGender,
                        DateOfBirth = data.DateOfBirth,
                        CountryCode = data.SelectedCountry
                    });

                    ctx.SaveChanges();
                    return true;
                }
            }
        }

        //public static void RetrieveCharity()
        //{
        //    //using (var db = new DBModel())
        //    //{
        //    //    var list = db.Charities.SqlQuery(
        //    //        "SELECT * FROM dbo.[Charity] WHERE CharityName = '" + selectedCharityName + "'").FirstOrDefault();
        //    //    selectedCharityDescription = list.CharityDescription.ToString();
        //    //    selectedCharityLogoURI = list.CharityLogo.ToString();
        //    //}
        //}

    }
}
