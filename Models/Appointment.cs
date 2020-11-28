using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Appointment
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        [Column("id")]
        public int ID { get; set; }
        /// <summary>
        /// идентификатор пациента
        /// </summary>
        [Column("patient_id")]
        public int PatientID { get; set; }
        /// <summary>
        /// идентификатор записи в расписании
        /// </summary>
        [Column("schedule_id")]
        public int ScheduleID { get; set; }
        /// <summary>
        /// контролль визита пациента
        /// </summary>
        [Column("is_patient_visited", TypeName = "tinyint(1)")]
        public bool IsPatientVisited { get; set; }
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
