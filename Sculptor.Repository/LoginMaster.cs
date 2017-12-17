namespace Sculptor.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginMaster")]
    public partial class LoginMaster
    {
        [Key]
        public int LoginId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public string Sque { get; set; }

        public string Sans { get; set; }

        [StringLength(100)]
        public string OldPass { get; set; }

        public bool? ChangePass { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public virtual UserMaster UserMaster { get; set; }
    }
}
