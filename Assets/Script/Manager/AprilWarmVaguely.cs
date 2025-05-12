using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AprilWarmVaguely : MonoBehaviour
{
    public static AprilWarmVaguely instance;

    

    private void Awake()
    {
        instance = this;
       
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void LeapWool()
    {
        bool isNewPlayer = !PlayerPrefs.HasKey(CLazily.Dy_MyMixScanty + "Bool") || GripCopyVaguely.LawLeft(CLazily.Dy_MyMixScanty);


        CausalWoolVaguely.Instance.WoolCausalCopy(isNewPlayer);
        if (isNewPlayer)
        {
            // 新用户
            GripCopyVaguely.MadLeft(CLazily.Dy_MyMixScanty, false);
            //新用户默认点击次数十次
            GripCopyVaguely.MadAid(CLazily.Dy_HerdWhale, SpyLimeYet.instance.FistCopy.SpinRecoverTime.MaxSpinCount);
            GripCopyVaguely.MadLeft(CLazily.Dy_WageHerdTowel, false);
            FortWineCopyVaguely.LawFigurine().MadPredateWaterside();
        }
        GripCopyVaguely.MadLeft(CLazily.Dy_HerdSeedy, false);

        GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Quick7_Bgm);
        //打开admanager
        SpyLimeYet.instance.UpVaguely.SetActive(true);

        AprilFistCopyVaguely.LawFigurine().WoolFistCopy();
        PageBisonEmbryo.LawFigurine().SeatBison("1001");

        SOHOLoamVaguely.instance.WoolSOHOLoam();

        FortCopyVaguely.instance.FortCopyYetWool();
        ///新slot 
        FortWineCopyVaguely.LawFigurine().WineCopyWool();
        Application.targetFrameRate = 60;
        //UIInject.GetInstance().ShowUIForms(nameof(MagicSlotGamePanel));
        UIInject.LawFigurine().FairUIMarry(nameof(FortFistCoach));
        //UIInject.GetInstance().ShowUIForms(nameof(FortVenomFortCoach)); 
        /*FortWineCopyVaguely.GetInstance().CheckBonusTimeThreeDays();
        UIInject.GetInstance().ShowUIForms(nameof(FortVenomCharmCoach));*/
        //UIInject.GetInstance().ShowUIForms(nameof(SlotLuckyWheelPanel));

    }

    public bool ChoiceLiuFir()
    {
#if UNITY_IPHONE
        //通过设备型号判断是否刘海屏
        if (SystemInfo.deviceModel.Contains("iPhone3,1") || SystemInfo.deviceModel.Contains("iPhone3,2") || SystemInfo.deviceModel.Contains("iPhone3,3")
            || SystemInfo.deviceModel.Contains("iPhone4,1") || SystemInfo.deviceModel.Contains("iPhone5,1") || SystemInfo.deviceModel.Contains("iPhone5,2")
            || SystemInfo.deviceModel.Contains("iPhone5,3") || SystemInfo.deviceModel.Contains("iPhone5,4") || SystemInfo.deviceModel.Contains("iPhone6,1")
            || SystemInfo.deviceModel.Contains("iPhone6,2") || SystemInfo.deviceModel.Contains("iPhone7,2") || SystemInfo.deviceModel.Contains("iPhone7,1")
            || SystemInfo.deviceModel.Contains("iPhone8,1") || SystemInfo.deviceModel.Contains("iPhone8,2") || SystemInfo.deviceModel.Contains("iPhone8,3")
            || SystemInfo.deviceModel.Contains("iPhone8,4") || SystemInfo.deviceModel.Contains("iPhone9,1") || SystemInfo.deviceModel.Contains("iPhone9,2")
            || SystemInfo.deviceModel.Contains("iPhone9,3") || SystemInfo.deviceModel.Contains("iPhone9,4") || SystemInfo.deviceModel.Contains("iPhone10,1")
            || SystemInfo.deviceModel.Contains("iPhone10,2") || SystemInfo.deviceModel.Contains("iPhone10,4") || SystemInfo.deviceModel.Contains("iPhone10,5")
            || SystemInfo.deviceModel.Contains("iPhone12,8") || SystemInfo.deviceModel.Contains("iPhone14,6"))
        {
            return false;
        }
        else
        {
            return true;
        }
        //通过屏幕比例判断是否刘海屏
        if ((float)Screen.width / Screen.height > 2)
        {
            return true;
        }
#endif
        return false;
    }


    public void MadActive(Transform target, float x = 0, float y = -45)
    {
#if UNITY_IPHONE
        //if (JudgetLiuHai())
        //{
        //    Debug.Log("IPhone Adapta>>>");
        //    RectTransform rect = target.GetComponent<RectTransform>();
        //    Vector2 anPos = rect.anchoredPosition;
        //    anPos.x += x;
        //    anPos.y += y;
        //    rect.anchoredPosition = anPos;
        //}
#endif
    }

}

