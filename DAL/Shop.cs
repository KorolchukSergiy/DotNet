namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Shop : DbContext
    {
        public Shop()
            : base("name=Shop")
        {
            Database.SetInitializer<Shop>(new SetInitializer<Shop>());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<MotherBoard> MotherBoardes { get; set; }
        public virtual DbSet<CPU> CPUs { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
    }

}