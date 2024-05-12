namespace WS_Tracking.Model;

public class Pagination<T>
{
    public List<T> Data { get; set; }
    public int TotalCount { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }

    public Pagination(List<T> data, int totalCount, int pageIndex, int pageSize)
    {
        Data = data;
        TotalCount = totalCount;
        PageIndex = pageIndex;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
    }

    public bool HasPreviousPage => PageIndex > 0;
    public bool HasNextPage => PageIndex < TotalPages - 1;
}

