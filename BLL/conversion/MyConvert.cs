using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL.conversion
{
    public class MyConvert
    {
        static public BllUser UserToBllUser(User user)
        {
            BllUser GetBllUser = new BllUser
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Login = user.Login,
                Password = user.Password,
                Post= PostToBllPost(user.Post)
            };
            return GetBllUser;
        }

        static public BllPost PostToBllPost(Post post)
        {
            BllPost GetBllPost = new BllPost
            {
                Id = post.Id,
                Name = post.Name,
                Salary = post.Salary,
            };
            return GetBllPost;
        }
    }
}
