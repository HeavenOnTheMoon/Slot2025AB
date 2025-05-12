using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortVenomHaleMeadowCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Text_Coin")]    public Text Mine_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Image_RewardIcon")]    public Image Slice_MeadowWhat;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claim")]    public Button Modify_Shirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_TenClaim")]    public Button Modify_DNAShirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]    public Button Modify_Comic;
    private double _Senior;
    private int _EasyHe;
    void Start()
    {
        Modify_Shirt.onClick.AddListener(() =>
        {
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    PageBisonEmbryo.LawFigurine().SeatBison("1009", "1");
                    LawMeadow(false);
                }
                
            }, "4");
            
        });

       /* Button_TenClaim.onClick.AddListener(()=> {
            ADVaguely.Instance.NoThanksAddCount();
            GetReward(false);
        });*/
        Modify_Comic.onClick.AddListener(()=> {
            FortWineCopyVaguely.LawFigurine().GatherFortHaleMeadowWeird(_EasyHe, true);
            ComicUIPram(nameof(FortVenomHaleMeadowCoach));
            FortFistCoach.Instance.TrailHerdShrine();
        });

    }


    public override void Display()
    {
        base.Display();
        MadHaleLime();
    }


    public void MadHaleLime()
    {
        var Here= FortWineCopyVaguely.LawFigurine().LawVenomHaleMagic();
        Slice_MeadowWhat.sprite = WaistVaguely.Instance.FortVenomHaleDuringGrope[Here.id];
        _EasyHe = Here.id;
        Slice_Have.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        Mine_Have.text = Here.cash.ToString();
        _Senior = Here.cash;
        Debug.Log("--------------------          " + _Senior);
    }


    private void LawMeadow(bool isAd)
    {
        float Dual= (float)_Senior; //isAd ? (float)_reward :(float)_reward * 0.1f;
        FortWineCopyVaguely.LawFigurine().WineFistRotHome(Dual);
        FortWineCopyVaguely.LawFigurine().GatherFortHaleMeadowWeird(_EasyHe,isAd);
        ComicUIPram(nameof(FortVenomHaleMeadowCoach));
        //FortFistCoach.Instance.OpenFreeSpin();
        FortFistCoach.Instance.TrailHerdShrine();
    }
}
