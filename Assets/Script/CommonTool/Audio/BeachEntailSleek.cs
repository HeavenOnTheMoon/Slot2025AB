/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BeachEntailSleek 
{
    //音乐的管理者
    private GameObject BeachYet;
    //音乐组件管理队列
    private List<AudioSource> BeachOutnumberSleek;
    //音乐组件默认容器最大值  
    private int SheWhale= 25;
    public BeachEntailSleek(GlobeYet audioMgr)
    {
        BeachYet = audioMgr.gameObject;
        WoolBeachEntailSleek();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void WoolBeachEntailSleek()
    {
        BeachOutnumberSleek = new List<AudioSource>();
        for(int i = 0; i < SheWhale; i++)
        {
            RotBeachEntailForWishYet();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource RotBeachEntailForWishYet()
    {
        AudioSource audio = BeachYet.AddComponent<AudioSource>();
        BeachOutnumberSleek.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource LawBeachOutnumber()
    {
        if (BeachOutnumberSleek.Count > 0)
        {
            AudioSource audio = BeachOutnumberSleek.Find(t => !t.isPlaying);
            if (audio)
            {
                BeachOutnumberSleek.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return RotBeachEntailForWishYet();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  RotBeachEntailForWishYet();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void OfPegBeachOutnumber(AudioSource audio)
    {
        if (BeachOutnumberSleek.Contains(audio)) return;
        if (BeachOutnumberSleek.Count >= SheWhale)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            BeachOutnumberSleek.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
