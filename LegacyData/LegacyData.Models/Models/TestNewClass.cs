using LegacyData.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LegacyData.Models.Models
{
    [Table("TestNewClass", Schema = "LegacyData")]
    public class TestNewClass : EntityBase
    {
        public string Name { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
