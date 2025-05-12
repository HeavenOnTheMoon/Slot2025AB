/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine.Playables;
using com.adjust.sdk;
//using MoreMountains.NiceVibrations;

public class SpyLimeYet : MonoBehaviour
{

    public static SpyLimeYet instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
    public string BaseHow;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
    public string LeftAlongHow;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
    public string LeftLazilyHow;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
    public string LeftTheyHow;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
    public string LeftCausalHow;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
    public string FistFend= "20000";
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]
    //channel渠道平台
#if UNITY_IOS
    public string Fitting= "AppStore";
#elif UNITY_ANDROID
    public string Channel = "GooglePlay";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string ForwardNeon{ get { return Application.identifier; } }
    //登录url
    private string LoginHow= "";
    //配置url
    private string LazilyHow= "";
    //更新AdjustId url
    private string CausalHow= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
    public string Loosely= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
    public MassifCopy LazilyCopy;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
    public Init WoolCopy;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    public GameInfo FistCopy;
[UnityEngine.Serialization.FormerlySerializedAs("SlotInfo")]    //Slot数据
    public SlotInfo FortLime;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    //ADVaguely
    public GameObject UpVaguely;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    public string Talk;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    public string Ink;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    public string Crab;
    int Award_Tally= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    public bool Award= false;
    [HideInInspector] 
[UnityEngine.Serialization.FormerlySerializedAs("DataFrom")]    public string CopyFrom; //数据来源 打点用
    //ios 获取idfa函数声明
// #if UNITY_IOS
//     [DllImport("__Internal")]
//     internal extern static void getIDFA();
// #endif
    void Awake()
    {
        print("BaseUrl:   " + BaseHow);
        instance = this;
        LoginHow = LeftAlongHow + FistFend + "&channel=" + Fitting + "&version=" + Application.version;
        LazilyHow = LeftLazilyHow + FistFend + "&channel=" + Fitting + "&version=" + Application.version;
        LeftTheyHow = LeftLazilyHow + FistFend + "&channel=" + Fitting + "&version=" + Application.version;
        CausalHow = LeftCausalHow + FistFend;
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            Along();
#endif
        }
        else
        {
            Along();           //编辑器登录
        }
        //获取config数据
        LawLazilyCopy();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void gaidAction(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Talk = gaid_str; 
        if (Talk == null || Talk == "")
        {
            Talk = GripCopyVaguely.LawExcess("gaid");
        }
        else
        {
            GripCopyVaguely.MadExcess("gaid", Talk);
        }
        Award_Tally++;
        if (Award_Tally == 2)
        {
            Along();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void aidAction(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        Ink = aid_str;
        if (Ink == null || Ink == "")
        {
            Ink = GripCopyVaguely.LawExcess("aid");
        }
        else
        {
            GripCopyVaguely.MadExcess("aid", Ink);
        }
        Award_Tally++;
        if (Award_Tally == 2)
        {
            Along();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void idfaSuccess(string message)
    {
        Debug.Log("idfa success:" + message);
        Crab = message;
        GripCopyVaguely.MadExcess("idfa", Crab);
        Along();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void idfaFail(string message)
    {
        Debug.Log("idfa fail");
        Crab = GripCopyVaguely.LawExcess("idfa");
        Along();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Along()
    {
        //获取本地缓存的Local用户ID
        string localId = GripCopyVaguely.LawExcess(CLazily.Dy_BlameSlitHe);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            GripCopyVaguely.MadExcess(CLazily.Dy_BlameSlitHe, localId);
        }

        //拼接登录接口参数
        string url = "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            url = LoginHow + "&" + "randomKey" + "=" + localId + "&idfa=" + Crab + "&packageName=" + ForwardNeon;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            url = LoginHow + "&" + "randomKey" + "=" + localId + "&gaid=" + Talk + "&androidId=" + Ink + "&packageName=" + ForwardNeon;
        }
        else //编辑器
        {
            url = LoginHow + "&" + "randomKey" + "=" + localId + "&packageName=" + ForwardNeon;
        }

        //获取国家信息
        JobHandful(() => {
            url += "&country=" + Loosely;
            //登录请求
            SpyOvalVaguely.LawFigurine().PackLaw(url,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    GripCopyVaguely.MadExcess("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    GripCopyVaguely.MadExcess(CLazily.Dy_BlameMassifHe, serverUserData.data.ToString());

                    SeatCausalHoof();
                    if (PlayerPrefs.GetInt("SendedEvent") != 1 && !String.IsNullOrEmpty(RetoolJean.SpurKey))
                        RetoolJean.SeatBison();

                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void JobHandful(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Loosely))
        {
            //获取国家超时返回
            StartCoroutine(SpyOvalTheyBus(() =>
            {
                if (!callBackReady)
                {
                    Loosely = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            }));
            SpyOvalVaguely.LawFigurine().PackLaw("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Loosely = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Loosely);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Loosely = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void LawLazilyCopy()
    {
        Debug.Log("GetConfigData:" + LazilyHow);
        StartCoroutine(SpyOvalTheyBus(() =>
        {
            LawAirplaneCopy();
        }));

        //获取并存入Config
        SpyOvalVaguely.LawFigurine().PackLaw(LazilyHow,
        (data) => {
            CopyFrom = "OnlineData";
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            GripCopyVaguely.MadExcess("OnlineData", data.downloadHandler.text);
            MadLazilyCopy(data.downloadHandler.text);
        },
        () => {
            Debug.Log("ConfigData 失败");
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void LawAirplaneCopy()
    {
        //是否有缓存
        if (GripCopyVaguely.LawExcess("OnlineData") == "" || GripCopyVaguely.LawExcess("OnlineData").Length == 0)
        {
            Debug.Log("本地数据");
            CopyFrom = "LocalData_Updated"; //已联网更新过的数据
            TextAsset json = Resources.Load<TextAsset>("LocationJson/LocationData");
            MadLazilyCopy(json.text);
        }
        else
        {
            Debug.Log("服务器缓存数据");
            CopyFrom = "LocalData_Original"; //原始数据
            MadLazilyCopy(GripCopyVaguely.LawExcess("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void MadLazilyCopy(string configJson)
    {
        ////如果已经获得了数据则不再处理
        //if (ConfigData == null)
        //{
        //    RootData rootData = JsonMapper.ToObject<RootData>(configJson);
        //    ConfigData = rootData.data;
        //    InitData = JsonMapper.ToObject<Init>(ConfigData.init);
        //    GameData = JsonMapper.ToObject<GameInfo>(ConfigData.gameInfo);
        //    SlotInfo = JsonMapper.ToObject<SlotInfo>(ConfigData.slotInfo);
        //    GameReady();
        //}

        //如果已经获得了数据则不再处理
        if (LazilyCopy == null)
        {
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            LazilyCopy = rootData.data;
            string gameSeverData = "";
            try
            {
                switch (I2.Loc.LocalizationManager.CurrentLanguage)
                {
                    case "Russian":
                        WoolCopy = JsonMapper.ToObject<Init>(LazilyCopy.init_ru);
                       // gameSeverData = ConfigData.game_date_ru;
                        break;

                    case "Portuguese (Brazil)":
                        WoolCopy = JsonMapper.ToObject<Init>(LazilyCopy.init_br);
                      //  gameSeverData = ConfigData.game_date_br;
                        break;

                    case "Japanese":
                        WoolCopy = JsonMapper.ToObject<Init>(LazilyCopy.init_jp);
                      // gameSeverData = ConfigData.game_date_jp;
                        break;

                    case "Indonesian":
                      //  InitData = JsonMapper.ToObject<Init>(ConfigData.init_id);
                      //  gameSeverData = ConfigData.game_date_id;
                        break;

                    case "English":
                        WoolCopy = JsonMapper.ToObject<Init>(LazilyCopy.init_us);
                       // gameSeverData = ConfigData.game_date_us;
                        break;

                    default:
                        WoolCopy = JsonMapper.ToObject<Init>(LazilyCopy.init);
                      //  gameSeverData = ConfigData.game_data;
                        break;
                }
            }
            catch
            {
                WoolCopy = JsonMapper.ToObject<Init>(LazilyCopy.init);
              //  gameSeverData = ConfigData.game_data;
            }
            FistCopy = JsonMapper.ToObject<GameInfo>(LazilyCopy.gameInfo);
            FortLime = JsonMapper.ToObject<SlotInfo>(LazilyCopy.slotInfo);
            //if (gameSeverData == null)
            //{
            //    print("没有对应国家的gamedata 使用默认  当前语言是： " + GripCopyVaguely.GetString(CLazily.sys_language));
            //    gameSeverData = ConfigData.game_data;
            //}

            //if (gameSeverData != "")
            //{
            //    GameSeverData = JsonMapper.ToObject<GameData>(gameSeverData);
            //    LGNCanyDiveMgr.GetInstance().ZeroCanyDive();
            //}
            print("当前使用的多语言数据是： " + I2.Loc.LocalizationManager.CurrentLanguage);
            LawSlitLime();
        }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void FistCider()
    {
        GripCopyVaguely.MadAid("LastSkinID", RetoolJean.MyEnsue() ? 0 : 1);
       /* //打开admanager
        adManager.SetActive(true);*/
        //进度条可以继续
        Award = true;
    }



    /// <summary>
    /// 超时处理
    /// </summary>
    /// <param name="finish"></param>
    /// <returns></returns>
    IEnumerator SpyOvalTheyBus(Action finish)
    {
        yield return new WaitForSeconds(TIMEOUT);
        finish();
    }

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void SeatCausalHoof()
    {
        string serverId = GripCopyVaguely.LawExcess(CLazily.Dy_BlameMassifHe);
        string adjustId = CausalWoolVaguely.Instance.LawCausalHoof();
        if (string.IsNullOrEmpty(serverId) || string.IsNullOrEmpty(adjustId))
        {
            return;
        }

        string url = CausalHow + "&serverId=" + serverId + "&adid=" + adjustId;
        Debug.Log("======    AdjustId   " + adjustId);
        SpyOvalVaguely.LawFigurine().PackLaw(url,
            (data) => {
                Debug.Log("服务器更新adjust adid 成功" + data.downloadHandler.text);
            },
            () => {
                Debug.Log("服务器更新adjust adid 失败");
            });
    }

    //轮询检查Adjust归因信息
    int TrailWhale= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("Event_TrackerName")]public string Bison_TextureNeon; //打点用参数
    bool _TrailTo= false;
    [HideInInspector]
    public bool CausalTexture_Cider    {
        get
        {
            if (Application.isEditor) //编译器跳过检查
                return true;
            return _TrailTo;
        }
    }
    public void TrailCausalVenture() //检查Adjust归因信息
    {
        if (Application.isEditor) //编译器跳过检查
            return;
        if (!string.IsNullOrEmpty(Bison_TextureNeon)) //已经拿到归因信息
            return;

        CancelInvoke(nameof(TrailCausalVenture));
        if (!string.IsNullOrEmpty(LazilyCopy.fall_down) && LazilyCopy.fall_down == "fall")
        {
            print("Adjust 无归因相关配置或未联网 跳过检查");
            _TrailTo = true;
        }
        try
        {
            AdjustAttribution Lime= Adjust.getAttribution();
            print("Adjust 获取信息成功 归因渠道：" + Lime.trackerName);
            Bison_TextureNeon = "TrackerName: " + Lime.trackerName;
            RetoolJean.Causal_TextureNeon = Lime.trackerName;
            _TrailTo = true;
        }
        catch (System.Exception e)
        {
            TrailWhale++;
            Debug.Log("Adjust 获取信息失败：" + e.Message + " 重试次数：" + TrailWhale);
            if (TrailWhale >= 10)
                _TrailTo = true;
            Invoke(nameof(TrailCausalVenture), 1);
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("UserDataStr")]
    //获取用户信息
    public string SlitCopyNut= "";
[UnityEngine.Serialization.FormerlySerializedAs("UserData")]    public UserInfoData SlitCopy;
    int LawSlitLimeWhale= 0;
    void LawSlitLime()
    {
        //还有进入正常模式的可能
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "YES")
            PlayerPrefs.DeleteKey("Save_AP");
        //已经记录过用户信息 跳过检查
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "NO")
        {
            FistCider();
            return;
        }

        //检查归因渠道信息
        TrailCausalVenture();
        //获取用户信息
        string CheckUrl = BaseHow + "/api/client/user/checkUser";
        SpyOvalVaguely.LawFigurine().PackLaw(CheckUrl,
        (data) =>
        {
            SlitCopyNut = data.downloadHandler.text;
            print("+++++ 获取用户数据 成功" + SlitCopyNut);
            UserRootData rootData = JsonMapper.ToObject<UserRootData>(SlitCopyNut);
            SlitCopy = JsonMapper.ToObject<UserInfoData>(rootData.data);
            if (SlitCopyNut.Contains("apple")
            || SlitCopyNut.Contains("Apple")
            || SlitCopyNut.Contains("APPLE"))
                SlitCopy.IsHaveApple = true;
            FistCider();
        }, () => { });
        Invoke(nameof(ReLawSlitLime), 1);
    }
    void ReLawSlitLime()
    {
        if (!Award)
        {
            LawSlitLimeWhale++;
            if (LawSlitLimeWhale < 10)
            {
                print("+++++ 获取用户数据失败 重试： " + LawSlitLimeWhale);
                LawSlitLime();
            }
            else
            {
                print("+++++ 获取用户数据 失败次数过多，放弃");
                FistCider();
            }
        }
    }

}
