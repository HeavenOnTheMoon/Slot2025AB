/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class SpyOvalLawSource 
{
    //get的url
    public string How;
    //get成功的回调
    public Action<UnityWebRequest> LawToehold;
    //get失败的回调
    public Action LawPine;
    public SpyOvalLawSource(string url,Action<UnityWebRequest> success,Action fail)
    {
        How = url;
        LawToehold = success;
        LawPine = fail;
    }
   
}
