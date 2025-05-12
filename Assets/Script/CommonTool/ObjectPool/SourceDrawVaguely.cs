/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SourceDrawVaguely : EarnCommunity<SourceDrawVaguely>
{
    //管理objectpool的字典
    private Dictionary<string, SourceDraw> m_DrawRay;
    private Transform m_LarkObedience=null;
    //构造函数
    public SourceDrawVaguely()
    {
        m_DrawRay = new Dictionary<string, SourceDraw>();      
    }
    
    //创建一个新的对象池
    public T RegretSourceDraw<T>(string poolName) where T : SourceDraw, new()
    {
        if (m_DrawRay.ContainsKey(poolName))
        {
            return m_DrawRay[poolName] as T;
        }
        if (m_LarkObedience == null)
        {
            m_LarkObedience = this.transform;
        }      
        GameObject obj = new GameObject(poolName);
        obj.transform.SetParent(UIInject.LawFigurine().WarmGenius.GetComponent<RectTransform>().Find("Normal/MagicSlotGamePanel"));
        obj.transform.localScale = new Vector3(1,1,1);
        T pool = new T();
        pool.Wool(poolName, obj.transform);
        m_DrawRay.Add(poolName, pool);
        return pool;
    }
    //取对象
    public GameObject LawFistSource(string poolName)
    {
        if (m_DrawRay.ContainsKey(poolName))
        {
            return m_DrawRay[poolName].Law();
        }
        return null;
    }
    //回收对象
    public void LeaningFistSource(string poolName,GameObject go)
    {
        if (m_DrawRay.ContainsKey(poolName))
        {
            m_DrawRay[poolName].Leaning(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_DrawRay.Clear();
        GameObject.Destroy(m_LarkObedience);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool ChalkDraw(string poolName)
    {
        return m_DrawRay.ContainsKey(poolName) ? true : false;
    }
}
