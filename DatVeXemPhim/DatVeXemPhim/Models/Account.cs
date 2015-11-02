using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatVeXemPhim.Models
{
    public class Account
    {
        public int ID { get; set; }
        // Tên người dùng
        public string UserName { get; set; }
        // Mật khẩu
        public string PassWord { get; set; }
        // Họ và tên người dùng
        public string FullName { get; set; }
        // Địa chỉ email
        public string Email { get; set; }
        // Giới tính
        public int Gender { get; set; }
        // Ngày sinh
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Birthday { get; set; }
        // Địa chỉ
        public string Address { get; set; }
        // Số điện thoại
        public string PhoneNumber { get; set; }
        // Avatar
        public int AvatarID { get; set; }
        // Quyền người dùng
        public int RoleID { get; set; }


    }
}