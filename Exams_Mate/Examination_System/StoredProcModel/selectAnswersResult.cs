﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.StoredProcModel
{
    public partial class selectAnswersResult
    {
        public int ans_id { get; set; }
        public int question_id { get; set; }
        public string content { get; set; }
        public bool isCorrect { get; set; }
    }
}
