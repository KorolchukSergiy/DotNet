using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.conversion;
using System.Windows;

namespace BLL
{
    public class Logic
    {
        public BllPost GetPostLogin(string login, string password)
        {
            BllPost GetBLLPOST = null;
            Function function = new Function();
            User TestUser = function.GetUser(login, password);
            //BllUser bllUser = null;
            //MessageBox.Show(TestUser.Name);
            if (TestUser!=null)
            {
                Post post = function.GetPostUser(TestUser);
                GetBLLPOST = MyConvert.PostToBllPost(post);
                //GetBLLPOST= ListPost.Where
            }

            return GetBLLPOST;
        }
    }
}
