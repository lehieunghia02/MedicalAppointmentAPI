using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Seeding;

public static class ClinicSeeder
{
  public static void Seed(ModelBuilder builder)
  {
    builder.Entity<Clinic>().HasData(
        new Clinic
        {
          Id = 1,
          Name = "Phòng Khám Đa Khoa Quốc Tế",
          Description = "Phòng khám đa khoa với đội ngũ bác sĩ chuyên môn cao và trang thiết bị hiện đại",
          Address = "123 Nguyễn Văn Linh, Quận 7, TP.HCM",
          Phone = "028.7123.4567",
          Email = "contact@qte-clinic.com",
          Website = "https://qte-clinic.com",
          OpeningHours = "7:00 - 20:00",
          ImageUrl = "https://example.com/images/clinic1.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 2,
          Name = "Phòng Khám Sản Phụ Khoa Hạnh Phúc",
          Description = "Chuyên khoa sản phụ khoa với các dịch vụ chăm sóc toàn diện cho phụ nữ",
          Address = "456 Lê Văn Việt, Quận 9, TP.HCM",
          Phone = "028.7234.5678",
          Email = "info@hanhphuc-clinic.com",
          Website = "https://hanhphuc-clinic.com",
          OpeningHours = "7:30 - 19:30",
          ImageUrl = "https://example.com/images/clinic2.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 3,
          Name = "Phòng Khám Nhi Thiên Thần Nhỏ",
          Description = "Phòng khám chuyên khoa nhi với môi trường thân thiện cho trẻ em",
          Address = "789 Phan Văn Trị, Quận Gò Vấp, TP.HCM",
          Phone = "028.7345.6789",
          Email = "care@kids-clinic.com",
          Website = "https://kids-clinic.com",
          OpeningHours = "7:00 - 19:00",
          ImageUrl = "https://example.com/images/clinic3.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 4,
          Name = "Phòng Khám Tim Mạch Tâm Đức",
          Description = "Chuyên khoa tim mạch với các trang thiết bị chẩn đoán hiện đại",
          Address = "321 Võ Văn Ngân, TP.Thủ Đức, TP.HCM",
          Phone = "028.7456.7890",
          Email = "info@tamduc-cardio.com",
          Website = "https://tamduc-cardio.com",
          OpeningHours = "8:00 - 17:00",
          ImageUrl = "https://example.com/images/clinic4.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 5,
          Name = "Phòng Khám Mắt Ánh Sáng",
          Description = "Chuyên khoa mắt với các dịch vụ khám và điều trị về mắt",
          Address = "147 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM",
          Phone = "028.7567.8901",
          Email = "care@anhsang-eye.com",
          Website = "https://anhsang-eye.com",
          OpeningHours = "7:30 - 17:00",
          ImageUrl = "https://example.com/images/clinic5.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 6,
          Name = "Phòng Khám Răng Hàm Mặt Nụ Cười",
          Description = "Chăm sóc răng miệng toàn diện với công nghệ nha khoa tiên tiến",
          Address = "258 Cao Thắng, Quận 3, TP.HCM",
          Phone = "028.7678.9012",
          Email = "info@nucuoi-dental.com",
          Website = "https://nucuoi-dental.com",
          OpeningHours = "8:00 - 20:00",
          ImageUrl = "https://example.com/images/clinic6.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 7,
          Name = "Phòng Khám Đa Khoa Sức Khỏe",
          Description = "Phòng khám đa khoa với đầy đủ các chuyên khoa",
          Address = "369 Nguyễn Thị Minh Khai, Quận 1, TP.HCM",
          Phone = "028.7789.0123",
          Email = "contact@suckhoe-clinic.com",
          Website = "https://suckhoe-clinic.com",
          OpeningHours = "7:00 - 21:00",
          ImageUrl = "https://example.com/images/clinic7.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Clinic
        {
          Id = 8,
          Name = "Phòng Khám Cơ Xương Khớp Vận Động",
          Description = "Chuyên điều trị các bệnh lý về cơ xương khớp",
          Address = "486 Lê Quang Định, Quận Bình Thạnh, TP.HCM",
          Phone = "028.7890.1234",
          Email = "info@vandong-clinic.com",
          Website = "https://vandong-clinic.com",
          OpeningHours = "8:00 - 17:30",
          ImageUrl = "https://example.com/images/clinic8.jpg",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        }
    );
  }
}