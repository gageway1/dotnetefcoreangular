using LegacyData.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace LegacyData.Models.Models
{
    [Table("CP01VTAInactiveAllData", Schema = "LegacyData")]
    public class VTAInactiveAllData : EntityBase
    {
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string emp_group { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string lastname { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string firstname { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string m_init { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string emp_id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string bin_crse_k { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string comp_date { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string calc_cdate { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string sess_stat { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string sess_date { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string end_date { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string code { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string status { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string sess_num { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string crse_title { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string crse_site { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string crse_grade { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string crse_score { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string train_hrs { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string sess_hrs { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string sess_key { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string shift { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string department { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string workarea { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string job_title { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string no_lessons { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string no_complet { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string position { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string cert_no { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string badge_scan { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string rptkey { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string emp_key { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [MaxLength(50)]
        public string date_hire { get; set; }
    }
}
