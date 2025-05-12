using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccumulationCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button ComicIts;
[UnityEngine.Serialization.FormerlySerializedAs("LaterBtn")]    public Button BrickIts;
    // Start is called before the first frame update
    void Start()
    {
        ComicIts.onClick.AddListener(() => 
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });
        BrickIts.onClick.AddListener(() => {
            WavyCheer();
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 发邮件
    /// </summary>
    public void WavyCheer()
    {
        //Debug.Log("发邮件");
        Uri uri = new Uri(string.Format("mailto:{0}?subject={1}", SOHOLoamCopyVaguely.instance.DrabJson.email, Application.productName));//第二个参数是邮件的标题
        Application.OpenURL(uri.AbsoluteUri);
    }
}
