namespace Sculptor.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CastMaster")]
    public partial class CastMaster
    {
        public CastMaster()
        {
            UserMasters = new HashSet<UserMaster>();
        }

        [Key]
        public int CastId { get; set; }

        [StringLength(50)]
        public string CastName { get; set; }

        public virtual ICollection<UserMaster> UserMasters { get; set; }
    }
}
