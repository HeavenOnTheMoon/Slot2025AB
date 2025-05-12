/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SierraStar : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public Sink KindLate;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect CenterBold;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Primary;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Captain= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float LargeWedge;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float LargeCobalt;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int AcidityWhale;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool BeCorp= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int FollyMagic;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int KillMagic;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float KindCobalt= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<Sink> KindHart;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<Sink> AcidityHart;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> LegHart;

    void Start()
    {
        LargeCobalt = this.GetComponent<RectTransform>().sizeDelta.y;
        LargeWedge = this.GetComponent<RectTransform>().sizeDelta.x;
        Primary = CenterBold.content;
        WoolCopy();

    }
    //初始化
    public void WoolCopy()
    {
        AcidityWhale = Mathf.CeilToInt(LargeCobalt / CityCobalt) + 1;
        for (int i = 0; i < AcidityWhale; i++)
        {
            this.RotSink();
        }
        FollyMagic = 0;
        KillMagic = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        MadCopy(numberList);
    }
    //设置数据
    void MadCopy(List<int> list)
    {
        LegHart = list;
        FollyMagic = 0;
        if (CopyWhale <= AcidityWhale)
        {
            KillMagic = CopyWhale;
        }
        else
        {
            KillMagic = AcidityWhale - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = FollyMagic; i < KillMagic; i++)
        {
            Sink obj = InkSink();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * CityCobalt, 0);
                AcidityHart.Add(obj);
                TurkicSink(i, obj);
            }

        }
        Primary.sizeDelta = new Vector2(LargeWedge, CopyWhale * CityCobalt - Captain);
        BeCorp = true;
    }
    //更新item
    public void TurkicSink(int index, Sink obj)
    {
        int d = LegHart[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public Sink InkSink()
    {
        Sink obj = null;
        if (KindHart.Count > 0)
        {
            obj = KindHart[0];
            obj.gameObject.SetActive(true);
            KindHart.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void YuanSink(Sink obj)
    {
        KindHart.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int CopyWhale    {
        get
        {
            return LegHart.Count;
        }
    }
    //每一行的高
    public float CityCobalt    {
        get
        {
            return KindCobalt + Captain;
        }
    }
    //添加item到缓存列表中
    public void RotSink()
    {
        GameObject obj = Instantiate(KindLate.gameObject);
        obj.transform.SetParent(Primary);
        RectTransform Pull= obj.GetComponent<RectTransform>();
        Pull.anchorMin = new Vector2(0.5f, 1);
        Pull.anchorMax = new Vector2(0.5f, 1);
        Pull.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        Sink o = obj.GetComponent<Sink>();
        KindHart.Add(o);
    }



    void Update()
    {
        if (BeCorp)
        {
            Sierra();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Sierra()
    {
        float vy = Primary.anchoredPosition.y;
        float rollUpTop = (FollyMagic + 1) * CityCobalt;
        float rollUnderTop = FollyMagic * CityCobalt;

        if (vy > rollUpTop && KillMagic < CopyWhale)
        {
            //上边界移除
            if (AcidityHart.Count > 0)
            {
                Sink obj = AcidityHart[0];
                AcidityHart.RemoveAt(0);
                YuanSink(obj);
            }
            FollyMagic++;
        }
        float rollUpBottom = (KillMagic - 1) * CityCobalt - Captain;
        if (vy < rollUpBottom - LargeCobalt && FollyMagic > 0)
        {
            //下边界减少
            KillMagic--;
            if (AcidityHart.Count > 0)
            {
                Sink obj = AcidityHart[AcidityHart.Count - 1];
                AcidityHart.RemoveAt(AcidityHart.Count - 1);
                YuanSink(obj);
            }

        }
        float rollUnderBottom = KillMagic * CityCobalt - Captain;
        if (vy > rollUnderBottom - LargeCobalt && KillMagic < CopyWhale)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            Sink go = InkSink();
            AcidityHart.Add(go);
            go.transform.localPosition = new Vector3(0, -KillMagic * CityCobalt);
            TurkicSink(KillMagic, go);
            KillMagic++;
        }


        if (vy < rollUnderTop && FollyMagic > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            FollyMagic--;
            Sink go = InkSink();
            AcidityHart.Insert(0, go);
            TurkicSink(FollyMagic, go);
            go.transform.localPosition = new Vector3(0, -FollyMagic * CityCobalt);
        }

    }
}
