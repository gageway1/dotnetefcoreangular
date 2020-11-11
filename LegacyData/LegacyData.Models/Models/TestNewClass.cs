using LegacyData.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LegacyData.Models.Models
{
    //ADD YOUR TABLE NAME TO THE TABLE DECORATOR
    [Table("TestNewClass", Schema = "LegacyData")]
    public class TestNewClass : EntityBase // INHERIT FROM ENTITYBASE
    {
        public string Name { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
