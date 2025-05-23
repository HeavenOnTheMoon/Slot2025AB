﻿/**
 * 
 * 网络请求管理器
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpyOvalVaguely : EarnCommunity<SpyOvalVaguely>
{
    //get请求列表
    private List<SpyOvalLawSource> SpyOvalLawHart;
    //post请求列表
    private List<SpyOvalPageSource> SpyOvalPageHart;
    public SpyOvalVaguely()
    {
        //初始化
        SpyOvalLawHart = new List<SpyOvalLawSource>();
        SpyOvalPageHart = new List<SpyOvalPageSource>();
    }

    /// <summary>
    /// 获取当前Get请求列表中请求的个数
    /// </summary>
    public int LawSpyOvalLawHartWhale    {
        get { return SpyOvalLawHart.Count; }
    }

    /// <summary>
    /// 获取当前Post请求列表中请求的个数
    /// </summary>
    public int LawSpyOvalPageHartWhale    {
        get { return SpyOvalPageHart.Count; }
    }

    /// <summary>
    /// Get请求
    /// </summary>
    /// <param name="url">Get请求的URL</param>
    /// <param name="success">Get请求成功的回调</param>
    /// <param name="fail">Get请求失败的回调</param>
    public void PackLaw(string url, Action<UnityWebRequest> success, Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpGet请求URL地址不能为空");
            return;
        }
        SpyOvalLawSource o = new SpyOvalLawSource(url, success, fail);
        //添加到管理列表中
        SpyOvalLawHart.Add(o);
        //开始请求
        StartCoroutine(nameof(Law), o);
    }

    /// <summary>
    /// Post请求
    /// </summary>
    /// <param name="url">Post请求的URL</param>
    /// <param name="form">Post请求的表单数据</param>
    /// <param name="success">Post请求成功的回调</param>
    /// <param name="fail">Post请求失败的回调</param>
    public void PackPage(string url, WWWForm form, Action<UnityWebRequest> success, Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpPost请求URL地址不能为空");
            return;
        }
        SpyOvalPageSource o = new SpyOvalPageSource(url, form, success, fail);
        //添加到post请求管理列表中
        SpyOvalPageHart.Add(o);
        //开始请求
        StartCoroutine(nameof(Page), o);
    }

    /// <summary>
    /// Get请求的协程
    /// </summary>
    /// <param name="obj">Get请求对象</param>
    /// <returns></returns>
    IEnumerator Law(SpyOvalLawSource obj)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(obj.How);
        webRequest.SendWebRequest();
        while (!webRequest.isDone)
        {
            yield return 1;
        }
        if (webRequest.isDone)
        {
            //从管理列表中移除
            if (SpyOvalLawHart.Contains(obj))
            {
                SpyOvalLawHart.Remove(obj);
            }
        }
        //yield return webRequest.SendWebRequest();
        //异常处理,请求失败
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("请求" + obj.How + "失败，错误：" + webRequest.error);
            obj.LawPine();
        }
        else
        {
            //Debug.Log(webRequest.downloadHandler.text);
            obj.LawToehold(webRequest);
        }
        //终止本次协程
        yield break;
    }



    /// <summary>
    /// Post协程
    /// </summary>
    /// <returns></returns>
    IEnumerator Page(SpyOvalPageSource obj)
    {
        //WWWForm form = new WWWForm();
        ////键值对
        //form.AddField("key", "value");
        //form.AddField("name", "mafanwei");
        //form.AddField("blog", "qwe25878");

        UnityWebRequest webRequest = UnityWebRequest.Post(obj.URL, obj.Pram);

        yield return webRequest.SendWebRequest();
        //异常处理
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("Post请求" + obj.URL + "失败，错误：" + webRequest.error);
            obj.PagePine();
        }
        else
        {
            obj.PageToehold(webRequest);
            //Debug.Log(webRequest.downloadHandler.text);
        }

        //从管理列表中移除
        if (SpyOvalPageHart.Contains(obj))
        {
            SpyOvalPageHart.Remove(obj);
        }
        //终止本次协程
        yield break;
    }
}
