/*
 * 
 * 
 * Unity帮助脚本
 * 功能：提供程序用户一些常用的功能方法实现，快速开发
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeReport : MonoBehaviour
{
    /// <summary>
    /// 查找子节点对象
    /// 内部使用递归
    /// </summary>
    /// <param name="goParent">父对象</param>
    /// <param name="childName">查找子对象的名称</param>
    /// <returns></returns>
    public static Transform LaceSacKneelBust(GameObject goParent,string childName)
    {
        //查找结果
        Transform searchTrans = null;
        searchTrans = goParent.transform.Find(childName);
        if (searchTrans == null)
        {
            foreach (Transform trans in goParent.transform)
            {
                searchTrans = LaceSacKneelBust(trans.gameObject, childName);
                if (searchTrans != null)
                {
                    return searchTrans;
                }
            }
        }
        return searchTrans;
    }

    /// <summary>
    /// 获取子节点对象脚本
    /// </summary>
    /// <typeparam name="T">泛型</typeparam>
    /// <param name="goParent">父对象</param>
    /// <param name="childName">子对象名称</param>
    /// <returns></returns>
    public static T LawSacKneelBustOutnumberUnaided<T>(GameObject goParent,string childName) where T:Component
    {
        //查找特定子节点
        Transform searchTranformNode = null;
        searchTranformNode = LaceSacKneelBust(goParent, childName);
        if (searchTranformNode != null)
        {
            return searchTranformNode.gameObject.GetComponent<T>();
        }
        else
        {
            return null;

        }
    }

    /// <summary>
    /// 给子节点添加脚本
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="goParent">父对象</param>
    /// <param name="childName">子对象名称</param>
    /// <returns></returns>
    public static T RotKneelBustOutnumber<T>(GameObject goParent,string childName) where T : Component
    {
        Transform searchTransform = null;
        searchTransform = LaceSacKneelBust(goParent, childName);
        if (searchTransform != null)
        {
            T[] componentScriptsArray = searchTransform.GetComponents<T>();
            for(int i = 0; i < componentScriptsArray.Length; i++)
            {
                if (componentScriptsArray[i] != null)
                {
                    Destroy(componentScriptsArray[i]);
                }
            }
            return searchTransform.gameObject.AddComponent<T>();
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// 给子节点添加父对象
    /// </summary>
    /// <param name="parents">父对象</param>
    /// <param name="child"></param>
    public static void RotKneelBustMyObsessBust(Transform parents,Transform child)
    {
        child.SetParent(parents, false);
        child.localPosition = Vector3.zero;
        child.localScale = Vector3.one;
        child.localEulerAngles = Vector3.zero;
    }

    /// <summary>
    /// 更高辨识度的log
    /// </summary>
    /// <param name="log">log内容</param>
    /// <param name="color">颜色 0黄 1青 2绿 3蓝 10红</param>
    public static void Steep(object log, int color = 0)
    {
        if (color == 0)
            print("<color=yellow><b>+++++   " + log + "</b></color>");
        else if (color == 1)
            print("<color=cyan><b>+++++   " + log + "</b></color>");
        else if (color == 2)
            print("<color=green><b>+++++   " + log + "</b></color>");
        else if (color == 3)
            print("<color=blue><b>+++++   " + log + "</b></color>");
        else if (color == 10)
            print("<color=red><b>+++++   " + log + "</b></color>");
    }
}
