using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Address
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        [Column("id")]
        public int ID { get; set; } //  id int
        /// <summary>
        /// почтовый индекс
        /// </summary>
        [Column("zipcode", TypeName = "varchar(255)")]
        public string ZipCode { get; set; } //  zipcode varchar(255)
        /// <summary>
        /// страна
        /// </summary>
        [Column("country", TypeName = "varchar(255)")]
        public string Country { get; set; } //  country varchar(255)
        /// <summary>
        /// область
        /// </summary>
        [Column("region", TypeName = "varchar(255)")]
        public string Region { get; set; } //  region varchar(255)
        /// <summary>
        /// город (населенный пункт)
        /// </summary>
        [Column("locality", TypeName = "varchar(255)")]
        public string Locality { get; set; } //  locality varchar(255)
        /// <summary>
        /// улица
        /// </summary>
        [Column("street", TypeName = "varchar(255)")]
        public string Street { get; set; } //  street varchar(255)
        /// <summary>
        /// номер дома
        /// </summary>
        [Column("house", TypeName = "varchar(255)")]
        public string House { get; set; } //  house varchar(255)
        /// <summary>
        /// номер квартиры
        /// </summary>
        [Column("apartment", TypeName = "varchar(255)")]
        public string Apartment { get; set; } //  apartment varchar(255)

        public ICollection<Contact> Contacts { get; set; }
    }
}
