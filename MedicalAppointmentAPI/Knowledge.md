<!-- Doctor Management API -->
1. API Quản lý Người dùng
   GetAllUsers: Lấy danh sách tất cả người dùng với phân trang
   GetUserById: Lấy thông tin chi tiết của một người dùng
   CreateUser: Tạo người dùng mới
   UpdateUser: Cập nhật thông tin người dùng
   DeleteUser: Xóa người dùng
2. API Quản lý Vai trò
   GetAllRoles: Lấy danh sách tất cả vai trò
   GetRoleById: Lấy thông tin chi tiết của một vai trò
   CreateRole: Tạo vai trò mới
   UpdateRole: Cập nhật thông tin vai trò
   DeleteRole: Xóa vai trò
   AssignRoleToUser: Gán vai trò cho người dùng
   RemoveRoleFromUser: Xóa vai trò khỏi người dùng
3. API Quản lý Hệ thống
   GetSystemLogs: Lấy nhật ký hệ thống
   GetSystemStats: Lấy thống kê hệ thống
   CreateBackup: Tạo bản sao lưu dữ liệu
   RestoreFromBackup: Khôi phục dữ liệu từ bản sao lưu
   GetSystemConfig: Lấy cấu hình hệ thống
   UpdateSystemConfig: Cập nhật cấu hình hệ thống
4. API Quản lý Cuộc hẹn
   GetAllAppointments: Lấy tất cả cuộc hẹn với khả năng lọc
   GetAppointmentById: Lấy thông tin chi tiết của một cuộc hẹn
   CreateAppointment: Tạo cuộc hẹn mới (sử dụng CreateAppointmentDto)
   UpdateAppointment: Cập nhật thông tin cuộc hẹn
   DeleteAppointment: Xóa cuộc hẹn
   GetAppointmentStats: Lấy thống kê về cuộc hẹn