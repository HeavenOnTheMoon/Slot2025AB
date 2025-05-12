using System;
using System.Collections;
using com.adjust.sdk;
using LitJson;
using UnityEngine;
using Random = UnityEngine.Random;

public class CausalWoolVaguely : MonoBehaviour
{
    public static CausalWoolVaguely Instance;
[UnityEngine.Serialization.FormerlySerializedAs("adjustID")]
    public string UnevenID;     // 由遇总的打包工具统一修改，无需手动配置

    //用户adjust 状态KEY
    private string sv_ADMayaWoolThus= "sv_ADJustInitType";

    //adjust 时间戳
    private string Dy_ADMayaThey= "sv_ADJustTime";

    //adjust行为计数器
    public int _BluefinWhale{ get; private set; }

    public double _BluefinDeceive{ get; private set; }

    double UnevenWoolDyDeceive= 0;


    private void Awake()
    {
        Instance = this;
        GripCopyVaguely.MadExcess(Dy_ADMayaThey, CanyJean.Predate().ToString());

#if UNITY_IOS
        GripCopyVaguely.MadExcess(sv_ADMayaWoolThus, AdjustStatus.OpenAsAct.ToString());
        CausalWool();
#endif
    }

    private void Start()
    {
        _BluefinWhale = 0;
    }


    void CausalWool()
    {
#if UNITY_EDITOR
        return;
#endif
        AdjustConfig adjustConfig = new AdjustConfig(UnevenID, AdjustEnvironment.Production, false);
        adjustConfig.setLogLevel(AdjustLogLevel.Verbose);
        adjustConfig.setSendInBackground(false);
        adjustConfig.setEventBufferingEnabled(false);
        adjustConfig.setLaunchDeferredDeeplink(true);
        Adjust.start(adjustConfig);

        StartCoroutine(GripCausalHoof());
    }

    private IEnumerator GripCausalHoof()
    {
        while (true)
        {
            string adjustAdid = Adjust.getAdid();
            if (string.IsNullOrEmpty(adjustAdid))
            {
                yield return new WaitForSeconds(5);
            }
            else
            {
                GripCopyVaguely.MadExcess(CLazily.Dy_CausalHoof, adjustAdid);
                SpyLimeYet.instance.SeatCausalHoof();
                yield break;
            }
        }
    }

    public string LawCausalHoof()
    {
        return GripCopyVaguely.LawExcess(CLazily.Dy_CausalHoof);
    }

    /// <summary>
    /// 获取adjust初始化状态
    /// </summary>
    /// <returns></returns>
    public string LawCausalOccupy()
    {
        return GripCopyVaguely.LawExcess(sv_ADMayaWoolThus);
    }

    /*
     *  API
     *  Adjust 初始化
     */
    public void WoolCausalCopy(bool isOldUser = false)
    {
#if UNITY_IOS
            return;
#endif
        // 如果后台配置的adjust_init_act_position <= 0，直接初始化
        if (string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.adjust_init_act_position) || int.Parse(SpyLimeYet.instance.LazilyCopy.adjust_init_act_position) <= 0)
        {
            GripCopyVaguely.MadExcess(sv_ADMayaWoolThus, AdjustStatus.OpenAsAct.ToString());
        }
        print(" user init adjust by status :" + GripCopyVaguely.LawExcess(sv_ADMayaWoolThus));
        //用户二次登录 根据标签初始化
        if (GripCopyVaguely.LawExcess(sv_ADMayaWoolThus) == AdjustStatus.OldUser.ToString() || GripCopyVaguely.LawExcess(sv_ADMayaWoolThus) == AdjustStatus.OpenAsAct.ToString())
        {
            print("second login  and  init adjust");
            CausalWool();
        }
    }



    /*
     * API
     *  记录行为累计次数
     *  @param2 打点参数
     */
    public void RotSewWhale(string param2 = "")
    {
#if UNITY_IOS
            return;
#endif
        if (GripCopyVaguely.LawExcess(sv_ADMayaWoolThus) != "") return;
        _BluefinWhale++;
        print(" add up to :" + _BluefinWhale);
        if (string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.adjust_init_act_position) || _BluefinWhale == int.Parse(SpyLimeYet.instance.LazilyCopy.adjust_init_act_position))
        {
            HoldCausalIDSew(param2);
        }
    }

    /// <summary>
    /// 记录广告行为累计次数，带广告收入
    /// </summary>
    /// <param name="countryCode"></param>
    /// <param name="revenue"></param>
    public void RotDyWhale(string countryCode, double revenue)
    {
#if UNITY_IOS
            return;
#endif
        //if (GripCopyVaguely.GetString(sv_ADJustInitType) != "") return;

        _BluefinWhale++;
        _BluefinDeceive += revenue;
        print(" Ads count: " + _BluefinWhale + ", Revenue sum: " + _BluefinDeceive);

        //如果后台有adjust_init_adrevenue数据 且 能找到匹配的countryCode，初始化adjustInitAdRevenue
        if (!string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.adjust_init_adrevenue))
        {
            JsonData jd = JsonMapper.ToObject(SpyLimeYet.instance.LazilyCopy.adjust_init_adrevenue);
            if (jd.ContainsKey(countryCode))
            {
                UnevenWoolDyDeceive = double.Parse(jd[countryCode].ToString(), new System.Globalization.CultureInfo("en-US"));
            }
        }

        if (
            string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.adjust_init_act_position)                   //后台没有配置限制条件，直接走LoadAdjust
            || (_BluefinWhale == int.Parse(SpyLimeYet.instance.LazilyCopy.adjust_init_act_position)         //累计广告次数满足adjust_init_act_position条件，且累计广告收入满足adjust_init_adrevenue条件，走LoadAdjust
                && _BluefinDeceive >= UnevenWoolDyDeceive)
        )
        {
            HoldCausalIDSew();
        }
    }

    /*
     * API
     * 根据行为 初始化 adjust
     *  @param2 打点参数 
     */
    public void HoldCausalIDSew(string param2 = "")
    {
        if (GripCopyVaguely.LawExcess(sv_ADMayaWoolThus) != "") return;

        // 根据比例分流   adjust_init_rate_act  行为比例
        if (string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.adjust_init_rate_act) || int.Parse(SpyLimeYet.instance.LazilyCopy.adjust_init_rate_act) > Random.Range(0, 100))
        {
            print("user finish  act  and  init adjust");
            GripCopyVaguely.MadExcess(sv_ADMayaWoolThus, AdjustStatus.OpenAsAct.ToString());
            CausalWool();

            // 上报点位 新用户达成 且 初始化
            PageBisonEmbryo.LawFigurine().SeatBison("1091", LawCausalThey(), param2);
        }
        else
        {
            print("user finish  act  and  not init adjust");
            GripCopyVaguely.MadExcess(sv_ADMayaWoolThus, AdjustStatus.CloseAsAct.ToString());
            // 上报点位 新用户达成 且  不初始化
            PageBisonEmbryo.LawFigurine().SeatBison("1092", LawCausalThey(), param2);
        }
    }


    /*
     * API
     *  重置当前次数
     */
    public void RadioSewWhale()
    {
        print("clear current ");
        _BluefinWhale = 0;
    }


    // 获取启动时间
    private string LawCausalThey()
    {
        return CanyJean.Predate() - long.Parse(GripCopyVaguely.LawExcess(Dy_ADMayaThey)) + "";
    }
}


/*
 *@param
 *  OldUser     老用户
 *  OpenAsAct   行为触发且初始化
 *  CloseAsAct  行为触发不初始化
 */
public enum AdjustStatus
{
    OldUser,
    OpenAsAct,
    CloseAsAct
}