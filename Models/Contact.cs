﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Contact
    {
        [Column("id")]
        public int ID { get; set; } //  id int
        [Column("first_name", TypeName = "timestamp")]
        public string FirstName { get; set; } //  first_name varchar(255)
        [Column("middle_name", TypeName = "timestamp")]
        public string MiddleName { get; set; } //  middle_name varchar(255)
        [Column("last_name", TypeName = "timestamp")]
        public string LastName { get; set; } //  last_name varchar(255)
        [Column("phone", TypeName = "varchar(255)")]
        public string Phone { get; set; } //  phone varchar(255)
        [Column("email", TypeName = "varchar(255)")]
        public string Email { get; set; } //  email varchar(255)
        [Column("address_id")]
        public int AddressID { get; set; } //  address_id int      
        [Column("birthday", TypeName = "timestamp")]
        public DateTime Birthday { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } //  created_at timestamp
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } //  updated_at timestamp
        
        public Doc Doc { get; set; }
        public Patient Patient { get; set; }
        public Address Address { get; set; }

    }
}
