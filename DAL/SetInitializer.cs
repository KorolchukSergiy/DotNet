using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Drawing;


namespace DAL
{
    internal class SetInitializer<T> : DropCreateDatabaseAlways<Shop>
    {
        protected override void Seed(Shop context)
        {
            Producer Intel = new Producer
            {
                Name = "Intel",
                CPUs = new List<CpuFromProvider>(),
                MotherBoards = new List<MotherBoardFromProvider>()

            };
            Producer AMD = new Producer
            {
                Name = "AMD",
                CPUs = new List<CpuFromProvider>(),
                MotherBoards = new List<MotherBoardFromProvider>()
            };
            Producer MSI = new Producer
            {
                Name = "MSI",
                CPUs = new List<CpuFromProvider>(),
                MotherBoards = new List<MotherBoardFromProvider>()
            };

            Provider KTC = new Provider
            {
                Name = "KTC"

            };
            Provider Enter = new Provider
            {
                Name = "Enter"
            };
            Provider I5 = new Provider
            {
                Name = "I5"
            };


            MemoryStream ms = new MemoryStream();
            Image img = Image.FromFile(@"I7700.jpg");
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            CpuFromShop I7700 = new CpuFromShop
            {
                Name = "I7700",
                Producer = Intel,
                Socket = "1151",
                Video = "Intel HD",
                Core = 4,
                Threads = 8,
                Cash = "8 Mb",
                SalaryPrice = 10000,
                Image = ms.ToArray(),
                BuyPrice = 7000,
                Quantity=2,
                Frequency=3300,
            };

            ms = new MemoryStream();
            img = Image.FromFile(@"Ryzen 7 1800X.jpg");
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            CpuFromShop Ryzen71800X = new CpuFromShop
            {
                Name = "Ryzen 7 1800X",
                Producer = AMD,
                Socket = "Am4",
                Video = "None",
                Core = 8,
                Threads = 8,
                Cash = "4 Mb",
                SalaryPrice = 9000,
                Image = ms.ToArray(),
                BuyPrice = 6500,
                Quantity = 3,
                Frequency=3500

            };
            
            ms = new MemoryStream();
            img = Image.FromFile(@"H110MPRO.jpg");
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
          
            MotherBoardFromShop H110MProD = new MotherBoardFromShop
            {
                Name = "H110M Pro-D",
                Producer = MSI,
                Socket = "1151",
                ChipSet = "H110M",
                RAM = "4X DDR-4",
                PciE = "1X Pci-E 3.0 X16, 1X Pci-E 3.0 X8",
                USB = "8X USB 2.0, 2X USB 3.0",
                SalaryPrice = 1500,
                BuyPrice = 1000,
                Image = ms.ToArray(),
                Quantity = 1
            };

            context.ItemFromShops.AddRange(new List<ItemFromShop> { I7700, Ryzen71800X, H110MProD });
            context.Producers.AddRange(new List<Producer> { Intel, AMD, MSI });
            context.Providers.AddRange(new List<Provider> { KTC, Enter, I5 });
            context.SaveChanges();

            Post Worker = new Post
            {
                Name="Seller",
                Salary=5000,
                Users = new List<User>()
            };

            Post Manager = new Post
            {
                Name = "Manager",
                Salary = 10000,
                Users = new List<User>()
            };

            Post Director = new Post
            {
                Name = "Director",
                Salary = 15000,
                Users = new List<User>()
            };

            Post Provider = new Post
            {
                Name = "Provider",
                Salary = null,
                Users = new List<User>()
            };


            User Seller = new User
            {
                Name = "Andriy",
                Surname ="Ruduk",
                Login= "Ruduk",
                Password= "Ruduk",
                Post = Worker,
                Online = false
            };

            User UserManager = new User
            {
                Name = "Olexandr",
                Surname = "Podik",
                Login = "Podik",
                Password = "Podik",
                Post = Manager,
                Online=false
            };
            User UserDirector = new User
            {
                Name = "Sergiy",
                Surname = "Korolchuk",
                Login = "Korolchuk",
                Password = "Korolchuk",
                Post = Director,
                Online = false
            };

            User UserProvider = new User
            {
                Name = "Olexandr",
                Surname = "Martinuk",
                Login = "Martinuk",
                Password = "Martinuk",
                Post = Provider,
                Online = false
            };
            context.Users.AddRange(new List<User>
            { Seller, UserManager, UserDirector, UserProvider });

            base.Seed(context);
        }
    }
}