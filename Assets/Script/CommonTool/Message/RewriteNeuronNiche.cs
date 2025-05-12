using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class RewriteNeuronNiche:EarnCommunity<RewriteNeuronNiche>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<RewriteCopy>> ApplicableRewrite;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private RewriteNeuronNiche()
    {
        WoolCopy();
    }

    private void WoolCopy()
    {
        //初始化消息字典
        ApplicableRewrite = new Dictionary<string, Action<RewriteCopy>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Alphabet(string key, Action<RewriteCopy> action)
    {
        if (!ApplicableRewrite.ContainsKey(key))
        {
            ApplicableRewrite.Add(key, null);
        }
        ApplicableRewrite[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Spinet(string key, Action<RewriteCopy> action)
    {
        if (ApplicableRewrite.ContainsKey(key) && ApplicableRewrite[key] != null)
        {
            ApplicableRewrite[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Seat(string key, RewriteCopy data = null)
    {
        if (ApplicableRewrite.ContainsKey(key) && ApplicableRewrite[key] != null)
        {
            ApplicableRewrite[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void Aphid()
    {
        ApplicableRewrite.Clear();
    }
}
