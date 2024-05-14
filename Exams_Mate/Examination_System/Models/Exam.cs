﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Exam
{
    public int exam_no { get; set; }

    public int? Duration { get; set; }

    public DateTime GenerationDate { get; set; }

    public string State { get; set; }

    public int? PassingGrade { get; set; }

    public int? InsId { get; set; }

    public int? CrsId { get; set; }

    public virtual Course Crs { get; set; }

    public virtual Instructor Ins { get; set; }

    public virtual ICollection<QuestionsBank> Questions { get; set; } = new List<QuestionsBank>();
}