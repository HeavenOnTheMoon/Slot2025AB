// 商店数据
using System.Collections.Generic;

public class ShopJson
{
    public string email;
    public int cash_withdraw_time { get; set; }
    public int cash_withdraw_type { get; set; }
    public CheckoutCondition[] cash_checkout_conditions { get; set; }
    public CheckoutTask[] cash_checkout_tasks { get; set; }
    public VineThough[] withdraw_group { get; set; }
    public HimThough[] allWithdraw_group { get; set; }
    public Seeker[] puzzle_shop_group { get; set; }
    public Dictionary<string, double> puzzle_multi_group { get; set; }
}