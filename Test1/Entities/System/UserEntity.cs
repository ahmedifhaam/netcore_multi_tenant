using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Entities.System
{
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [MaxLength(100)]
        public string Passwordd { get; set; }



        public ClientEntity ClientEntity { get; set; }

        public int ClientEntityId {get;set;}
    }
}
