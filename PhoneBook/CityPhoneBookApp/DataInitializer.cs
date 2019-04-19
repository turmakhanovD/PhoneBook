using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CityPhoneBookApp
{
    public class DataInitializer : CreateDatabaseIfNotExists<PhoneBookContext>
    {
        private List<City> cities;

        public DataInitializer()
        {
            cities = new List<City>
            {
                new City
                {
                     Name = "Нур-Султан",
                     Code = 7172
                },
                new City
                {
                     Name = "Алматы",
                     Code = 727
                },
                new City
                {
                     Name = "Шымкент",
                     Code = 7252
                },
                new City
                {
                     Name = "Байконыр",
                     Code = 33622
                },
                new City
                {
                     Name = "Актау",
                     Code = 7292
                },
                new City
                {
                     Name = "Актобе",
                     Code = 7132
                },
                new City
                {
                     Name = "Атырау",
                     Code = 7122
                },
                new City
                {
                     Name = "Балхаш",
                     Code = 71036
                },
                new City
                {
                     Name = "Боровое",
                     Code = 71630
                },
                new City
                {
                     Name = "Джезказган",
                     Code = 7102
                },
                new City
                {
                     Name = "Караганда",
                     Code = 7212
                },
                new City
                {
                     Name = "Кокшетау",
                     Code = 7162
                },
                new City
                {
                     Name = "Костанай",
                     Code = 7242
                },
                new City
                {
                     Name = "Кызылдорда",
                     Code = 7162
                },
                new City
                {
                     Name = "Павлодар",
                     Code = 7182
                },
                new City
                {
                     Name = "Семипалатинск",
                     Code = 7222
                },
                new City
                {
                     Name = "Тараз",
                     Code = 72622
                },
                new City
                {
                     Name = "Уральск",
                     Code = 7112
                },
                new City
                {
                     Name = "Усть-Каменогорск",
                     Code = 7232
                },
            };

        }


        protected override void Seed(PhoneBookContext context)
        {
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CitiesApp
{
    public class DataInitializer : CreateDatabaseIfNotExists<CityContext>
    {
        private List<City> cities;


        public DataInitializer()
        {
            cities = new List<City>
            {
                new City
                {
                     Name = "Нур-Султан"
                }  ,
                new City
                {
                     Name = "Алматы"
                }  ,
                new City
                {
                     Name = "ШЫмкент"
                }

            };

        }

        protected override void Seed(DataContext context)
        {
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
*/
