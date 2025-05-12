using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息传递的参数
/// </summary>
public class RewriteCopy
{
    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */
    public bool FiordLeft;
    public bool FiordLeft2;
    public int FiordAid;
    public int FiordAid2;
    public int FiordAid3;
    public float FiordAlarm;
    public float FiordAlarm2;
    public double FiordSummer;
    public double FiordSummer2;
    public string FiordExcess;
    public string FiordExcess2;
    public GameObject FiordFistSource;
    public GameObject FiordFistSource2;
    public GameObject FiordFistSource3;
    public GameObject FiordFistSource4;
    public Transform FiordObedience;
    public List<string> FiordExcessHart;
    public List<Vector2> FiordAla2Hart;
    public List<int> FiordAidHart;
    public System.Action EncloseMeltChop;
    public Vector2 Elk2_1;
    public Vector2 Elk2_2;
    public RewriteCopy()
    {
    }
    public RewriteCopy(Vector2 v2_1)
    {
        Elk2_1 = v2_1;
    }
    public RewriteCopy(Vector2 v2_1, Vector2 v2_2)
    {
        Elk2_1 = v2_1;
        Elk2_2 = v2_2;
    }
    /// <summary>
    /// 创建一个带bool类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public RewriteCopy(bool value)
    {
        FiordLeft = value;
    }
    public RewriteCopy(bool value, bool value2)
    {
        FiordLeft = value;
        FiordLeft2 = value2;
    }
    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public RewriteCopy(int value)
    {
        FiordAid = value;
    }
    public RewriteCopy(int value, int value2)
    {
        FiordAid = value;
        FiordAid2 = value2;
    }
    public RewriteCopy(int value, int value2, int value3)
    {
        FiordAid = value;
        FiordAid2 = value2;
        FiordAid3 = value3;
    }
    public RewriteCopy(List<int> value,List<Vector2> value2)
    {
        FiordAidHart = value;
        FiordAla2Hart = value2;
    }
    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public RewriteCopy(float value)
    {
        FiordAlarm = value;
    }
    public RewriteCopy(float value,float value2)
    {
        FiordAlarm = value;
        FiordAlarm = value2;
    }
    /// <summary>
    /// 创建一个带double类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public RewriteCopy(double value)
    {
        FiordSummer = value;
    }
    public RewriteCopy(double value, double value2)
    {
        FiordSummer = value;
        FiordSummer = value2;
    }
    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    public RewriteCopy(string value)
    {
        FiordExcess = value;
    }
    /// <summary>
    /// 创建两个带string类型的数据
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    public RewriteCopy(string value1,string value2)
    {
        FiordExcess = value1;
        FiordExcess2 = value2;
    }
    public RewriteCopy(GameObject value1)
    {
        FiordFistSource = value1;
    }

    public RewriteCopy(Transform transform)
    {
        FiordObedience = transform;
    }
}

