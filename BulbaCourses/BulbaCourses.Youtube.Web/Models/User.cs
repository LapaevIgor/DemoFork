﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BulbaCourses.Youtube.Web.Models
{
    public class User
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }  //скрыть надо бы..
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string NumberPhone { get; set; } //возможно надо для авторизации, или восстановления пароля
        public List<string> Email { get; set; } //для дополнительных(резервных) адресов
        public List<Cache> Cache { get; set; }
        public List<SearchStory> SearchStory { get; set; }
        public List<FavoritesVideos> FavoritesVideos { get; set; }
        public List<RecentVideos> RecentVideos { get; set; }
    } 
}