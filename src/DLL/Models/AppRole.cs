﻿using System;
using System.Collections.Generic;
using DLL.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DLL.Models
{
    public class AppRole : IdentityRole<int>, ITrackable, ISoftDeletable
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}