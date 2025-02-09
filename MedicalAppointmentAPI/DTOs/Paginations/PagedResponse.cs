namespace DTOs.Paginations;

public class PagedResponse<T>
{
  public IEnumerable<T> Data { get; }
  public int PageNumber { get; }
  public int PageSize { get; }
  public int TotalPages { get; }
  public int TotalRecords { get; }
  public bool HasPrevious => PageNumber > 1;
  public bool HasNext => PageNumber < TotalPages;

  public PagedResponse(IEnumerable<T> data,
        int pageNumber,
        int pageSize,
        int totalRecords)
  {
    Data = data;
    PageNumber = pageNumber;
    PageSize = pageSize;
    TotalRecords = totalRecords;
    TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
  }
  public object GetMetadata()
  {
    return new
    {
      TotalPages,
      PageNumber,
      PageSize,
      TotalRecords,
      HasNext,
      HasPrevious
    };
  }


}