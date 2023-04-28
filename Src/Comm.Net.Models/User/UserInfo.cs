namespace Comm.Net.Models.User;

public class UserInfo : IBaseOutput
{
    public decimal? USER_ID { get; set; }
    public string? USER_NAME { get; set; }
    public string? RESPONSIBILITY_NAME { get; set; }
    public DateTime? START_DATE { get; set; }
    public DateTime? END_DATE { get; set; }
    public string? RESPONSIBILITY_KEY { get; set; }
    public string? APPLICATION_SHORT_NAME { get; set; }
    public decimal? DEFAULT_OU { get; set; }
    public decimal? APPLICATION_ID { get; set; }
    public decimal? RESPONSIBILITY_ID { get; set; }
    public decimal? DEFAULT_GROUP_ID { get; set; }
    public decimal? DEFAULT_IO { get; set; }
}
