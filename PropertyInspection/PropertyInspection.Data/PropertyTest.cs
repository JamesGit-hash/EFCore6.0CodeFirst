using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PropertyInspection.Data
{
    [Table("Property")]
    public class PropertyTest
    {
        [Key]
        public int PropertyKey { get; set; }

        [ForeignKey("Agent")]
        public int AgentRefId { get; set; }
        public Agent Agent { get; set; }

        [Column("Address")]
        public string StreetAddress { get; set; }

        [MaxLength(50)]
        public string OwnerName { get; set; }

        public int PostCode { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
