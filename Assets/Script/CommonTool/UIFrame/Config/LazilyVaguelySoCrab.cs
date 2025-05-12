/**

  主题：基于Json 配置文件的“配置管理器” 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazilyVaguelySoCrab : ILazilyVaguely
{
    //保存键值对应用设置集合
    private static Dictionary<string, string> _DigUseless;

    /// <summary>
    /// 只读属性，得到应用设置（键值对集合）
    /// </summary>
    public Dictionary<string, string> DigUseless{
        get { return _DigUseless; }
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="jsonPath">json配置文件路径</param>
    public LazilyVaguelySoCrab(string jsonPath)
    {
        _DigUseless = new Dictionary<string, string>();
        //初始化解析json数据，加载到（_AppSetting）集合
        WoolIcyUnusableCrab(jsonPath);
    }

    /// <summary>
    /// 得到AppSetting的最大数值
    /// </summary>
    /// <returns></returns>
    public int LawDigUselessSheLittle()
    {
        if(_DigUseless!=null && _DigUseless.Count >= 1)
        {
            return _DigUseless.Count;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// 初始化解析json数据，加载到集合
    /// </summary>
    /// <param name="jsonPath"></param>
    private void WoolIcyUnusableCrab(string jsonPath)
    {
        TextAsset configInfo = null;
        KeyValuesInfo keyvalueInfo = null;
        if (string.IsNullOrEmpty(jsonPath)) return;
        //解析json配置文件
        try
        {
            configInfo = Resources.Load<TextAsset>(jsonPath);
            keyvalueInfo = JsonUtility.FromJson<KeyValuesInfo>(configInfo.text);
        }
        catch 
        {
            throw new CrabArticleStimulate(GetType() + "/InitAndAnalysisJson()/Json Analysis Exception ! Parameter jsonPath=" + jsonPath);
        }
        //数据加载到AppSetting集合中
        foreach (KeyValuesNode nodeInfo in keyvalueInfo.ConfigInfo)
        {
            _DigUseless.Add(nodeInfo.Key, nodeInfo.Value);
        }
    }
}
