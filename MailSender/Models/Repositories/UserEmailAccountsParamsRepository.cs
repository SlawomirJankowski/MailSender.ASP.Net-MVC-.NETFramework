﻿using MailSender.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailSender.Models.Repositories
{
    public class UserEmailAccountsParamsRepository
    {
        public List<UserEmailAccountParams> GetEmailAccounts(string userId)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.UserEmailAccounts
                    .Where(a => a.UserId == userId)
                    .ToList();
            }
        }
    }
}