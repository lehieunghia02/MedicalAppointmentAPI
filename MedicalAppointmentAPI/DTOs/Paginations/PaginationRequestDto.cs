namespace MedicalAppointmentAPI.DTOs.Paginations
{
  /// <summary>
  /// Base DTO for pagination requests
  /// </summary>
  public class PaginationRequestDto
  {
    private int _pageNumber = 1;
    private int _pageSize = 10;

    /// <summary>
    /// Page number (1-based)
    /// </summary>
    public int PageNumber
    {
      get => _pageNumber;
      set => _pageNumber = value < 1 ? 1 : value;
    }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int PageSize
    {
      get => _pageSize;
      set => _pageSize = value < 1 ? 10 : (value > 100 ? 100 : value);
    }

    /// <summary>
    /// Property to sort by
    /// </summary>
    public string SortBy { get; set; } = "Id";

    /// <summary>
    /// Sort direction (asc or desc)
    /// </summary>
    public string SortDirection { get; set; } = "asc";
  }
}