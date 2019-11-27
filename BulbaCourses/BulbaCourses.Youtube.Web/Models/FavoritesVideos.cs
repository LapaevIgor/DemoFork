﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BulbaCourses.Youtube.Web.Models
{
    public class FavoritesVideos //
    {
        public int Id { get; set; }
        public List<string> Videos { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}