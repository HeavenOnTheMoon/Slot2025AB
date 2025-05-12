using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortCharmSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Text_Reward")]    public Text Mine_Meadow;
[UnityEngine.Serialization.FormerlySerializedAs("Image_CheckOut")]    public GameObject Slice_TrailBus;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Lock")]    public GameObject Slice_Herb;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claim")]    public Button Modify_Shirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_ADClaim")]    public Button Modify_ADShirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claimed")]    public Button Modify_Boxlike;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Arrow")]
    public Image[] Slice_Stove;
[UnityEngine.Serialization.FormerlySerializedAs("Sprite_ArrowArray")]    public Sprite[] During_StoveArray;
[UnityEngine.Serialization.FormerlySerializedAs("_arrowIndex")]   
    public int _arrowMagic;
    private int SinkMagic;
    private MiniBonusRewardInfo _SeizeLime;

    private double _cash;

    private void Awake()
    {
        Modify_Shirt.onClick.AddListener(() => {
            if (_SeizeLime.IsLock)
            {
                FortWineCopyVaguely.LawFigurine().WineFistRotHome(_cash);
                FortWineCopyVaguely.LawFigurine().MadWineFistStarveMeadow(SinkMagic);
            }
            
        });
        Modify_ADShirt.onClick.AddListener(() => {
            if (_SeizeLime.IsLock)
            {
                ADVaguely.Figurine.HookMeadowAlike((success) =>
                {
                    if (success)
                    {
                        PageBisonEmbryo.LawFigurine().SeatBison("1018", "1");

                        FortWineCopyVaguely.LawFigurine().WineFistRotHome(_cash);
                        FortWineCopyVaguely.LawFigurine().MadWineFistStarveMeadow(SinkMagic);
                    }
                }, "8");
                
            }
        });
        Modify_Boxlike.onClick.AddListener(() => {

        });
    }

    public void MadCharmSink(MiniBonusRewardInfo info,int index,int arrowIndex)//(float reward,int index,bool isClaim,bool isAd,int arrowIndex)
    {
        SinkMagic = index;
        _SeizeLime = info;
        _arrowMagic = arrowIndex;
        Mine_Meadow.text = info.Cash.ToString();
        _cash = info.Cash;
        //����item��ʾ
        OnBonusItemUpdate(info);
        for (int i = 0; i < Slice_Stove.Length; i++)
        {
            Slice_Stove[i].gameObject.SetActive(false);
        }
        if (index + 1 != FortWineCopyVaguely.LawFigurine().LawWineDramaLime().Count)
        {
            int arrow = info.IsLock ? 0 : 1;
            Slice_Stove[arrowIndex].gameObject.SetActive(true);
            Slice_Stove[arrowIndex].sprite = During_StoveArray[arrow];
        }
       
    }

    public void OnBonusItemUpdate(MiniBonusRewardInfo info)
    {
        _SeizeLime = info;
        Modify_Boxlike.gameObject.SetActive(info.IsClaim && info.IsLock);
        Modify_ADShirt.gameObject.SetActive(!info.IsClaim && info.IsAd);
        Modify_Shirt.gameObject.SetActive(!info.IsClaim && !info.IsAd);
        Slice_TrailBus.gameObject.SetActive(info.IsClaim);
        Slice_Herb.gameObject.SetActive(!info.IsLock);
        int arrow = info.IsLock ? 0 : 1;
        Slice_Stove[_arrowMagic].sprite = During_StoveArray[arrow];
        //Debug.Log(" ----  ���   " + info.IsAd + "    ------   �Ƿ���ȡ   " + info.IsClaim + "   ----  �Ƿ���� " + info.IsLock);
    }

    
    
}
