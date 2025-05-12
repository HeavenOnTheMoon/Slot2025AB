/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLazily
{
    #region 常量字段
    //登录url
    public const string LoginHow= "/api/client/user/getId?gameCode=";
    //配置url
    public const string LazilyHow= "/api/client/config?gameCode=";
    //时间戳url
    public const string TheyHow= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string CausalHow= "/api/client/user/setAdjustId?gameCode=";
    #endregion

    #region 本地存储的字符串
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string Dy_BlameSlitHe= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Dy_BlameMassifHe= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Dy_MyMixScanty= "sv_IsNewPlayer";

    //用户当前登录时间
    public const string Dy_SlitAlongCow= "sv_UserLoginDay";
    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Dy_DenseDramaLawWhale= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Dy_DenseDramaCany= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string Dy_MixSlitSpur= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Dy_VineHave= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Dy_SerigraphyVineHave= "sv_CumulativeGoldCoin";
    /// <summary>
    /// 钻石/现金余额
    /// </summary>
    public const string Dy_Bloom= "sv_Token";
    /// <summary>
    /// 累计钻石/现金总数
    /// </summary>
    public const string Dy_SerigraphyBloom= "sv_CumulativeToken";
    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Dy_Steppe= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Dy_SerigraphySteppe= "sv_CumulativeAmazon";
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Dy_BuddyFistThey= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Dy_FirstLawBloom= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Dy_HayFairCropCoach= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Dy_SerigraphyVicious= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Dy_CaptainSlumSacred= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Dy_MixSlitSpurShrine= "sv_NewUserStepFinish";
    public const string Dy_Jury_Civet_Tally= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string Dy_CoachFort= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Dy_CausalHoof= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Dy_Up_trial_Wad= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Dy_Large_Up_Wad= "sv_total_ad_num";
    
    //Soin点击次数
    public const string Dy_HerdWhale= "sv_SpinCount";
    //Spin总点击次数
    public const string Dy_HimHerdWhale= "sv_AllSpinCount";
    //spin每日点击次数
    public const string Dy_DenseHerdWhale= "sv_DailySpinCount";
    //每日补偿点击次数
    public const string Dy_DenseAdmittedlyWhale= "sv_DailyCompensateCount";
    
    //FreeSpin状态
    public const string Dy_WageHerdTowel= "sv_FreeSpinStage";
    //FreeSpin进度
    //public const string sv_FreeSpinSchedule = "sv_FreeSpinSchedule";
    //FreeSpin剩余次数
    public const string Dy_WageHerdWhale= "sv_FreeSpinCount";
    //FreeSpin本次积攒的金币数
    public const string Dy_WageHerdHave= "sv_FreeSpinCoin";
    //FreeSpin本次积攒的现金数
    public const string Dy_WageHerdHome= "sv_FreeSpinCash";
    //FreeSpin本次现金中奖次数
    public const string Dy_WageHerdLawHomeWhale= "sv_FreeSpinGetCashCount";
    
    //倒计时回复时间
    public const string Dy_HerdMoccasinThey= "sv_SpinRecomingTime";
    //这次获取的现金
    public const string Dy_ReapHomeWhale= "sv_OnceCashCount";
    //这次获取的金币
    public const string Dy_ReapHaveWhale= "sv_OnceCoinCount";
    //spin按钮的状态
    public const string Dy_HerdSeedy= "sv_SpinState";
    
    //777特有逻辑star存储数据
    public const string Dy_DoomTreat= "sv_starThree";
    public const string Dy_DoomArid= "sv_starFour";
    public const string Dy_DoomTen= "sv_starTen";
    //是否点击过Spin
    public const string Dy_MyMaybeHerd= "sv_IsClickSpin";
    //每日现金翻倍次数
    public const string Dy_DenseSummerHomeWhale= "sv_DailyDoubleCashCount";
    //换天
    public const string Dy_CowTemper= "sv_DayRecord";
    //Key数量
    public const string Dy_HueWhale= "sv_KeyCount";
    //key获得奖励页面奖励数量
    public const string Dy_MeadowHueWhale= "sv_RewardKeyCount";
    //钥匙页面看广告获得奖励次数啊
    public const string Dy_QuillHueADWhale= "sv_WatchKeyADCount";
    //Ring数量
    public const string Dy_SlabWhale= "sv_RingCount";
    //bottle数量
    public const string Dy_CornetWhale= "sv_BottleCount";
    //箱子奖励累心
    public const string Dy_ChaosThus= "sv_ChestType";
    //当前开箱数量
    public const string Dy_ChaosPredateWhale= "sv_ChestCurrentCount";
    //当前开的箱子
    public const string Dy_ChaosCMagic= "sv_ChestCIndex";
    //不同的奖励类型
    public const string Dy_ObligeMeadow= "sv_SwitchReward";
    //转轮奖励数值
    public const string Dy_RadarMeadow= "sv_WheelReward";
    //当天金币开启金猪次数
    public const string Dy_DenseTillSoHaveWhale= "sv_DailyOpenByCoinCount";
    //金猪进度
    public const string Dy_HaveHutTan= "sv_CoinPigSch";
    //金猪等级
    public const string Dy_HaveHutOrbit= "sv_CoinPigLevel";
    //开启金猪点击次数
    public const string Dy_TillHaveHutSoMaybe= "sv_OpenCoinPigByClick";
    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string It_SorrowTill= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string It_SorrowComic= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string It_ui_Industrialist= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string It_He_Jawbone= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string It_He_Atlantic= "mg_ui_addtoken";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string It_He_Shoemaker= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string It_FistNostril= "mg_GameSuspend";
    
    //老虎机剩余点击次数
    public static string It_HerdWhale= "mg_SpinCount";
    
    //开启FreeSpin
    public static string It_WageHerdStart= "mg_FreeSpinStart";

    //关闭FreeSpin
    public static string It_WageHerdHard= "mg_FreeSpinStop";

    //FreeSpin值发生变化
    public static string It_WageHerdAdultGather= "mg_FreeSpinValueChange";

    //显示页面
    public static string It_FairCoach= "mg_ShowPanel";
    //spin按钮状态改变
    public static string It_HerdItsSeedy= "mg_SpinBtnState";
    //滚动停止
    public static string It_FortHard= "mg_SlotStop";
    
    //停止播放老虎机连线动画
    public static string It_HardFortCity= "mg_StopSlotLine";
    //开始播放老虎机连线动画
    public static string It_DecayFortCity= "mg_StartSlotLine";
    //展示动画
    public static string It_FairEpidermis= "mg_ShowAnimation";
    
    //恢复Spin状态
    public static string It_ChillyHerdItsMaybe= "mg_RecoveSpinBtnClick";
    
    //Spin Scroll滚动完成
    public static string It_FortSierra_Paradigm= "mg_SlotScroll_Complete";
    //棋子特效动画
    public static string It_AdventEpidermis= "mg_EffectAnimation";
    //棋子特效动画完成后续
    public static string It_BoyAdventEpidermis= "mg_EndEffectAnimation";
    //获取钥匙奖励页面
    public static string It_LawHueMeadow= "mg_GetKeyReward";
    //获取bottle奖励页面
    public static string It_LawCornetMeadow= "mg_GetBottleReward";
    //控制金猪动画
    public static string It_CapableHaveHut= "mg_ControlCoinPig";
    
    
    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string Send_VineHave_During= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string Send_Bloom_During_Stormy= "Art/Tex/UI/jiangli4";

    #endregion
}

