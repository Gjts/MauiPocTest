namespace Comm.Net.Models;

public class DialogModel
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 弹出提示框
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// 按钮文本
    /// </summary>
    public string ButtonLabel { get; set; }

    /// <summary>
    /// 确认按钮文本
    /// </summary>
    public string AcceptButtonLabel { get; set; }

    /// <summary>
    /// 取消按钮文本
    /// </summary>
    public string CancelButtonLabel { get; set; }

}
