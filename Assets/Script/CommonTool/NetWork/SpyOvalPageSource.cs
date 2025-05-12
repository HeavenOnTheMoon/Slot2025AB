/**
 * 
 * 网络请求的post对象
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class SpyOvalPageSource 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Pram;
    //post成功回调
    public Action<UnityWebRequest> PageToehold;
    //post失败回调
    public Action PagePine;
    public SpyOvalPageSource(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Pram = form;
        PageToehold = success;
        PagePine = fail;
    }
}
