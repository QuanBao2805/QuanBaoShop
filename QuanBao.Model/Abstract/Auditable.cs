using System;
using System.ComponentModel.DataAnnotations;

namespace QuanBao.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CraetedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyWord {get; set; }
        
        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }

    }
}
