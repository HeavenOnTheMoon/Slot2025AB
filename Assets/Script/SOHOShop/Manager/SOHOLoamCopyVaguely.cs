using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHOLoamCopyVaguely : MonoBehaviour
{
    public static SOHOLoamCopyVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("shopJson")]
    public ShopJson DrabJson;
[UnityEngine.Serialization.FormerlySerializedAs("currentUserAccount")]
    public SlitJanuary BluefinSlitJanuary;     // 当前用户账户
    // 用户地址
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PersonName")]    public string GannetNeon;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PersonAddress")]    public string GannetUniform;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PersonTel")]    public string GannetRoe;
[UnityEngine.Serialization.FormerlySerializedAs("staticCashoutTaskValues")]
    // 静态提现任务的值
    public Dictionary<string, double> BeaverWarblerPestAbrupt;


    private void Awake()
    {
        instance = this;
    }

    public void WoolLoamCopy()
    {
        if (SpyLimeYet.instance.LazilyCopy.soho_shop != null)
        {
            //  shopJson = JsonMapper.ToObject<ShopJson>(SpyLimeYet.instance.ConfigData.soho_shop);
            switch (I2.Loc.LocalizationManager.CurrentLanguage)
            {
                case "Russian":
                    DrabJson = JsonMapper.ToObject<ShopJson>(SpyLimeYet.instance.LazilyCopy.soho_shop_ru);
                    break;
                case "Portuguese (Brazil)":
                    DrabJson = JsonMapper.ToObject<ShopJson>(SpyLimeYet.instance.LazilyCopy.soho_shop_br);
                    break;
                case "Japanese":
                    DrabJson = JsonMapper.ToObject<ShopJson>(SpyLimeYet.instance.LazilyCopy.soho_shop_jp);
                    break;
                case "English":
                    DrabJson = JsonMapper.ToObject<ShopJson>(SpyLimeYet.instance.LazilyCopy.soho_shop_us);
                    break;
                default:
                    DrabJson = JsonMapper.ToObject<ShopJson>(SpyLimeYet.instance.LazilyCopy.soho_shop);
                    break;
            }
        }
        else
        {
            TextAsset json = Resources.Load<TextAsset>("SOHOShop/LocationJson/ShopJson");
            DrabJson = JsonMapper.ToObject<ShopJson>(json.text);
        }
        if (DrabJson.cash_checkout_conditions != null && DrabJson.cash_checkout_conditions.Length > 0)
        {
            for (int i = 0; i < DrabJson.cash_checkout_conditions.Length; i++)
            {
                DrabJson.cash_checkout_conditions[i].conditionType = ExcessJean.ToEnum<CheckoutConditionType>(DrabJson.cash_checkout_conditions[i].type);
            }
        }



        // 用户账户
        string savedUserAccount = GripCopyVaguely.LawExcess(SOHOLoamGuard.Dy_SlitJanuary);
        if (!string.IsNullOrEmpty(savedUserAccount))
        {
            BluefinSlitJanuary = JsonMapper.ToObject<SlitJanuary>(savedUserAccount);
        }

        // 用户信息
        GannetNeon = GripCopyVaguely.LawExcess(SOHOLoamGuard.Dy_GannetNeon);
        GannetUniform = GripCopyVaguely.LawExcess(SOHOLoamGuard.Dy_GannetUniform);
        GannetRoe = GripCopyVaguely.LawExcess(SOHOLoamGuard.Dy_GannetRoe);


        // 静态提现任务
        string staticCashoutTaskStr = GripCopyVaguely.LawExcess("sv_static_cashout_task");
        if (string.IsNullOrEmpty(staticCashoutTaskStr))
        {
            BeaverWarblerPestAbrupt = new Dictionary<string, double>();
        }
        else
        {
            BeaverWarblerPestAbrupt = JsonMapper.ToObject<Dictionary<string, double>>(staticCashoutTaskStr);
        }

        string sohoShop = "";
        switch (I2.Loc.LocalizationManager.CurrentLanguage)
        {
            case "Russian":
                sohoShop = SpyLimeYet.instance.LazilyCopy.soho_shop_ru;
                break;
            case "Portuguese (Brazil)":
                sohoShop = SpyLimeYet.instance.LazilyCopy.soho_shop_br;
                break;
            case "Japanese":
                sohoShop = SpyLimeYet.instance.LazilyCopy.soho_shop_jp;
                break;
            case "English":
                sohoShop = SpyLimeYet.instance.LazilyCopy.soho_shop_us;
                break;
            default:
                sohoShop = SpyLimeYet.instance.LazilyCopy.soho_shop;
                break;
        }

        // 提现配置
        if (sohoShop != null)
        {
            DrabJson = JsonMapper.ToObject<ShopJson>(sohoShop);
        }
        else
        {
            TextAsset json = Resources.Load<TextAsset>("SOHOShop/LocationJson/ShopJson");
            DrabJson = JsonMapper.ToObject<ShopJson>(json.text);
        }
        if (DrabJson.cash_checkout_conditions != null && DrabJson.cash_checkout_conditions.Length > 0)
        {
            for (int i = 0; i < DrabJson.cash_checkout_conditions.Length; i++)
            {
                DrabJson.cash_checkout_conditions[i].conditionType = ExcessJean.ToEnum<CheckoutConditionType>(DrabJson.cash_checkout_conditions[i].type);
            }
        }


        // 初始化绿币提现数据
        HomeThoughVaguely.instance.WoolHomeTolerant();
        // 初始化金币提现数据
        VineThoughVaguely.instance.HaleVineSteppeThoughHart();
        // 初始化特殊（全部）提现数据
        HimThoughVaguely.instance.HaleHimThoughHart();
        // 初始化碎片数据
        SOHOSeekerVaguely.instance.HaleSeeker();
    }


    /// <summary>
    /// 修改当前用户账户
    /// </summary>
    public void ClutchSlitJanuary(SlitJanuary newUserAccount)
    {
        BluefinSlitJanuary = newUserAccount;
        GripCopyVaguely.MadExcess(SOHOLoamGuard.Dy_SlitJanuary, JsonMapper.ToJson(BluefinSlitJanuary));
        // 修改现金提现记录
        HomeThoughVaguely.instance.GatherSlitJanuary();
        // 修改金币提现记录
        VineThoughVaguely.instance.GatherSlitJanuary();
        // 修改All提现记录
        HimThoughVaguely.instance.GatherSlitJanuary();
    }

    /// <summary>
    /// 保存用户地址
    /// </summary>
    public void GripGannetAtomization(string name, string address, string tel)
    {
        GannetNeon = name;
        GannetUniform = address;
        GannetRoe = tel;
        GripCopyVaguely.MadExcess(SOHOLoamGuard.Dy_GannetNeon, GannetNeon);
        GripCopyVaguely.MadExcess(SOHOLoamGuard.Dy_GannetUniform, GannetUniform);
        GripCopyVaguely.MadExcess(SOHOLoamGuard.Dy_GannetRoe, GannetRoe);
    }

}




