using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortMeadowCoach : LeftUIMarry
{
    public static FortMeadowCoach instance;
[UnityEngine.Serialization.FormerlySerializedAs("ClaimText")]    public Text ShirtMine;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claim")]    public Button Modify_Shirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_TenPercentClaim")]    public Button Modify_DNASponsorShirt;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Win")]
    public Image Slice_Fly;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Title")]    public Image Slice_Spite;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Title")]    public Text Mine_Spite;
[UnityEngine.Serialization.FormerlySerializedAs("WinSpriteArray")]
    public Sprite[] FlyDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("TitleSpriteArray")]    public Sprite[] SpiteDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("SpineArray")]    public GameObject[] AlongGrope;

    private float SeniorLittle;
    private int _Sect;
    private bool _BeModify;
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }

    public override void Display()
    {
        base.Display();
        _BeModify = true;
        StartCoroutine(nameof(HabitFairWeADModify));
    }

    void Start()
    {
        Modify_Shirt.onClick.AddListener(()=> {
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    LawMeadow(true);
                }
            }, "2");
            
        });
        Modify_DNASponsorShirt.onClick.AddListener(()=> {
            if (_BeModify)
            {
                LawMeadow(false);
            }
        });
    }

    private void LawMeadow(bool isAd)
    {
        float num = isAd ? (SeniorLittle * 2) : SeniorLittle;
        if (isAd)
        {
            PageBisonEmbryo.LawFigurine().SeatBison("1004", "1", _Sect.ToString());
            EpidermisPalimpsest.GatherDeclare(SeniorLittle, num, 0.3f, Mine_Spite, () => {
                RotBloom(num);
            });
        }
        else
        {
            ADVaguely.Figurine.WeVacuumRotWhale();
            PageBisonEmbryo.LawFigurine().SeatBison("1004", "0", _Sect.ToString());
            RotBloom(num);
        }
    }

    private void RotBloom(float num)
    {
        FortCopyVaguely.instance.GatherLeoHerdMeadow(num);
        SitCoachTine.instance.HomeRotEpidermis(null, num);
        ComicUIPram(nameof(FortMeadowCoach));
        FortFistCoach.Instance.TrailHerdShrine();
    }

    public void MadMeadowLime(WinRewardType type,float cash)
    {
        SeniorLittle = cash;
        _Sect = (int)type;
        Slice_Have.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        int spriteIndex = (int)type - 1;
        //Image_Win.sprite = WinSpriteArray[spriteIndex];
        Slice_Spite.sprite = SpiteDuringGrope[spriteIndex];
        //Text_Title.text = cash.ToString();
        for (int i = 0; i < AlongGrope.Length; i++)
        {
            AlongGrope[i].SetActive(i == spriteIndex);
        }
        ArchMeadowGlobe(type);
        Mine_Spite.text = "0";
        GatherDeclare(0, SeniorLittle, 0.5f, Mine_Spite);
    }

    private void ArchMeadowGlobe(WinRewardType type)
    {
        switch (type)
        {
            case WinRewardType.None:
                break;
            case WinRewardType.Super:
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Mega_Win);
                break;
            case WinRewardType.Mega:
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Big_Win);
                break;
            case WinRewardType.Big:
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.SlotsAudio_win);
                break;
            default:
                break;
        }
    }

    public void GatherDeclare(double startNum, double endNum, float delay, Text text, Action finish = null)
    {
        DOTween.To(() => startNum, x => text.text = LittleJean.SummerMyNut(x), endNum, 0.5f).SetDelay(delay).OnComplete(() =>
        {
            finish?.Invoke();
        });
    }

    IEnumerator HabitFairWeADModify()
    {
        Modify_DNASponsorShirt.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        Modify_DNASponsorShirt.gameObject.SetActive(true);
    }
}
