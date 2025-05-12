/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeYet : EarnCommunity<GlobeYet>
{
    //音频组件管理队列的对象
    private BeachEntailSleek BeachSleek;
    // 用于播放背景音乐的音乐源
    private AudioSource m_GoGlobe= null;
    //播放音效的音频组件管理列表
    private List<AudioSource> ArchBeachEntailHart;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float TrailSeedling= 2f;
    //背景音乐开关
    private bool _BgGlobeOblige;
    //音效开关
    private bool _AdventGlobeOblige;
    //音乐音量
    private float _DyCredit= 1f;
    //音效音量
    private float _AdventCredit= 1f;
    string BGM_Neon= "";

    public Dictionary<string, BeachModel> BeachUselessLady;

    // 控制背景音乐音量大小
    public float DyCredit    {
        get
        {
            return BgGlobeOblige ? JobCredit(BGM_Neon) : 0f;
        }
        set
        {
            _DyCredit = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float AdventLuster    {
        get { return _AdventCredit; }
        set
        {
            _AdventCredit = value;
            MadHimAdventCredit();
        }
    }
    //控制背景音乐开关
    public bool BgGlobeOblige    {
        get
        {

            _BgGlobeOblige = GripCopyVaguely.LawLeft("_BgMusicSwitch");
            return _BgGlobeOblige;
        }
        set
        {
            if (m_GoGlobe)
            {
                _BgGlobeOblige = value;
                GripCopyVaguely.MadLeft("_BgMusicSwitch", _BgGlobeOblige);
                m_GoGlobe.volume = DyCredit;
            }
        }
    }
    public void KeaAndComicRibThey()
    {
        m_GoGlobe.volume = 0;
    }
    public void KeaAndRatchetRibThey()
    {
        m_GoGlobe.volume = DyCredit;
    }
    //控制音效开关
    public bool AdventGlobeOblige    {
        get
        {
            _AdventGlobeOblige = GripCopyVaguely.LawLeft("_EffectMusicSwitch");
            return _AdventGlobeOblige;
        }
        set
        {
            _AdventGlobeOblige = value;
            GripCopyVaguely.MadLeft("_EffectMusicSwitch", _AdventGlobeOblige);

        }
    }
    public GlobeYet()
    {
        ArchBeachEntailHart = new List<AudioSource>();
    }
    protected override void Awake()
    {
        if (!PlayerPrefs.HasKey("first_music_setBool") || !GripCopyVaguely.LawLeft("first_music_set"))
        {
            GripCopyVaguely.MadLeft("first_music_set", true);
            GripCopyVaguely.MadLeft("_BgMusicSwitch", true);
            GripCopyVaguely.MadLeft("_EffectMusicSwitch", true);
        }
        BeachSleek = new BeachEntailSleek(this);

        TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
        BeachUselessLady = JsonMapper.ToObject<Dictionary<string, BeachModel>>(json.text);
    }
    private void Start()
    {
        StartCoroutine(nameof(TrailOfPegBeachOutnumber));
    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator TrailOfPegBeachOutnumber()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(TrailSeedling);
            for (int i = 0; i < ArchBeachEntailHart.Count; i++)
            {
                //防止数据越界
                if (i < ArchBeachEntailHart.Count)
                {
                    //确保物体存在
                    if (ArchBeachEntailHart[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((ArchBeachEntailHart[i].clip == null || !ArchBeachEntailHart[i].isPlaying))
                        {
                            //返回队列
                            BeachSleek.OfPegBeachOutnumber(ArchBeachEntailHart[i]);
                            //从播放列表中删除
                            ArchBeachEntailHart.Remove(ArchBeachEntailHart[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        ArchBeachEntailHart.Remove(ArchBeachEntailHart[i]);
                    }
                }

            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void MadHimAdventCredit()
    {
        for (int i = 0; i < ArchBeachEntailHart.Count; i++)
        {
            if (ArchBeachEntailHart[i] && ArchBeachEntailHart[i].isPlaying)
            {
                ArchBeachEntailHart[i].volume = _AdventGlobeOblige ? _AdventCredit : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void ArchDyLeft(object bgName, bool restart = false)
    {

        BGM_Neon = bgName.ToString();
        if (m_GoGlobe == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_GoGlobe = BeachSleek.LawBeachOutnumber();
            //开启循环
            m_GoGlobe.loop = true;
            //开始播放
            m_GoGlobe.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!BgGlobeOblige)
        {
            m_GoGlobe.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_GoGlobe.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_GoGlobe.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        AudioClip clip = Resources.Load<AudioClip>(BeachUselessLady[BGM_Neon].filePath);
        if (RetoolJean.MyEnsue())
        {
            if (clip.name == "bgm")
                clip = Resources.Load<AudioClip>("Audio/SceneMusic/NightClubBgm");
        }
        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_GoGlobe.clip = clip;
            m_GoGlobe.volume = DyCredit;
            m_GoGlobe.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_GoGlobe.isPlaying)
            {
                m_GoGlobe.Stop();
            }
            m_GoGlobe.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void ArchAdventLeft(object effectName, bool defAudio = true, float volume = 1f, bool loop = false)
    {
        if (!AdventGlobeOblige)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = BeachSleek.LawBeachOutnumber();
        if (m_effectMusic.isPlaying)
        {
            //Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = JobCredit(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        AudioClip clip = Resources.Load<AudioClip>(BeachUselessLady[effectName.ToString()].filePath);
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            //UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            BeachSleek.OfPegBeachOutnumber(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        ArchBeachEntailHart.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            if (!loop)
                m_effectMusic.PlayOneShot(clip, volume);
            else
                m_effectMusic.Play();
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void ArchDy(GlobeThus.UIMusic bgName, bool restart = false)
    {
        ArchDyLeft(bgName, restart);
    }

    public void ArchDy(GlobeThus.SceneMusic bgName, bool restart = false)
    {
        ArchDyLeft(bgName, restart);
    }

    private void HardAdventLeft(object effectName)
    {
        /*if (!EffectMusicSwitch)
        {
            return;
        }*/
        for (int i = 0; i < ArchBeachEntailHart.Count; i++)
        {

            if (ArchBeachEntailHart[i].clip.name == BeachUselessLady[effectName.ToString()].filePath.Replace("Audio/UIMusic/", ""))
            {
                ArchBeachEntailHart[i].Stop();
            }
        }
    }
    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void ArchAdvent(GlobeThus.UIMusic effectName, bool defAudio = true, float volume = 1f, bool loop = false)
    {
        ArchAdventLeft(effectName, defAudio, volume);
    }

    public void ArchAdvent(GlobeThus.SceneMusic effectName, bool defAudio = true, float volume = 1f, bool loop = false)
    {
        ArchAdventLeft(effectName, defAudio, volume);
    }
    float JobCredit(string name)
    {
        if (BeachUselessLady == null)
        {
            TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
            BeachUselessLady = JsonMapper.ToObject<Dictionary<string, BeachModel>>(json.text);
        }

        if (BeachUselessLady.ContainsKey(name))
        {
            return (float)BeachUselessLady[name].volume;

        }
        else
        {
            return 1;
        }
    }
    public void HardAdvent(GlobeThus.UIMusic effectName)
    {
        HardAdventLeft(effectName);
    }

}