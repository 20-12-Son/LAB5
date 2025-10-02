using System;
using System.ComponentModel.DataAnnotations;

namespace LAB5.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên bắt buộc nhập")]
        [StringLength(50, ErrorMessage = "Họ tên tối đa 50 ký tự")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email bắt buộc nhập")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại bắt buộc nhập")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [StringLength(100, ErrorMessage = "Địa chỉ tối đa 100 ký tự")]
        public string Address { get; set; }

        [DataType(DataType.ImageUrl, ErrorMessage = "Link ảnh không hợp lệ")]
        public string Avatar { get; set; }

        [Required(ErrorMessage = "Ngày sinh bắt buộc nhập")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Giới tính bắt buộc nhập")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Mật khẩu bắt buộc nhập")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Mật khẩu từ 6-20 ký tự")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Url(ErrorMessage = "Địa chỉ Facebook không hợp lệ")]
        public string Facebook { get; set; }
    }
}
