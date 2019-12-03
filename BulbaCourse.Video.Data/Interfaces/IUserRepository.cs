﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Data.Models;

namespace BulbaCourse.Video.Data.Interfaces
{
    public interface IUserRepository
    {
        UserDb GetByLogin(string userName);
        UserDb GetUserById(string id);
        IEnumerable<UserDb> GetAll();
        UserDb Add(UserDb user);
        void Delete(UserDb user);
        void DeleteById(string userId);
        ICollection<CourseDb> GetUserCourse(string userId);
        RoleDb CheckRole(RoleDb role);
        bool AddRole(string newRole);
        bool AddCourseToUser(string userId, string courseId);
        bool DeleteCourseFromUser(string userId, string courseId);
    }
}
