namespace Sculptor.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMapping")]
    public partial class UserMapping
    {
        public int UserMappingId { get; set; }

        public int? UserId { get; set; }

        public int? FatherId { get; set; }

        public int? MotherId { get; set; }

        public int? PartnerId { get; set; }

        public virtual UserMaster UserMaster { get; set; }
    }
}
