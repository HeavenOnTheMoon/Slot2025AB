using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortFoldMeadowCoach : LeftUIMarry
{
    public static FortFoldMeadowCoach instance;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claim")]    public Button Modify_Shirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_ClaimNoAD")]    public Button Modify_ShirtWeAD;
[UnityEngine.Serialization.FormerlySerializedAs("Button_TenPercentClaim")]    public Button Modify_DNASponsorShirt;
[UnityEngine.Serialization.FormerlySerializedAs("Image_TitleTop")]
    public Image Slice_SpiteSit;
[UnityEngine.Serialization.FormerlySerializedAs("Image_TitleJackpot")]    public Image Slice_SpiteVoyager;
[UnityEngine.Serialization.FormerlySerializedAs("Image_TitleBg")]    public Image Slice_SpiteDy;
[UnityEngine.Serialization.FormerlySerializedAs("Image_TitleTextBg")]    public Image Slice_SpiteMineDy;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Coin")]
    public Text Mine_Have;
[UnityEngine.Serialization.FormerlySerializedAs("TitleTopSpriteArray")]    
    //public 

    public Sprite[] SpiteSitDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("TitleJacopotSpriteArray")]    public Sprite[] SpiteJacopotDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("TitleTextSpriteArray")]    public Sprite[] SpiteMineDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("BgSpriteArray")]    public Sprite[] DyDuringGrope;

    private float _Senior;
    private float _Sect;
    private string _RockThus;
    private string _UpHe;
    private bool _BeModify;
    protected override void Awake()
    {
        base.Awake();
        RewriteNeuronNiche.LawFigurine().Alphabet("MiniGameWildGamePanelUpdate", OnMiniGameWildGamePanelUpdate);
        Modify_ShirtWeAD.onClick.AddListener(()=> {
            string id = LawPageID();
            PageBisonEmbryo.LawFigurine().SeatBison(id, "1", _Sect.ToString());
            LawMeadow(true);
        });
        Modify_Shirt.onClick.AddListener(() => {
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    string id = LawPageID();
                    PageBisonEmbryo.LawFigurine().SeatBison(id, "1", _Sect.ToString());
                    LawMeadow(true);
                }
            }, _UpHe);
        });

        Modify_DNASponsorShirt.onClick.AddListener(() => {
            if (_BeModify)
            {
                ADVaguely.Figurine.WeVacuumRotWhale();
                string id = LawPageID();
                PageBisonEmbryo.LawFigurine().SeatBison(id, "0", _Sect.ToString());
                LawMeadow(false);
                _BeModify = false;
            }
            
        });
    }

    public override void Display()
    {
        base.Display();
        _BeModify = true;
        Modify_ShirtWeAD.gameObject.SetActive(!GripCopyVaguely.LawLeft("FirstWildReward"));
        Modify_Shirt.gameObject.SetActive(GripCopyVaguely.LawLeft("FirstWildReward"));
        Modify_DNASponsorShirt.gameObject.SetActive(GripCopyVaguely.LawLeft("FirstWildReward"));
        if (!GripCopyVaguely.LawLeft("FirstWildReward"))
        {
            GripCopyVaguely.MadLeft("FirstWildReward", true);
        }
        else
        {
            StartCoroutine(nameof(HabitFairWeADModify));
        }
        
    }

    private void OnMiniGameWildGamePanelUpdate(RewriteCopy obj)
    {
        FoldFistCoachWool((WildRewardType)obj.FiordAid, obj.FiordAlarm,obj.FiordExcess);
    }

    public void FoldFistCoachWool(WildRewardType type,float reward,string mini)
    {
        _Senior = reward;
        _Sect = (int)type;
        _RockThus = mini;
        Mine_Have.text = _Senior.ToString("f2");
        Slice_SpiteSit.sprite = SpiteSitDuringGrope[(int)type];
        Slice_SpiteVoyager.sprite = SpiteJacopotDuringGrope[(int)type];
        Slice_SpiteMineDy.sprite = SpiteMineDuringGrope[(int)type];
        Slice_SpiteDy.sprite = DyDuringGrope[(int)type];
        Slice_Have.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        ArchMeadowGlobe(type);
    }

    private string LawPageID()
    {
        string id = "1005";
        if (_RockThus == "bonus")
        {
            id = "1007";
            _UpHe = "3";
        }
        else if (_RockThus == "wild")
        {
            id = "1005";
            _UpHe = "1";
        }
        else if (_RockThus == "wheel")
        {
            id = "1011";
            _UpHe = "6";
        }
        return id;
    }


    private void LawMeadow(bool isAd)
    {
        float Dual= isAd ? _Senior : _Senior * 0.1f;
        if (isAd)
        {
            FortWineCopyVaguely.LawFigurine().WineFistRotHome(Dual);
            ComicUIPram(nameof(FortFoldMeadowCoach));
            //FortFistCoach.Instance.OpenFreeSpin();
            FortFistCoach.Instance.TrailHerdShrine();
        }
        else
        {
            EpidermisPalimpsest.GatherDeclare(_Senior, Dual, 0.3f, Mine_Have, () => {
                FortWineCopyVaguely.LawFigurine().WineFistRotHome(Dual);
                ComicUIPram(nameof(FortFoldMeadowCoach));
                //FortFistCoach.Instance.OpenFreeSpin();
                FortFistCoach.Instance.TrailHerdShrine();
            });
        }
    }

    private void ArchMeadowGlobe(WildRewardType type)
    {
        switch (type)
        {
            case WildRewardType.Mini:
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_MiniJackpot);
                break;
            case WildRewardType.Major:
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_MajorJackpot);
                break;
            case WildRewardType.Grand:
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_GrandJackpot);
                break;
            default:
                break;
        }
    }

    IEnumerator HabitFairWeADModify()
    {
        Modify_DNASponsorShirt.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        Modify_DNASponsorShirt.gameObject.SetActive(true);
    }

    
}
