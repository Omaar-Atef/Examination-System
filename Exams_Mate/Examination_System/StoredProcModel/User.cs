﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.StoredProcModel;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; }

    public string UserPassword { get; set; }

    public int Type { get; set; }

    public string State { get; set; }

    public DateTime? LastLogin { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}