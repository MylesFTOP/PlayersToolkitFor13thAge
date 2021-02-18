﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class UserModel
    {
        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string EmailAddress { get; private set; }

        public void UpdateUsername(string newUsername) {
            Username = newUsername;
        }

        public void UpdateEmailAddress(string newEmailAddress) {
            EmailAddress = newEmailAddress;
        }
    }
}
