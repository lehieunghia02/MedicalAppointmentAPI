using System;
using System.Collections.Generic;

namespace MedicalAppointmentAPI.DTOs.Users
{
    /// <summary>
    /// DTO chứa thông tin người dùng
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// ID của người dùng
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Tên người dùng
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// Email của người dùng
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Số điện thoại của người dùng
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Họ của người dùng
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Tên của người dùng
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Tên đầy đủ của người dùng
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";
        
        /// <summary>
        /// Danh sách vai trò của người dùng
        /// </summary>
        public List<string> Roles { get; set; } = new List<string>();
        
        /// <summary>
        /// Trạng thái kích hoạt của người dùng
        /// </summary>
        public bool IsActive { get; set; }
        
        /// <summary>
        /// Ngày tạo tài khoản
        /// </summary>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// Ngày cập nhật tài khoản gần nhất
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }
        
        /// <summary>
        /// Ngày đăng nhập gần nhất
        /// </summary>
        public DateTime? LastLoginAt { get; set; }
    }
}