using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    //Lớp ảo hóa triển khai interface IAuditable
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]        //Xác định độ dài tối đa của chuỗi
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]        //Xác định độ dài tối đa của chuỗi
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}