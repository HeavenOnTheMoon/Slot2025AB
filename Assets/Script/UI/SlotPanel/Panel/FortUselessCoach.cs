using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortUselessCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Button_Sound")]    public Button Modify_Angry;
[UnityEngine.Serialization.FormerlySerializedAs("Button_How")]    public Button Modify_Icy;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Contact")]    public Button Modify_Darling;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Privacy")]    public Button Modify_Gesture;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]
    public Button Modify_Comic;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Sound")]    public Text Mine_Angry;
[UnityEngine.Serialization.FormerlySerializedAs("SoundSpriteArray")]
    public Sprite[] AngryDuringGrope;
    protected override void Awake()
    {
        base.Awake();
        Modify_Angry.onClick.AddListener(()=> {
            GlobeYet.LawFigurine().BgGlobeOblige = !GlobeYet.LawFigurine().BgGlobeOblige;
            GlobeYet.LawFigurine().AdventGlobeOblige = !GlobeYet.LawFigurine().AdventGlobeOblige;
            MadAngry();
        });
        Modify_Icy.onClick.AddListener(() => {
            UIInject.LawFigurine().FairUIMarry(nameof(ExpressionlessCoach));
            ComicUIPram(nameof(FortUselessCoach));
        });
        Modify_Darling.onClick.AddListener(() => {
            Uri uri = new Uri(string.Format("mailto:{0}?subject={1}", SOHOLoamCopyVaguely.instance.DrabJson.email, Application.productName));//�ڶ����������ʼ��ı���
            Application.OpenURL(uri.AbsoluteUri);
            ComicUIPram(nameof(FortUselessCoach));
        });
        Modify_Gesture.onClick.AddListener(() => {
            string tempUrl = string.Format("http://elizabethlandmark.top/privacy_policy.html");
            Application.OpenURL(tempUrl);
            ComicUIPram(nameof(FortUselessCoach));
        });

        Modify_Comic.onClick.AddListener(()=> {
            ComicUIPram(nameof(FortUselessCoach));
        });
    }

    public override void Display()
    {
        base.Display();
        MadAngry();
    }

    public void MadAngry()
    {
        Modify_Angry.GetComponent<Image>().sprite = GlobeYet.LawFigurine().BgGlobeOblige ? AngryDuringGrope[0] : AngryDuringGrope[1];
        Mine_Angry.text = GlobeYet.LawFigurine().BgGlobeOblige ? "SOUND : ON" : "SOUND : OFF";
    }
}
