using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngular.Models
{
    public class Schedule
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        [Column("id")]
        public int ID { get; set; }
        /// <summary>
        /// идентификатор настроек расписания
        /// </summary>
        [Column("setting_id")]
        public int SettingID { get; set; }
        /// <summary>
        /// идентификатор доктора
        /// </summary>
        [Column("doc_id")]
        public int DocID { get; set; }
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
