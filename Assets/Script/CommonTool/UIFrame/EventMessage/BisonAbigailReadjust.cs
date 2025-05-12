/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BisonAbigailReadjust : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate OfMaybe;
    public VoidDelegate OfWide;
    public VoidDelegate OfTotal;
    public VoidDelegate OfPuff;
    public VoidDelegate OfUp;
    public VoidDelegate OfResent;
    public VoidDelegate OfTurkicResent;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static BisonAbigailReadjust Law(GameObject go)
    {
        BisonAbigailReadjust listener = go.GetComponent<BisonAbigailReadjust>();
        if (listener == null)
        {
            listener = go.AddComponent<BisonAbigailReadjust>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (OfMaybe != null)
        {
            OfMaybe(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (OfWide != null)
        {
            OfWide(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (OfTotal != null)
        {
            OfTotal(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (OfPuff != null)
        {
            OfPuff(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (OfUp != null)
        {
            OfUp(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (OfResent != null)
        {
            OfResent(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (OfTurkicResent != null)
        {
            OfTurkicResent(gameObject);
        }
    }
}
