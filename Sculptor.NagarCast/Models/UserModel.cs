using Sculptor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sculptor.NagarCast.Models
{
    public class UserModel
    {
        public UserModel()
        {
            AddressMaster = new AddressMaster();
            CastMaster = new CastMaster();
        }
        
        public int UserId { get; set; }
        
        public string Name { get; set; }

        public int AddressId { get; set; }

        public int CastMasterId { get; set; }

        public string Education { get; set; }

        public string Village { get; set; }

        public int Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime? BirthTime { get; set; }

        public bool WorkStatus { get; set; }
        
        public string WorkDetail { get; set; }
        
        public string Image { get; set; }

        public bool LiveStatus { get; set; }

        public DateTime? DeathDate { get; set; }

        public DateTime? DeathTime { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public AddressMaster AddressMaster { get; set; }

        public CastMaster CastMaster { get; set; }        
        
    }
}