﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.StoredProcModel;

public partial class Instructor
{
    public int InsId { get; set; }

    public string Fname { get; set; }

    public string Lname { get; set; }

    public string Email { get; set; }

    public string ProfilPicture { get; set; }

    public DateTime? HireDate { get; set; }

    public string Phone { get; set; }

    public int? UserId { get; set; }

    public int? DeptId { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual Department Dept { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual User User { get; set; }

    public virtual ICollection<Course> Crs { get; set; } = new List<Course>();
}