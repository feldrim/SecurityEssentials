﻿using System.Collections.Generic;
using System.Linq;
using SecurityEssentials.Model;

namespace SecurityEssentials.ViewModel
{
    public class UserLogViewModel
    {
        public List<UserLog> UserLogs;

        public UserLogViewModel(User user)
        {
            UserLogs = user.UserLogs.OrderByDescending(ul => ul.CreatedDateUtc).Take(10).ToList();
        }
    }
}