namespace Sculptor.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMaster")]
    public partial class UserMaster
    {
        public UserMaster()
        {
            LoginMasters = new HashSet<LoginMaster>();
            UserMappings = new HashSet<UserMapping>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int AddressId { get; set; }

        public int CastMasterId { get; set; }

        public string Education { get; set; }

        public string Village { get; set; }

        public int Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime? BirthTime { get; set; }

        public bool WorkStatus { get; set; }

        [StringLength(200)]
        public string WorkDetail { get; set; }

        [StringLength(30)]
        public string Image { get; set; }

        public bool LiveStatus { get; set; }

        public DateTime? DeathDate { get; set; }

        public DateTime? DeathTime { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public virtual AddressMaster AddressMaster { get; set; }

        public virtual CastMaster CastMaster { get; set; }

        public virtual ICollection<LoginMaster> LoginMasters { get; set; }

        public virtual ICollection<UserMapping> UserMappings { get; set; }
    }
}
