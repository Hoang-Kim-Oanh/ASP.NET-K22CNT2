using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HKOBaiThiGiuaKy.Models
{
    public class HkoCustomer
    {
        [Required(ErrorMessage = "Hãy nhập mã số")]
        public long HkoId { get; set; }

        [Required(ErrorMessage = "Hãy nhập họ tên")]
        [RegularExpression(@"^[A-Za-z\s]{2,30}$", ErrorMessage = "Họ tên chỉ chứa ký tự A-Z a-z và khoảng trắng, tối thiểu 2 ký tự, tối đa 30 ký tự")]
        public string HkoFullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập Email")]
        [EmailAddress(ErrorMessage = "Email phải đúng định dạng")]
        public string HkoEmail { get; set; }

        [Required(ErrorMessage = "Hãy nhập điện thoại")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Điện thoại phải có 10 ký tự số")]
        public string HkoPhone { get; set; }

        [Required(ErrorMessage = "Hãy nhập tuổi")]
        [Range(18, 65, ErrorMessage = "Tuổi phải trong phạm vi từ 18 đến 65")]
        public int HkoAge { get; set; }

        [Required(ErrorMessage = "Hãy nhập giới tính")]
        [RegularExpression(@"^[01]$", ErrorMessage = "Giới tính chỉ chứa 1 ký tự là 0 hoặc 1")]
        public int HkoGender { get; set; }
    }
}
