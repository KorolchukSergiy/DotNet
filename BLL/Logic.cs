﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using DAL;
using BLL.conversion;



namespace BLL
{
    public class Logic
    {
        public BllPost GetPostLogin(string login, string password)
        {
            BllPost GetBLLPOST = null;
            Function function = new Function();
            User TestUser = function.GetUser(login, password);
            if (TestUser!=null)
            {
                if (TestUser.Login == login && TestUser.Password == password)
                {
                    Post post = function.GetPostUser(TestUser);
                    GetBLLPOST = MyConvert.PostToBllPost(post);
                }
            }
            
            return GetBLLPOST;
        }
    }
}