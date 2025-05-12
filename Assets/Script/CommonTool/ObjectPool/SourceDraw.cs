/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceDraw 
{
    private Queue<GameObject> m_DrawSleek;
    //池子名称
    private string m_DrawNeon;
    //父物体
    protected Transform m_Obsess;
    //缓存对象的预制体
    private GameObject Regard;
    //最大容量
    private int m_SheWhale;
    //默认最大容量
    protected const int m_YucatanSheWhale= 20;
    public GameObject Autumn    {
        get => Regard;set { Regard = value;  }
    }
    //构造函数初始化
    public SourceDraw()
    {
        m_SheWhale = m_YucatanSheWhale;
        m_DrawSleek = new Queue<GameObject>();
    }
    //初始化
    public virtual void Wool(string poolName,Transform transform)
    {
        m_DrawNeon = poolName;
        m_Obsess = transform;
    }
    //取对象
    public virtual GameObject Law()
    {
        GameObject obj;
        if (m_DrawSleek.Count > 0)
        {
            obj = m_DrawSleek.Dequeue();
        }
        else
        {
            obj = GameObject.Instantiate<GameObject>(Regard);
            obj.transform.SetParent(m_Obsess);
            obj.GetComponent<RectTransform>().localScale = new Vector3(0.6f, 0.6f, 0.6f);
            obj.SetActive(false);
        }
        obj.SetActive(true);
        return obj;
    }
    //回收对象
    public virtual void Leaning(GameObject obj)
    {
        if (m_DrawSleek.Contains(obj)) return;
        if (m_DrawSleek.Count >= m_SheWhale)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_DrawSleek.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void LeaningHim()
    {
        Transform[] child = m_Obsess.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Obsess)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Leaning(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Observe()
    {
        m_DrawSleek.Clear();
    }
}
