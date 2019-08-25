using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models.System
{
    public class ClientDto
    {
        
        public int ClientId { get; set; }
      
        public string ClientName { get; set; }        

        public string Server { get; set; }

        public string DatabaseName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
