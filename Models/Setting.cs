using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Setting
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        [Column("id")]
        public int ID { get; set; }
        /// <summary>
        /// дата приема
        /// </summary>
        [Column("data_appointment", TypeName = "timestamp")]
        public DateTime DataAppointment { get; set; }
        /// <summary>
        /// время начала приема
        /// </summary>
        [Column("start_at", TypeName = "timestamp")]
        public DateTime StartAt { get; set; }
        /// <summary>
        /// продолжительность одного приема в минутах
        /// </summary>
        [Column("duration", TypeName = "integer")]
        public int Duration { get; set; }
        /// <summary>
        /// количество приемов в день
        /// </summary>
        [Column("qty_appointments", TypeName = "integer")]
        public int QtyAppointments { get; set; }
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

    }
}
