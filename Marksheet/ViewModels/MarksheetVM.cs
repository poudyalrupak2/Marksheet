﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marksheet.ViewModels
{
    public class MarksheetVM
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? SchoolId { get; set; }
        public SelectList School { get; set; }
        public string AcedamicYearId { get; set; }
        public SelectList AcademicYear { get; set; }
        public SelectList Terminal { get; set; }
        public string Term { get; set; }
        public int Attendance { get; set; }

        public int EnglishPM { get; set; }//PM-Practical Marks
        public int EnglishTM { get; set; }//TM-Therory Marks
        public int NepaliTM { get; set; }
        public int MathTM { get; set; }
        public int SocialTM { get; set; }
        public int HealthPM { get; set; }
        public int HealthTM { get; set; }
        public int SciencePM { get; set; }
        public int ScienceTM { get; set; }
        public string Optional1Name { get; set; }
        public bool Opt1HasPractical { get; set; }
        public bool Opt2HasPractical { get; set; }
        public string Optional2Name { get; set; }
        public int Optional1PM { get; set; }
        public int Optional1TM { get; set; }
        public int Optional2PM { get; set; }
        public int Optional2TM { get; set; }
       
    }
}