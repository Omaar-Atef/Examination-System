﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.StoredProcModel
{
    public partial class selectExamResult
    {
        public int exam_no { get; set; }
        public int? duration { get; set; }
        public DateTime generation_date { get; set; }
        public string state { get; set; }
        public int? passing_grade { get; set; }
        public int? ins_id { get; set; }
        public int? crs_id { get; set; }
    }
}
