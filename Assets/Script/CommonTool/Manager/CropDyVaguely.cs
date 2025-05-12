using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CropDyVaguely : MonoBehaviour
{
    public static CropDyVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Belle;
    //获取IOS函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void openRateUsUrl(string appId);
#endif

    private void Awake()
    {
        instance = this;
    }

    public void TillAPPinModest()
    {
#if UNITY_ANDROID || UNITY_EDITOR
        Application.OpenURL("market://details?id=" + Belle);
#elif UNITY_IOS
        openRateUsUrl(Belle);
#endif
    }
}
