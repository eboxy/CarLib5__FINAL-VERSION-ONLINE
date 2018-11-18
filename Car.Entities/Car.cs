using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entities
{
    
    [DataContract]
    public class Car
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public int Year { get; set; }
    }
}
