﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CapMobileWebApp.DAL.Model
{
    public partial class Asset
    {
        public long AssetId { get; set; }
        public long LoanApplicationId { get; set; }
        public string AssetName { get; set; }
        public double? AssetValue { get; set; }
        public long? LoanApplicantId { get; set; }
    }
}