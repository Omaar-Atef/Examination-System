﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.StoredProcModel
{
    public partial class selectStudentsResult
    {
        public int std_id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? age { get; set; }
        public string email { get; set; }
        public string profil_picture { get; set; }
        public DateTime? join_date { get; set; }
        public string phone { get; set; }
        public int? user_id { get; set; }
        public int? dept_id { get; set; }
    }
}