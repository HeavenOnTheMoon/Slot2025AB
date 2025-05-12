/// <summary>
/// 提现任务
/// </summary>
public class CheckoutTask
{
    public string type;
    public double task_num;
    public double value;
    public string desc;

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}