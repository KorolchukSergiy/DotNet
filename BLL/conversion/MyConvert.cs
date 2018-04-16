using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.DataModel;
using System.Windows.Media.Imaging;
using System.IO;
using DAL.DTODal;

namespace BLL.conversion
{
    public class MyConvert
    {
        static public BllUser UserToBllUser(DalUser user)
        {
            BllUser GetBllUser = new BllUser
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Login = user.Login,
                Password = user.Password,
            };
            return GetBllUser;
        }

        static public BllPost PostToBllPost(DalPost post)
        {
            BllPost GetBllPost = new BllPost
            {
                Id = post.Id,
                Name = post.Name,
                Salary = post.Salary,
            };
            return GetBllPost;
        }

        static public BllCpu CpuToBllCpu(DalCpuFromShop Cpu)
        {
            BllCpu GetBllCpu = new BllCpu
            {
                Id = Cpu.Id,
                Name = Cpu.Name,
                Producer = Cpu.Producer,
                Quantity=Cpu.Quantity,
                SalaryPrice=Cpu.SalaryPrice,
                Cash=Cpu.Cash,
                Core=Cpu.Core,
                Threads=Cpu.Threads,
                Frequency=Cpu.Frequency,
                Image= DyteArrayToBitmapImage(Cpu.Image),
                Socket =Cpu.Socket,
                Video=Cpu.Video
            };

            return GetBllCpu;
        }

        //static public BllCpu CpuToBllCpu(DalCpuFromProvider Cpu)
        //{
        //    BllCpu GetBllCpu = new BllCpu
        //    {
        //        Id = Cpu.Id,
        //        Name = Cpu.Name,
        //        Producer = Cpu.Producer,
        //        Quantity = Cpu.Quantity,
        //        SalaryPrice = Cpu.SalaryPrice,
        //        Cash = Cpu.Cash,
        //        Core = Cpu.Core,
        //        Threads = Cpu.Threads,
        //        Frequency = Cpu.Frequency,
        //        Image = DyteArrayToBitmapImage(Cpu.Image),
        //        Socket = Cpu.Socket,
        //        Video = Cpu.Video
        //    };
        //
        //    return GetBllCpu;
        //}


        static public BitmapImage DyteArrayToBitmapImage(byte[] image)
        {
            BitmapImage getimage = new BitmapImage();
            using (var ms = new MemoryStream(image))
            {
                getimage.BeginInit();
                getimage.CacheOption = BitmapCacheOption.OnLoad;
                getimage.StreamSource = ms;
                getimage.EndInit();
            }
                return getimage;
        }
    }
}
