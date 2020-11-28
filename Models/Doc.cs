using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Doc
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        [Column("id")]
        public int ID { get; set; }
        /// <summary>
        /// идентификатор связанной сущности Contact
        /// </summary>
        [Column("contact_id")]
        public int ContactID { get; set; }
        /// <summary>
        /// специальность
        /// </summary>\
        [Column("speciality", TypeName = "varchar(255)")]
        public string Speciality { get; set; }
        /// <summary>
        /// номер кабинета
        /// </summary>
        [Column("office", TypeName = "varchar(255)")]
        public string Office { get; set; }
        /// <summary>
        /// дата приема на работу
        /// </summary>
        [Column("hired_at", TypeName = "timestamp")]
        public DateTime HiredAt {get;set;}
        /// <summary>
        /// дата создания записи
        /// </summary>
        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// дата обновления записи
        /// </summary>
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; }

        public Contact Contact { get; set; }
    }
}
