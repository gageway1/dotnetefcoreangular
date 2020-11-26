using LegacyData.Models.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegacyData.Models.Models
{
    [Table("Dogs", Schema = "LegacyData")]
    public class Dogs : EntityBase
    {
        public string FirstName { get; set; } /* "John" */
        public char MiddleInit { get; set; } // 'F' || '1'
        public string LastName { get; set; } // "Johnson"
        public int AgeInYears { get; set; }  // 8
        public decimal CheckingAccountAmount { get; set; } // 2.53443256  2.53443256 2.58934267487936258973628462
        public float LocationX { get; set; } // 6453.859437
        public float LocationY { get; set; } // 597.324539827 -> 598.57843298
    }
}
