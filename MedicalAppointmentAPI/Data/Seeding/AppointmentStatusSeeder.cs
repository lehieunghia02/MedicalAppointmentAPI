using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Seeding;
public class AppointmentStatusSeeder
{
  public static void Seed(ModelBuilder builder)
  {

    builder.Entity<AppointmentStatus>().HasData(
    new AppointmentStatus
    {
      Id = 1,
      Name = "Đã đặt lịch",
      Description = "Trạng thái đã đặt lịch",
      IsActive = true,
      CreatedAt = DateTime.UtcNow,
      UpdatedAt = DateTime.UtcNow
    },
    new AppointmentStatus
    {
      Id = 2,
      Name = "Đã xác nhận",
      Description = "Trạng thái đã được xác nhận",
      IsActive = true,
      CreatedAt = DateTime.UtcNow,
      UpdatedAt = DateTime.UtcNow
    },
    new AppointmentStatus
    {
      Id = 3,
      Name = "Đã hoàn thành",
      Description = "Trạng thái đã hoàn thành",
      IsActive = true,
      CreatedAt = DateTime.UtcNow,
      UpdatedAt = DateTime.UtcNow
    },
    new AppointmentStatus
    {
      Id = 4,
      Name = "Hủy bỏ",
      Description = "Trạng thái đã hủy bỏ",
      IsActive = true,
      CreatedAt = DateTime.UtcNow,
      UpdatedAt = DateTime.UtcNow
    },
    new AppointmentStatus
    {
      Id = 5,
      Name = "Không đúng hẹn",
      Description = "Trạng thái không đúng hẹn",
      IsActive = true,
      CreatedAt = DateTime.UtcNow,
      UpdatedAt = DateTime.UtcNow
    });
  }
}