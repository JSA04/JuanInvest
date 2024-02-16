namespace Api.Domain;

public interface IServiceResult
{
    public int StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public DateTime ExecutedAt { get; set; }
} 

public class ServiceResult<T> : IServiceResult
{ 

    public ServiceResult(int StatusCode, string StatusMessage, T Data)
    {
        this.StatusCode = StatusCode;
        this.StatusMessage = StatusMessage;
        this.ExecutedAt = DateTime.UtcNow;
        this.Data = Data;
    }

    public int StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public DateTime ExecutedAt { get; set; }
    public T Data { get; set; }
}

public class ServiceResult : IServiceResult
{
    public ServiceResult(int StatusCode, string StatusMessage)
    {
        this.StatusCode = StatusCode;
        this.StatusMessage = StatusMessage;
        this.ExecutedAt = DateTime.UtcNow;
    }
    
    public int StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public DateTime ExecutedAt { get; set; }
}
