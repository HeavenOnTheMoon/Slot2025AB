﻿/// <summary>
/// 本地数据管理类 
/// 
/// 引擎自带的存储数据
/// 
/// </summary>
using System;
using UnityEngine;
public class GripCopyVaguely
{

    /// <summary>
    /// 储存Bool
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadLeft(string key, bool value)
    {
        PlayerPrefs.SetString(key + "Bool", value.ToString());
    }

    /// <summary>
    /// 取Bool
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static bool LawLeft(string key)
    {
        try
        {
            return bool.Parse(PlayerPrefs.GetString(key + "Bool"));
        }
        catch (Exception e)
        {
            Debug.Log("SaveDataManager中获取" + key + "的bool类型值出现错误,详细信息：" + e);
            return false;
        }

    }


    /// <summary>
    /// 储存String
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadExcess(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    /// <summary>
    /// 取String
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static string LawExcess(string key)
    {
        return PlayerPrefs.GetString(key);
    }

    /// <summary>
    /// 储存Float
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadAlarm(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
    }

    /// <summary>
    /// 取Float
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static float LawAlarm(string key)
    {
        return PlayerPrefs.GetFloat(key);
    }

    /// <summary>
    /// 储存Int
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadAid(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
    }


    /// <summary>
    /// 取Int
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static int LawAid(string key)
    {
        return PlayerPrefs.GetInt(key);
    }



    /// <summary>
    /// 储存IntArray
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadAidGrope(string key, int[] value)
    {

        for (int i = 0; i < value.Length; i++)
        {
            PlayerPrefs.SetInt(key + "IntArray" + i, value[i]);
        }
        PlayerPrefs.SetInt(key + "IntArray", value.Length);
    }

    /// <summary>
    /// 取IntArray
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static int[] LawAidGrope(string key)
    {
        int[] intArr = new int[0];
        if (PlayerPrefs.GetInt(key + "IntArray") != 0)
        {
            intArr = new int[PlayerPrefs.GetInt(key + "IntArray")];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = PlayerPrefs.GetInt(key + "IntArray" + i);
            }
        }
        return intArr;
    }

    /// <summary>
    /// 储存FloatArray
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadAlarmGrope(string key, float[] value)
    {

        for (int i = 0; i < value.Length; i++)
        {
            PlayerPrefs.SetFloat(key + "FloatArray" + i, value[i]);
        }
        PlayerPrefs.SetInt(key + "FloatArray", value.Length);
    }

    /// <summary>
    /// 取FloatArray
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static float[] LawAlarmGrope(string key)
    {
        float[] floatArr = new float[0];
        if (PlayerPrefs.GetInt(key + "FloatArray") != 0)
        {
            floatArr = new float[PlayerPrefs.GetInt(key + "FloatArray")];
            for (int i = 0; i < floatArr.Length; i++)
            {
                floatArr[i] = PlayerPrefs.GetFloat(key + "FloatArray" + i);
            }
        }
        return floatArr;
    }


    /// <summary>
    /// 储存StringArray
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadExcessGrope(string key, string[] value)
    {

        for (int i = 0; i < value.Length; i++)
        {
            PlayerPrefs.SetString(key + "StringArray" + i, value[i]);
        }
        PlayerPrefs.SetInt(key + "StringArray", value.Length);
    }

    /// <summary>
    /// 取StringArray
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static string[] LawExcessGrope(string key)
    {
        string[] stringArr = new string[0];
        if (PlayerPrefs.GetInt(key + "StringArray") != 0)
        {
            stringArr = new string[PlayerPrefs.GetInt(key + "StringArray")];
            for (int i = 0; i < stringArr.Length; i++)
            {
                stringArr[i] = PlayerPrefs.GetString(key + "StringArray" + i);
            }
        }
        return stringArr;
    }


    /// <summary>
    /// 储存Vector2
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadVector2(string key, Vector2 value)
    {
        PlayerPrefs.SetFloat(key + "Vector2X", value.x);
        PlayerPrefs.SetFloat(key + "Vector2Y", value.y);

    }

    /// <summary>
    /// 取Vector2
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static Vector2 LawSeduce2(string key)
    {
        Vector2 Vector2;
        Vector2.x = PlayerPrefs.GetFloat(key + "Vector2X");
        Vector2.y = PlayerPrefs.GetFloat(key + "Vector2Y");
        return Vector2;
    }


    /// <summary>
    /// 储存Vector3
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadVector3(string key, Vector3 value)
    {
        PlayerPrefs.SetFloat(key + "Vector3X", value.x);
        PlayerPrefs.SetFloat(key + "Vector3Y", value.y);
        PlayerPrefs.SetFloat(key + "Vector3Z", value.z);
    }

    /// <summary>
    /// 取Vector3
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static Vector3 LawSeduce3(string key)
    {
        Vector3 vector3;
        vector3.x = PlayerPrefs.GetFloat(key + "Vector3X");
        vector3.y = PlayerPrefs.GetFloat(key + "Vector3Y");
        vector3.z = PlayerPrefs.GetFloat(key + "Vector3Z");
        return vector3;
    }


    /// <summary>
    /// 储存Quaternion
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    public static void MadProprietor(string key, Quaternion value)
    {
        PlayerPrefs.SetFloat(key + "QuaternionX", value.x);
        PlayerPrefs.SetFloat(key + "QuaternionY", value.y);
        PlayerPrefs.SetFloat(key + "QuaternionZ", value.z);
        PlayerPrefs.SetFloat(key + "QuaternionW", value.w);
    }

    /// <summary>
    /// 取Quaternion
    /// </summary>
    /// <param name="key">键</param>
    /// <returns></returns>
    public static Quaternion LawProprietor(string key)
    {
        Quaternion quaternion;
        quaternion.x = PlayerPrefs.GetFloat(key + "QuaternionX");
        quaternion.y = PlayerPrefs.GetFloat(key + "QuaternionY");
        quaternion.z = PlayerPrefs.GetFloat(key + "QuaternionZ");
        quaternion.w = PlayerPrefs.GetFloat(key + "QuaternionW");
        return quaternion;
    }

    public static void MadSummer(string key, double value)
    {
        PlayerPrefs.SetString(key, value.ToString());
    }

    public static double LawSummer(string key)
    {
        string s = PlayerPrefs.GetString(key);
        double result = 0;
        if (!double.TryParse(s, out result))
        {
            s = s.Replace(",", ".");
            double.TryParse(s, out result);
        }
        return string.IsNullOrEmpty(s) ? 0 : result;
    }
}

