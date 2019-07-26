namespace GuestBook.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;

    public class GuestbookEntry : DbContext
    {
        // Контекст настроен для использования строки подключения "GuestbookEntry" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "GuestBook.Models.GuestbookEntry" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "GuestbookEntry" 
        // в файле конфигурации приложения.
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Message { get; set; }
        public virtual DateTime DateAdded { get; set; }

        public GuestbookEntry()
            : base("name=GuestbookEntry")
        {

        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class CompanybookEntry : List<Founder>
    {
        //private List<Founder> listOfFounders = new List<Founder>();
        public virtual List<Founder> ListOfFounders { get; set; }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string INN { get; set; }

    }
    public class Founder
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}