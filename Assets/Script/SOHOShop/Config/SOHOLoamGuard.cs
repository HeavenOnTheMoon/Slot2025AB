using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHOLoamGuard
{
    #region 本地存储的字符串
    /// <summary>
    /// 碎片
    /// </summary>
    public const string Dy_Seeker= "sv_Puzzle";
    /// <summary>
    /// 金币 Amazon
    /// </summary>
    public const string Dy_VineSteppeTolerant= "sv_GoldAmazonWithdraw";
    /// <summary>
    /// 三种提现（特殊逻辑）
    /// </summary>
    public const string Dy_HimTolerant= "sv_AllWithdraw";
    /// <summary>
    /// 特殊提现排名
    /// </summary>
    public const string Dy_HimLongerTolerant= "sv_AllWaitngWithdraw";
    /// <summary>
    /// 现金提现记录
    /// </summary>
    public const string Dy_HomeTolerantHart= "sv_CashWithdrawList";
    /// <summary>
    /// 当前现金提现累计余额
    /// </summary>
    public const string Dy_HomeTolerantPrimacy= "sv_CashWithdrawBalance";
    /// <summary>
    /// 用户账户
    /// </summary>
    public const string Dy_SlitJanuary= "sv_UserAccount";
    public const string Dy_GannetNeon= "sv_PersonName";
    public const string Dy_GannetUniform= "sv_PersonAddress";
    public const string Dy_GannetRoe= "sv_PersonTel";
    /// <summary>
    /// 游戏初次激活时间
    /// </summary>
    public const string Dy_WoolParadox= "sv_InitSeconds";
    #endregion

    #region 监听发送的消息
    /// <summary>
    /// 刷新现金提现列表
    /// </summary>
    public const string It_BroadenHomeTolerantHart= "mg_RefreshCashWithdrawList";
    /// <summary>
    /// 刷新现金提现用户账户
    /// </summary>
    public const string It_BroadenHomeTolerantSlitJanuary= "mg_RefreshCashWithdrawUserAccount";
    /// <summary>
    /// 展示/收起提现详情时，修改高度
    /// </summary>
    public const string It_BroadenHomeTolerantCobalt= "mg_RefreshCashWithdrawHeight";
    /// <summary>
    /// 刷新金币、Amazon列表
    /// </summary>
    public const string It_BroadenVineSteppeTolerantHart= "mg_RefreshGoldAmazonWithdrawList";
    /// <summary>
    /// 刷新All列表
    /// </summary>
    public const string It_BroadenHimTolerantHart= "mg_RefreshAllWithdrawList";
    /// <summary>
    /// 刷新现金提现倒计时
    /// </summary>
    public const string It_BroadenAuthority= "mg_RefreshCountdown";
    /// <summary>
    /// 现金商店引导
    /// </summary>
    public static string It_FairHomeLoamLung= "mg_ShowCashShopHand";

    /// <summary>
    /// 历史记录
    /// </summary>
    public static string It_SOHOTemperHart= "mg_SOHORecordList";


    #endregion
}
