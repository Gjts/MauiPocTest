using Comm.Net.Models;

namespace MauiPocUnit;

public class DialogService : IDialogService
{
    /// <summary>
    /// 弹出提示框
    /// </summary>
    /// <param name="dialog">提示内容</param>
    /// <returns></returns>
    public async Task ShowAlert(DialogModel dialog)
    {
        await Application.Current.MainPage.DisplayAlert(dialog.Title, dialog.Message, dialog.ButtonLabel);
    }

    /// <summary>
    /// 弹出确认框
    /// </summary>
    /// <param name="dialog">确认内容</param>
    /// <returns>选择确认或者取消</returns>
    public async Task<bool> ShowConfirm(DialogModel dialog)
    {
        return await Application.Current.MainPage.DisplayAlert(dialog.Title, dialog.Message, dialog.AcceptButtonLabel, dialog.CancelButtonLabel);
    }
}
