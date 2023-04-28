using Comm.Net.Models;

namespace MauiPocUnit;

public interface IDialogService
{
    /// <summary>
    /// 弹出提示框
    /// </summary>
    /// <param name="dialog">提示内容</param>
    /// <returns></returns>
    Task ShowAlert(DialogModel dialog);

    /// <summary>
    /// 弹出确认框
    /// </summary>
    /// <param name="dialog">确认内容</param>
    /// <returns>选择确认或者取消</returns>
    Task<bool> ShowConfirm(DialogModel dialog);
}
