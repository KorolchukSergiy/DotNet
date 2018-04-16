using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTODal;
namespace DAL.Conversion
{
    public class DalConvert
    {
        public static DalUser UserToDTODalUser(User user)
        {
            DalUser GetUser = new DalUser()
            {
                Id=user.Id,
                Login=user.Login,
                Password=user.Password,
                Name=user.Name,
                Surname=user.Surname,
                Post=user.Post.Name
            };
            return GetUser;
        }

        public static DalCpuFromShop CpuToDTODalCpuShop(CpuFromShop Cpu)
        {
            DalCpuFromShop GetCpu = new DalCpuFromShop()
            {
                Id = Cpu.Id,
                Name = Cpu.Name,
                Producer = Cpu.Producer.Name,
                Quantity = Cpu.Quantity,
                SalaryPrice = Cpu.SalaryPrice,
                Cash = Cpu.Cash,
                Core = Cpu.Core,
                Threads = Cpu.Threads,
                Frequency = Cpu.Frequency,
                Image = Cpu.Image,
                Socket = Cpu.Socket,
                Video = Cpu.Video
            };
            return GetCpu;
        }

        static public DalPost PostToDalPost(Post post)
        {
            DalPost GetBllPost = new DalPost
            {
                Id = post.Id,
                Name = post.Name,
                Salary = post.Salary,
            };
            return GetBllPost;
        }
    }
}
