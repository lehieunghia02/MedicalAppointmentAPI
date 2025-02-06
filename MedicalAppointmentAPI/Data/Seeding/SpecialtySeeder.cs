using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Seeding;
public static class SpecialtySeeder
{
  public static void Seed(ModelBuilder builder)
  {
    builder.Entity<Specialty>().HasData(
        new Specialty
        {
          Id = 1,
          Name = "Nội Tổng Quát",
          Description = "Khám và điều trị các bệnh lý nội khoa tổng quát",
          IsActive = true,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
            new Specialty
            {
              Id = 2,
              Name = "Tim Mạch",
              Description = "Chẩn đoán và điều trị các bệnh về tim mạch",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 3,
              Name = "Thần Kinh",
              Description = "Khám và điều trị các bệnh về hệ thần kinh",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 4,
              Name = "Nhi Khoa",
              Description = "Chăm sóc sức khỏe trẻ em từ sơ sinh đến 15 tuổi",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 5,
              Name = "Sản Phụ Khoa",
              Description = "Chăm sóc sức khỏe phụ nữ và thai sản",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 6,
              Name = "Tai Mũi Họng",
              Description = "Khám và điều trị các bệnh về tai, mũi, họng",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 7,
              Name = "Mắt",
              Description = "Khám và điều trị các bệnh về mắt",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 8,
              Name = "Da Liễu",
              Description = "Khám và điều trị các bệnh về da",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 9,
              Name = "Cơ Xương Khớp",
              Description = "Khám và điều trị các bệnh về xương khớp",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 10,
              Name = "Tiêu Hóa",
              Description = "Khám và điều trị các bệnh về đường tiêu hóa",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 11,
              Name = "Hô Hấp",
              Description = "Khám và điều trị các bệnh về đường hô hấp",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            },
            new Specialty
            {
              Id = 12,
              Name = "Nội Tiết",
              Description = "Khám và điều trị các bệnh về nội tiết, đái tháo đường",
              IsActive = true,
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow
            }
    );
  }
}