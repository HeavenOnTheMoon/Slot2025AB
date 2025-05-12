/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainlandYet 
{
    public static MainlandYet _Instatnce;
    //语言翻译的缓存集合
    private Dictionary<string, string> _RayMainlandWeird;

    private MainlandYet()
    {
        _RayMainlandWeird = new Dictionary<string, string>();
        //初始化语言缓存集合
        WoolMainlandWeird();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static MainlandYet LawFigurine()
    {
        if (_Instatnce == null)
        {
            _Instatnce = new MainlandYet();
        }
        return _Instatnce;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string FairMine(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_RayMainlandWeird!=null && _RayMainlandWeird.Count >= 1)
        {
            _RayMainlandWeird.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void WoolMainlandWeird()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        ILazilyVaguely config = new LazilyVaguelySoCrab("LauguageJSONConfig");
        if (config != null)
        {
            _RayMainlandWeird = config.DigUseless;
        }
    }
}
