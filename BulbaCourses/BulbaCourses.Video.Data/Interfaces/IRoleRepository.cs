﻿using BulbaCourses.Video.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.Video.Data.Interfaces
{
    public interface IRoleRepository
    {
        RoleDb GetById(string rolelId);
        IEnumerable<RoleDb> GetAll();
        void Add(RoleDb role);
        void Update(RoleDb role);
        void Remove(RoleDb role);
    }
}
