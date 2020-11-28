using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Patient
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("contact_id", TypeName = "integer")]
        public int ContactID { get; set; }
        [Column("medical_history", TypeName = "varchar(255)")]
        public string MedicalHistory { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; } 
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; }

        public Contact Contact { get; set; }
       
    }
}
