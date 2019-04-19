namespace CityPhoneBookApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhoneBookContext : DbContext
    {
        // Контекст настроен для использования строки подключения "PhoneBookContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "CityPhoneBookApp.PhoneBookContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "PhoneBookContext" 
        // в файле конфигурации приложения.
        public PhoneBookContext()
            : base("name=PhoneBookContext")
        {
            Database.SetInitializer<PhoneBookContext>(new DataInitializer());
        }

         public virtual DbSet<City> Cities { get; set; }
         public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}