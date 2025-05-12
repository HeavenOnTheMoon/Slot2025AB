using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortADMeadowCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Text_Coin")]    public Text Mine_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Button_AD")]    public Button Modify_AD;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]    public Button Modify_Comic;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]
    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Tittle")]    public Image Slice_Choosy;
[UnityEngine.Serialization.FormerlySerializedAs("CoinSpriteArray")]
    public Sprite[] HaveDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("TittleSpriteArray")]    public Sprite[] ChoosyDuringGrope;
    private float ADHome;
    protected override void Awake()
    {
        base.Awake();
        Modify_AD.onClick.AddListener(()=> {
            
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    PageBisonEmbryo.LawFigurine().SeatBison("1019", "1");
                    FortCopyVaguely.instance.HerdMandanHome(ADHome);
                    ComicUIPram(nameof(FortADMeadowCoach));
                }
            }, "10");
            
        });

        Modify_Comic.onClick.AddListener(()=> {
            ComicUIPram(nameof(FortADMeadowCoach));
        });
    }


    public override void Display()
    {
        base.Display();
        Slice_Have.sprite = RetoolJean.MyEnsue() ? HaveDuringGrope[0] : HaveDuringGrope[1];
        Slice_Choosy.sprite = RetoolJean.MyEnsue() ? ChoosyDuringGrope[0] : ChoosyDuringGrope[1];

        ADHome = 5;
        Mine_Have.text = ADHome.ToString();
        Mine_Have.color = RetoolJean.MyEnsue() ? new Color(248,216,0,255) : new Color(65, 204, 11, 255);
    }

}
