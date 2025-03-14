namespace MedicalAppointmentAPI.DTOs.Paginations
{
  /// <summary>
  /// Generic class for paginated results
  /// </summary>
  /// <typeparam name="T">Type of items in the result</typeparam>
  public class PaginationResult<T> where T : class
  {
    /// <summary>
    /// Current page number
    /// </summary>
    public int PageNumber { get; set; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// Total number of items
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// Total number of pages
    /// </summary>
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    /// <summary>
    /// Whether there is a previous page
    /// </summary>
    public bool HasPrevious => PageNumber > 1;

    /// <summary>
    /// Whether there is a next page
    /// </summary>
    public bool HasNext => PageNumber < TotalPages;

    /// <summary>
    /// List of items in the current page
    /// </summary>
    public List<T> Items { get; set; } = new List<T>();
  }
}