using Microsoft.EntityFrameworkCore;
using Models;

namespace MedicalAppointmentAPI.Data.Seeding;

public static class WeekDaySeeder
{
  public static void Seed(ModelBuilder builder)
  {
    builder.Entity<WeekDay>().HasData(

        new WeekDay
        {
          Id = 1,
          Name = "Monday",
          ViName = "Thứ Hai",
          ShortName = "Mon",
          IsWeekend = false,
          IsActive = true,
          CreatedAt = DateTime.UtcNow
        },
        new WeekDay
        {
          Id = 2,
          Name = "Tuesday",
          ViName = "Thứ Ba",
          ShortName = "Tue",
          IsWeekend = false,
          IsActive = true,
          CreatedAt = DateTime.UtcNow
        },
        new WeekDay
        {
          Id = 3,
          Name = "Wednesday",
          ViName = "Thứ Tư",
          ShortName = "Wed",
          IsWeekend = false,
          IsActive = true,
          CreatedAt = DateTime.UtcNow
        },
            new WeekDay
            {
              Id = 4,
              Name = "Thursday",
              ViName = "Thứ Năm",
              ShortName = "Thu",
              IsWeekend = false,
              IsActive = true,
              CreatedAt = DateTime.UtcNow
            },
            new WeekDay
            {
              Id = 5,
              Name = "Friday",
              ViName = "Thứ Sáu",
              ShortName = "Fri",
              IsWeekend = false,
              IsActive = true,
              CreatedAt = DateTime.UtcNow
            },
            new WeekDay
            {
              Id = 6,
              Name = "Saturday",
              ViName = "Thứ Bảy",
              ShortName = "Sat",
              IsWeekend = true,
              IsActive = true,
              CreatedAt = DateTime.UtcNow
            },
            new WeekDay
            {
              Id = 7,
              Name = "Sunday",
              ViName = "Chủ Nhật",
              ShortName = "Sun",
              IsWeekend = true,
              IsActive = true,
              CreatedAt = DateTime.UtcNow
            }
    );
  }
}