namespace Common.Models.Pagination;

public class PaginationParams
{
  private int _pageSize = 10;
  private int _pageNumber = 1;
  private const int MaxPageSize = 50; // Maximum page size 
  // Method to get page number
  public int PageNumber
  {
    get => _pageNumber;
    set => _pageNumber = value < 1 ? 1 : value;
  }
  //Method to get page size

  public int PageSize
  {
    get => _pageSize;
    set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
  }
  public string? SortBy { get; set; }
  public bool IsDescending { get; set; }
}