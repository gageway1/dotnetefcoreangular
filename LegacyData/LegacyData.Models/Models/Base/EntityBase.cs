using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LegacyData.Models.Models.Base
{
    public abstract class EntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // DO NOT REMOVE THESE

        //[Timestamp] public byte[] TimeStamp { get; set; }

        //[Required]
        //[Column]
        //public DateTime CreatedOn { get; set; } = DateTime.Now;

        //[Required]
        //[Column(TypeName = "varchar(75)")]
        //[MaxLength(75)]
        //public string CreatedBy { get; set; } = "SYSTEM";

        //[Required]
        //public DateTime? UpdatedOn { get; set; } = DateTime.Now;

        //[Required]
        //[Column(TypeName = "varchar(75)")]
        //[MaxLength(75)]
        //public string UpdatedBy { get; set; } = "SYSTEM";

        //[Required]
        //public bool IsDeleted { get; set; } = false;

        //[Required]
        //[Column(TypeName = "varchar(75)")]
        //[MaxLength(75)]
        //public string DeletedBy { get; set; } = "SYSTEM";
    }
}
