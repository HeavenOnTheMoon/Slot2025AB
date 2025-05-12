using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortHaleSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claim")]    public Button Modify_Shirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Collected")]    public Button Modify_Spiritual;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Cash")]    public Text Mine_Home;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Cash")]    public Image Slice_Home;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Bg")]
    public GameObject Slice_Dy;
[UnityEngine.Serialization.FormerlySerializedAs("Image_UnKnow")]    public GameObject Slice_UnMean;

    private double _Dual;
    private int _EasyHe;
    private void Start()
    {
        Modify_Shirt.onClick.AddListener(()=> {
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    PageBisonEmbryo.LawFigurine().SeatBison("1016", "1");
                    FortWineCopyVaguely.LawFigurine().WineFistRotHome(_Dual);
                    FortWineCopyVaguely.LawFigurine().GatherFortHaleMeadowWeird(_EasyHe, false);
                    Modify_Shirt.gameObject.SetActive(false);
                    Modify_Spiritual.gameObject.SetActive(true);
                }

            }, "9");
        });

        Modify_Spiritual.onClick.AddListener(()=> { 
        
        });
    }

    public void MadFortHaleSinkLime(int index,bool isLock,bool isHave,double cash)
    {
        _EasyHe = index;
        _Dual = cash;
        Mine_Home.text = _Dual.ToString("f2");
        Slice_Dy.SetActive(isLock);
        Slice_UnMean.SetActive(!isLock);
        Slice_Home.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        if (isLock)
        {
            Modify_Shirt.gameObject.SetActive(isHave);
            Modify_Spiritual.gameObject.SetActive(!isHave);
            if (index < WaistVaguely.Instance.FortVenomHaleDuringGrope.Length)
            {
                Slice_Have.sprite = WaistVaguely.Instance.FortVenomHaleDuringGrope[index];
            }
        }
        
    }
}
