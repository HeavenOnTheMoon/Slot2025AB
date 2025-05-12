using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Spine.Unity;

/// <summary> 记录物品信息 刷新对应UI </summary>
public class FortFistSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ItemSpriteIndex")]    public int SinkDuringMagic;
[UnityEngine.Serialization.FormerlySerializedAs("ItemIndex")]    public int SinkMagic;
[UnityEngine.Serialization.FormerlySerializedAs("ItemType")]    public string SinkThus;
[UnityEngine.Serialization.FormerlySerializedAs("Icon")]    public Image What;
[UnityEngine.Serialization.FormerlySerializedAs("WoManIcon")]    //竖排三个混子的图
    public Image WoTanWhat;
[UnityEngine.Serialization.FormerlySerializedAs("WoMainTwoIcon")]    public Image GoWarmLogWhat;
[UnityEngine.Serialization.FormerlySerializedAs("ItemMask")]    public GameObject SinkSale;
[UnityEngine.Serialization.FormerlySerializedAs("ItemFx")]    public GameObject SinkFx;
[UnityEngine.Serialization.FormerlySerializedAs("Bonues")]    public GameObject Elliot;
[UnityEngine.Serialization.FormerlySerializedAs("ItemSpineArray")]
    public SkeletonGraphic[] SinkAlongGrope;
[UnityEngine.Serialization.FormerlySerializedAs("RealSlotGameRowItem")]
    public FortFistSink[] ComeFortFistRimSink;
[UnityEngine.Serialization.FormerlySerializedAs("IsThreeWild")]
    public bool MyTreatFold;
    private bool MyTillWhat;
    private bool MyLadCharm;
[UnityEngine.Serialization.FormerlySerializedAs("_wildIndex")]
    public int _WashMagic;
    public void Wool(int index,string type,int itemIdnex = -1)
    {
        WhatAlongFund();
        MyLadCharm = index == 10;
        SinkThus = type;
        SinkMagic = itemIdnex;
        MyTreatFold = false;
        SinkDuringMagic = index;
        MyTillWhat = true;
        _WashMagic = 0;
        SinkSale.SetActive(false);
        What.gameObject.SetActive(true);
        SinkFx.SetActive(false);
        WoTanWhat.gameObject.SetActive(false);
        GoWarmLogWhat.gameObject.SetActive(false);
        What.sprite = WaistVaguely.Instance.LawSinkDuring(index);
    }
    /// <summary>
    /// 初始化竖排,wildIndex  2 两个混子，3 三个混子
    /// </summary>
    public void WoolTreatFold(int index ,string type,int wildIndex)
    {
        WhatAlongFund();
        SinkThus = type;
        MyLadCharm = index == 10;
        MyTreatFold = true;
        _WashMagic = wildIndex;
        SinkDuringMagic = index;
        SinkSale.SetActive(false);
        MyTillWhat = false;
        What.gameObject.SetActive(false);
        SinkFx.gameObject.SetActive(false);
        WoTanWhat.gameObject.SetActive(wildIndex == 3);
        GoWarmLogWhat.gameObject.SetActive(wildIndex == 2);
    }

    /// <summary>
    /// 是否开启Icon
    /// </summary>
    public void FairWhat(bool isOpen,bool isThree)
    {
        MyTreatFold = isThree;
        MyTillWhat = isOpen;
        What.gameObject.SetActive(isOpen);
    }

    /// <summary>
    /// 假动画icon初始化
    /// </summary>
    public void EvenFairWhatWool()
    {
        if (MyTreatFold && SinkThus == "wild")
        {
            return;
        }
        What.gameObject.SetActive(true);
    }

    //关闭icon
    public void FundWhat(int index,string type) //隐藏假动画图标 同时让真假图标一致 方便下次动画视觉连贯性
    {
        SinkDuringMagic = index;
        SinkThus = type;
        What.sprite = WaistVaguely.Instance.LawSinkDuring(index);
        What.gameObject.SetActive(false);
    }

    //mask设置
    public void WhatSaleFair(bool isOpenMask)
    {
        //ItemMask.SetActive(isOpenMask);
        SinkFx.gameObject.SetActive(!isOpenMask);
    }

   /// <summary>
   /// spin动画播放
   /// </summary>
   /// <param name="isShow"></param>
    public void WhatAlongFair(bool isShow)
    {
        if (isShow)
        {
            int index = SinkDuringMagic;
            if (MyTreatFold)
            {
                SinkFx.gameObject.SetActive(false);
                for (int i = 0; i < ComeFortFistRimSink.Length; i++)
                {
                    if (ComeFortFistRimSink[i].MyFairFold())
                    {
                        ComeFortFistRimSink[i].FoldAlongArch();
                    }
                }
            }
            else
            {
                ArchAlongSoMagic(index);
                //ItemFx.gameObject.SetActive(true);
            }
        }
        else
        {
            WhatAlongFund();
        }
        //skeletonAnimation.AnimationState.SetAnimation(1, expressionAnim, false);

    }

    //是否为三行混子
    public bool MyFairFold()
    {
        return What.gameObject.activeInHierarchy || WoTanWhat.gameObject.activeInHierarchy || GoWarmLogWhat.gameObject.activeInHierarchy;
    }

    /// <summary>
    /// 混子的spine播放
    /// </summary>
    /// <param name="itemIndex"></param>
    public void FoldAlongArch()
    {
        if (_WashMagic != 3 && _WashMagic != 2)
            return;
        int index = _WashMagic == 3 ? 11 : 12;
        ArchAlongSoMagic(index);
    }

    
    //通过index播放spine
    private void ArchAlongSoMagic(int index)
    {
        SinkAlongGrope[index].gameObject.SetActive(true);
        SinkAlongGrope[index].AnimationState.SetAnimation(0, "animation", true);
        What.gameObject.SetActive(false);
    }

    public void WhatAlongFund()
    {
        for (int i = 0; i < SinkAlongGrope.Length; i++)
        {
            SinkAlongGrope[i].gameObject.SetActive(false);
        }
        What.gameObject.SetActive(MyTillWhat);
        WoTanWhat.gameObject.SetActive(_WashMagic == 3);
        GoWarmLogWhat.gameObject.SetActive(_WashMagic == 2);
    }

    public void CowhandAlongArch()
    {
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Scatter_Get);
        ArchAlongSoMagic(9);
        StartCoroutine(nameof(HabitCowhandLink));
    }

    public void ArchCharmWhatLadLink()
    {
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Bonus_Special);
        ArchAlongSoMagic(10);
        StartCoroutine(nameof(HabitLadLink));
    }

    IEnumerator HabitLadLink()
    {
        yield return new WaitForSeconds(2f);
        EpidermisPalimpsest.VinePeakAkin(Elliot, 1, transform, CharmCoachTine.Instance.CharmSpiteObsess.transform, () =>
        {
            SinkAlongGrope[10].gameObject.SetActive(false);
            What.gameObject.SetActive(true);
        });

        yield return new WaitForSeconds(1f);
        //FortCopyVaguely.instance.ChangeBonusUpdate();
    }

    IEnumerator HabitCowhandLink()
    {
        yield return new WaitForSeconds(2f);
        SinkAlongGrope[9].gameObject.SetActive(false);
        What.gameObject.SetActive(true);
    }
}
