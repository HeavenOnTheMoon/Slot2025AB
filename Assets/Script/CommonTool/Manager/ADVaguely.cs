using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using com.adjust.sdk;

public class ADVaguely : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("MAX_SDK_KEY")]    public string MAX_SDK_KEY= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_REWARD_ID")]    public string MAX_REWARD_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_INTER_ID")]    public string MAX_INTER_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("isTest")]
    public bool BeMeal= false;
    public static ADVaguely Figurine{ get; private set; }

    private int JudgeThrough;   // 广告加载失败后，重新加载广告次数
    private bool BeAffrontDy;     // 是否正在播放广告，用于判断切换前后台时是否增加计数

    public int KillArchTheyCounter{ get; private set; }   // 距离上次广告的时间间隔
    public int counter101{ get; private set; }     // 定时插屏(101)计数器
    public int Earthen102{ get; private set; }     // NoThanks插屏(102)计数器
    public int Earthen103{ get; private set; }     // 后台回前台插屏(103)计数器

    private string SeniorVentureNeon;
    private Action<bool> SeniorMeltChopGreedy;    // 激励视频回调
    private bool SeniorToehold;     // 激励视频是否成功收到奖励
    private string SeniorMagic;     // 激励视频的打点

    private string ProlificallyVentureNeon;
    private int ProlificallyThus;      // 当前播放的插屏类型，101/102/103
    private string ProlificallyMagic;     // 插屏广告的的打点
    public bool ZebraTheyPostgraduate{ get; private set; } // 定时插屏暂停播放

    private List<Action<ADType>> UpViolentGrievance;    // 广告播放完成回调列表，用于其他系统广告计数（例如商店看广告任务）

    private long InformationWatchWaterside;     // 切后台时的时间戳

    private void Awake()
    {
        Figurine = this;
    }

    private void OnEnable()
    {
        ZebraTheyPostgraduate = false;
        BeAffrontDy = false;
        KillArchTheyCounter = 999;  // 初始时设置一个较大的值，不阻塞插屏广告
        SeniorToehold = false;

        // Android平台将Adjust的adid传给Max；iOS将randomKey传给Max
#if UNITY_ANDROID
        MaxSdk.SetSdkKey(LawCondorCopy.DecryptDES(MAX_SDK_KEY));
        // 将adjust id 传给Max
        string adjustId = GripCopyVaguely.GetString(CLazily.sv_AdjustAdid);
        if (string.IsNullOrEmpty(adjustId))
        {
            adjustId = Adjust.getAdid();
        }
        if (!string.IsNullOrEmpty(adjustId))
        {
            MaxSdk.SetUserId(adjustId);
            MaxSdk.InitializeSdk();
            GripCopyVaguely.SetString(CLazily.sv_AdjustAdid, adjustId);
        }
        else
        {
            StartCoroutine(setAdjustAdid());
        }
#else
        //MaxSdk.SetSdkKey(MAX_SDK_KEY);
        MaxSdk.SetSdkKey(LawCondorCopy.GeneralDES(MAX_SDK_KEY));
        MaxSdk.SetUserId(GripCopyVaguely.LawExcess(CLazily.Dy_BlameSlitHe));
        MaxSdk.InitializeSdk();
#endif

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {
            // 打开调试模式
            //MaxSdk.ShowMediationDebugger();

            ComparisonSkeletonJoy();
            MaxSdk.SetCreativeDebuggerEnabled(true);

            // 每秒执行一次计数
            InvokeRepeating(nameof(VanishSummer), 1, 1);
        };
    }

    private IEnumerator KeaCausalHoof()
    {
        int i = 0;
        while (i < 5)
        {
            yield return new WaitForSeconds(1);
            if (RetoolJean.MyForest())
            {
                MaxSdk.SetUserId(GripCopyVaguely.LawExcess(CLazily.Dy_BlameSlitHe));
                MaxSdk.InitializeSdk();
                yield break;
            }
            else
            {
                string adjustId = Adjust.getAdid();
                if (!string.IsNullOrEmpty(adjustId))
                {
                    MaxSdk.SetUserId(adjustId);
                    MaxSdk.InitializeSdk();
                    GripCopyVaguely.MadExcess(CLazily.Dy_CausalHoof, adjustId);
                    yield break;
                }
            }
            i++;
        }
        if (i == 5)
        {
            MaxSdk.SetUserId(GripCopyVaguely.LawExcess(CLazily.Dy_BlameSlitHe));
            MaxSdk.InitializeSdk();
        }
    }

    public void ComparisonSkeletonJoy()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnInterstitialRevenuePaidEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        // Load the first rewarded ad
        HoldSkeletonDy();

        // Load the first interstitial
        HoldPostgraduate();
    }

    private void HoldSkeletonDy()
    {
        MaxSdk.LoadRewardedAd(MAX_REWARD_ID);
    }

    private void HoldPostgraduate()
    {
        MaxSdk.LoadInterstitial(MAX_INTER_ID);
    }

    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.

        // Reset retry attempt
        JudgeThrough = 0;
        SeniorVentureNeon = adInfo.NetworkName;
    }

    private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        JudgeThrough++;
        double retryDelay = Math.Pow(2, Math.Min(6, JudgeThrough));

        Invoke(nameof(HoldSkeletonDy), (float)retryDelay);
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        GlobeYet.LawFigurine().BgGlobeOblige = !GlobeYet.LawFigurine().BgGlobeOblige;
        Time.timeScale = 0;
#endif
    }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        HoldSkeletonDy();
        BeAffrontDy = false;
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
    }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad
#if UNITY_IOS
        Time.timeScale = 1;
        GlobeYet.LawFigurine().BgGlobeOblige = !GlobeYet.LawFigurine().BgGlobeOblige;
#endif

        BeAffrontDy = false;
        HoldSkeletonDy();
        if (SeniorToehold)
        {
            SeniorToehold = false;
            SeniorMeltChopGreedy?.Invoke(true);

            ShaleDyArchToehold(ADType.Rewarded);
            PageBisonEmbryo.LawFigurine().SeatBison("9007", SeniorMagic);
        }
        else
        {
            SeniorMeltChopGreedy?.Invoke(false);
        }
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
        SeniorToehold = true;
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        // Ad revenue paid. Use this callback to track user revenue.
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        PageBisonEmbryo.LawFigurine().SeatBison("9008", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
        CausalWoolVaguely.Instance.RotDyWhale(countryCodeByMAX, info.Revenue);

        string adjustAdid = CausalWoolVaguely.Instance.LawCausalHoof();
        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(adjustAdid))
        {
            Adjust.trackAdRevenue(adRevenue);
            Debug.Log("Max to Adjust (rewarded), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            Debug.Log(nameof(MBridgeRevenueManager) + "~Rewarded revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is ready for you to show. MaxSdk.IsInterstitialReady(adUnitId) now returns 'true'

        // Reset retry attempt
        JudgeThrough = 0;
        ProlificallyVentureNeon = adInfo.NetworkName;
    }

    private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Interstitial ad failed to load
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)

        JudgeThrough++;
        double retryDelay = Math.Pow(2, Math.Min(6, JudgeThrough));

        Invoke(nameof(HoldPostgraduate), (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        GlobeYet.LawFigurine().BgGlobeOblige = !GlobeYet.LawFigurine().BgGlobeOblige;
        Time.timeScale = 0;
#endif
    }

    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad failed to display. AppLovin recommends that you load the next ad.
        HoldPostgraduate();
        BeAffrontDy = false;
    }

    private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    { }

    private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        PageBisonEmbryo.LawFigurine().SeatBison("9108", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
        CausalWoolVaguely.Instance.RotDyWhale(countryCodeByMAX, info.Revenue);

        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(CausalWoolVaguely.Instance.LawCausalHoof()))
        {
            Adjust.trackAdRevenue(adRevenue);
            Debug.Log("Max to Adjust (interstitial), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        string adjustAdid = CausalWoolVaguely.Instance.LawCausalHoof();
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            Debug.Log(nameof(MBridgeRevenueManager) + "~Interstitial revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is hidden. Pre-load the next ad.
#if UNITY_IOS
        Time.timeScale = 1;
        GlobeYet.LawFigurine().BgGlobeOblige = !GlobeYet.LawFigurine().BgGlobeOblige;
#endif
        HoldPostgraduate();

        ShaleDyArchToehold(ADType.Interstitial);
        PageBisonEmbryo.LawFigurine().SeatBison("9107", ProlificallyMagic);
    }

    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    /// <param name="callBack"></param>
    /// <param name="index"></param>
    public void HookMeadowAlike(Action<bool> callBack, string index)
    {
        if (BeMeal)
        {
            callBack(true);
            ShaleDyArchToehold(ADType.Rewarded);
            return;
        }

        bool rewardVideoReady = MaxSdk.IsRewardedAdReady(MAX_REWARD_ID);
        SeniorMeltChopGreedy = callBack;
        if (rewardVideoReady)
        {
            // 打点
            SeniorMagic = index;
            PageBisonEmbryo.LawFigurine().SeatBison("9002", index);
            BeAffrontDy = true;
            SeniorToehold = false;
            string placement = index + "_" + SeniorVentureNeon;
            MaxSdk.ShowRewardedAd(MAX_REWARD_ID, placement);
        }
        else
        {
            GropeVaguely.LawFigurine().FairGrope("No ads right now, please try it later.");
            SeniorMeltChopGreedy(false);
        }
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index"></param>
    public void HookPostgraduateDy(int index)
    {
        if (index == 101 || index == 102 || index == 103)
        {
            Debug.LogError("广告点位不允许为101、102、103");
            return;
        }

        HookPostgraduate(index);
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index">101/102/103</param>
    /// <param name="customIndex">用户自定义点位</param>
    private void HookPostgraduate(int index, int customIndex = 0)
    {
        ProlificallyThus = index;

        if (BeAffrontDy)
        {
            return;
        }

        // 当用户过关数 < trial_MaxNum时，不弹插屏广告
        int sv_trialNum = GripCopyVaguely.LawAid(CLazily.Dy_Up_trial_Wad);
        int trial_MaxNum = int.Parse(SpyLimeYet.instance.LazilyCopy.trial_MaxNum);
        if (sv_trialNum < trial_MaxNum)
        {
            return;
        }

        // 时间间隔低于阈值，不播放广告
        if (KillArchTheyCounter < int.Parse(SpyLimeYet.instance.LazilyCopy.inter_freq))
        {
            return;
        }

        if (BeMeal)
        {
            ShaleDyArchToehold(ADType.Interstitial);
            return;
        }

        bool interstitialVideoReady = MaxSdk.IsInterstitialReady(MAX_INTER_ID);
        if (interstitialVideoReady)
        {
            BeAffrontDy = true;
            // 打点
            string point = index.ToString();
            if (customIndex > 0)
            {
                point += customIndex.ToString().PadLeft(2, '0');
            }
            ProlificallyMagic = point;
            PageBisonEmbryo.LawFigurine().SeatBison("9102", point);
            string placement = point + "_" + ProlificallyVentureNeon;
            MaxSdk.ShowInterstitial(MAX_INTER_ID, placement);
        }
    }

    /// <summary>
    /// 每秒更新一次计数器 - 101计数器 和 时间间隔计数器
    /// </summary>
    private void VanishSummer()
    {
        KillArchTheyCounter++;

        int relax_interval = int.Parse(SpyLimeYet.instance.LazilyCopy.relax_interval);
        // 计时器阈值设置为0或负数时，关闭广告101；
        // 播放广告期间不计数；
        if (relax_interval <= 0 || BeAffrontDy)
        {
            return;
        }
        else
        {
            counter101++;
            if (counter101 >= relax_interval && !ZebraTheyPostgraduate)
            {
                HookPostgraduate(101);
            }
        }
    }

    /// <summary>
    /// NoThanks插屏 - 102
    /// </summary>
    public void WeVacuumRotWhale(int customIndex = 0)
    {
        // 用户行为累计次数计数器阈值设置为0或负数时，关闭广告102
        int nextlevel_interval = int.Parse(SpyLimeYet.instance.LazilyCopy.nextlevel_interval);
        if (nextlevel_interval <= 0)
        {
            return;
        }
        else
        {
            Earthen102 = GripCopyVaguely.LawAid("NoThanksCount") + 1;
            GripCopyVaguely.MadAid("NoThanksCount", Earthen102);
            if (Earthen102 >= nextlevel_interval)
            {
                HookPostgraduate(102, customIndex);
            }
        }
    }

    /// <summary>
    /// 前后台切换计数器 - 103
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            // 切回前台
            if (!BeAffrontDy)
            {
                // 前后台切换时，播放间隔计数器需要累加切到后台的时间
                if (InformationWatchWaterside > 0)
                {
                    KillArchTheyCounter += (int)(CanyJean.Predate() - InformationWatchWaterside);
                    InformationWatchWaterside = 0;
                }
                // 后台切回前台累计次数，后台配置为0或负数，关闭该广告
                int inter_b2f_count = int.Parse(SpyLimeYet.instance.LazilyCopy.inter_b2f_count);
                if (inter_b2f_count <= 0)
                {
                    return;
                }
                else
                {
                    Earthen103++;
                    if (Earthen103 >= inter_b2f_count)
                    {
                        HookPostgraduate(103);
                    }
                }
            }
        }
        else
        {
            // 切到后台
            InformationWatchWaterside = CanyJean.Predate();
        }
    }

    /// <summary>
    /// 暂停定时插屏播放 - 101
    /// </summary>
    public void WatchTheyPostgraduate()
    {
        ZebraTheyPostgraduate = true;
    }

    /// <summary>
    /// 恢复定时插屏播放 - 101
    /// </summary>
    public void RarityTheyPostgraduate()
    {
        ZebraTheyPostgraduate = false;
    }

    /// <summary>
    /// 更新游戏的TrialNum
    /// </summary>
    /// <param name="num"></param>
    public void TurkicExtraJob(int num)
    {
        GripCopyVaguely.MadAid(CLazily.Dy_Up_trial_Wad, num);
    }

    /// <summary>
    /// 注册看广告的回调事件
    /// </summary>
    /// <param name="callback"></param>
    public void AlphabetArchLiterate(Action<ADType> callback)
    {
        if (UpViolentGrievance == null)
        {
            UpViolentGrievance = new List<Action<ADType>>();
        }

        if (!UpViolentGrievance.Contains(callback))
        {
            UpViolentGrievance.Add(callback);
        }
    }

    /// <summary>
    /// 广告播放成功后，执行看广告回调事件
    /// </summary>
    private void ShaleDyArchToehold(ADType adType)
    {
        BeAffrontDy = false;
        // 播放间隔计数器清零
        KillArchTheyCounter = 0;
        // 插屏计数器清零
        if (adType == ADType.Interstitial)
        {
            // 计数器清零
            if (ProlificallyThus == 101)
            {
                counter101 = 0;
            }
            else if (ProlificallyThus == 102)
            {
                Earthen102 = 0;
                GripCopyVaguely.MadAid("NoThanksCount", 0);
            }
            else if (ProlificallyThus == 103)
            {
                Earthen103 = 0;
            }
        }

        // 看广告总数+1
        GripCopyVaguely.MadAid(CLazily.Dy_Large_Up_Wad + adType.ToString(), GripCopyVaguely.LawAid(CLazily.Dy_Large_Up_Wad + adType.ToString()) + 1);

        // 回调
        if (UpViolentGrievance != null && UpViolentGrievance.Count > 0)
        {
            foreach (Action<ADType> callback in UpViolentGrievance)
            {
                callback?.Invoke(adType);
            }
        }
    }

    /// <summary>
    /// 获取总的看广告次数
    /// </summary>
    /// <returns></returns>
    public int LawBuddyDyJob(ADType adType)
    {
        return GripCopyVaguely.LawAid(CLazily.Dy_Large_Up_Wad + adType.ToString());
    }
}

public enum ADType
{ Interstitial, Rewarded }