﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CapMobileWebApp.DAL.Model
{
    public partial class Role
    {
        public Role()
        {
            TrainingTest = new HashSet<TrainingTest>();
        }

        public long RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<TrainingTest> TrainingTest { get; set; }
    }
}