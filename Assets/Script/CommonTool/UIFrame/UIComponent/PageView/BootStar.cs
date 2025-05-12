/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class BootStar : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Pull;
    //求出每页的临界角，页索引从0开始
    List<float> JarHart= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool BePlus= false;
    bool ExpoPeak= true;
    //滑动的起始坐标  
    float AshoreEquivalent= 0;
    float FollyPlusEquivalent;
    float startTime = 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Emphasis= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Prohibitive= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> OnBootGather;
    //当前页面下标
    int BluefinBootMagic= -1;
    void Start()
    {
        Pull = this.GetComponent<ScrollRect>();
        float horizontalLength = Pull.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        JarHart.Add(0);
        for(int i = 1; i < Pull.content.childCount - 1; i++)
        {
            JarHart.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        JarHart.Add(1);
    }

    
    void Update()
    {
        if(!BePlus && !ExpoPeak)
        {
            startTime += Time.deltaTime;
            float t = startTime * Emphasis;
            Pull.horizontalNormalizedPosition = Mathf.Lerp(Pull.horizontalNormalizedPosition, AshoreEquivalent, t);
            if (t >= 1)
            {
                ExpoPeak = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void MadBootMagic(int index)
    {
        if (BluefinBootMagic != index)
        {
            BluefinBootMagic = index;
            if (OnBootGather != null)
            {
                OnBootGather(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        BePlus = true;
        FollyPlusEquivalent = Pull.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float JarX= Pull.horizontalNormalizedPosition;
        JarX += ((JarX - FollyPlusEquivalent) * Prohibitive);
        JarX = JarX < 1 ? JarX : 1;
        JarX = JarX > 0 ? JarX : 0;
        int index = 0;
        float offset = Mathf.Abs(JarHart[index] - JarX);
        for(int i = 0; i < JarHart.Count; i++)
        {
            float temp = Mathf.Abs(JarHart[i] - JarX);
            if (temp < offset)
            {
                index = i;
                offset = temp;
            }
        }
        MadBootMagic(index);
        AshoreEquivalent = JarHart[index];
        BePlus = false;
        startTime = 0f;
        ExpoPeak = false;
    }
}
