﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModels
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string StudentNumber { get; set; }
        public string EmailAddress { get; set; }
        public CityEnum CityOfStudy { get; set; }
        public string PhoneNumber { get; set; }
    }
}
