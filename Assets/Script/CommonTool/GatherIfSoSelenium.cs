using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> i2插件换图经常出问题 用这个脚本代替 </summary>
public class GatherIfSoSelenium : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("English")]    public Sprite Account; //英语
[UnityEngine.Serialization.FormerlySerializedAs("Portuguese")]    public Sprite Invariably; //巴西
[UnityEngine.Serialization.FormerlySerializedAs("Russian")]    public Sprite Peasant; //俄语
[UnityEngine.Serialization.FormerlySerializedAs("Arabic")]    public Sprite Inborn; //阿拉伯
[UnityEngine.Serialization.FormerlySerializedAs("Japanese")]    public Sprite Imitator; //日语
[UnityEngine.Serialization.FormerlySerializedAs("Indonesian")]    public Sprite Millimeter; //印度尼西亚语


    private void Awake()
    {
        Image Ui = GetComponent<Image>();
        string Language = I2.Loc.LocalizationManager.CurrentLanguage;
        try
        {
            switch (Language)
            {
                case "English":
                    Ui.sprite = Account;
                    break;
                case "Portuguese (Brazil)":
                    Ui.sprite = Invariably;
                    break;
                case "Russian":
                    Ui.sprite = Peasant;
                    break;
                case "Arabic":
                    Ui.sprite = Inborn;
                    break;
                case "Japanese":
                    Ui.sprite = Imitator;
                    break;
                case "Indonesian":
                    Ui.sprite = Millimeter;
                    break;
                default:
                    Ui.sprite = Account;
                    break;
            }
        }
        catch (System.Exception e)
        {
            Ui.sprite = Account;
        }
    }
}
