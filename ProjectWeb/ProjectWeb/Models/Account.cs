﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectWeb.Models
{
    public class Account
    {
        private int iD;
        private string userName;
        private string passWord;
        private int iDPermission;

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int IDPermission { get => iDPermission; set => iDPermission = value; }

        public Account()
        {

        }

        public Account(DataRow row)
        {
            this.ID = int.Parse(row["iD"].ToString());
            this.UserName = row["userName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.IDPermission = int.Parse(row["iDPermission"].ToString());
        }

        public Account(int iD, string userName, string passWord, int iDAiDPermissionccessRight)
        {
            this.ID = iD;
            this.UserName = userName;
            this.PassWord = passWord;
            this.IDPermission = iDPermission;
        }

    }
}