using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Drawing;

namespace DAL
{
    public class Function
    {
        public User GetUser(string login, string password)
        {
            User GetUser = null;
            using (Shop shop = new Shop())
            {
                GetUser = shop.Users.Where(x => x.Login.Equals(login)
                                           && x.Password.Equals(password)).
                                           FirstOrDefault();
            };
            return GetUser;
        }

        public List<Post> GetListPost()
        {
            List<Post> GetListPost = null;
            using (Shop shop = new Shop())
            {
                GetListPost = shop.Posts.Local.ToList();
            };
            return GetListPost;

        }

        public Post GetPostUser(User user)
        {
            Post UserLoginPost = null;

            using (Shop shop = new Shop())
            {
                User tmpUser = shop.Users.Where(x => x.Id == user.Id).First();
                UserLoginPost = tmpUser.Post;
            };
            return UserLoginPost;
        }

        public List<CPU> GetListCpu()
        {
            List<CPU> GetList = new List<CPU>();
            var ttt = new Dictionary<CPU, string>();
            using (Shop shop = new Shop())
            {
                ttt= shop.CPUs.Select(x => new { x, x.Producer.Name }).ToDictionary(t => t.x,t=>t.Name);

            };

            return GetList;
        }
    }
}
