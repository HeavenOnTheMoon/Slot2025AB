using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortalJean
{
    /// <summary>
    /// 带权随机
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="objs"></param>
    /// <param name="weights"></param>
    /// <returns></returns>
    public static T LawHeroicMortal<T>(T[] objs, int[] weights)
    {
        int randomIndex = LawHeroicMortalMagic(objs, weights);
        return objs[randomIndex];
    }

    public static int LawHeroicMortalMagic<T>(T[] objs, int[] weights)
    {
        List<int> indexes = new List<int>();
        int totalWeight = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (i >= objs.Length)
            {
                break;
            }
            int weight = weights[i];
            for (int j = 0; j < weight; j++)
            {
                indexes.Add(i);
            }
            totalWeight += weight;
        }

        int randomIndex = Random.Range(0, totalWeight);
        return indexes[randomIndex];
    }

    public static int LawHeroicMortalMagic<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return LawHeroicMortalMagic(keys, values);
    }

    public static T LawHeroicMortal<T>(Dictionary<T, int> dict)
    {
        T[] keys = new T[dict.Count];
        int[] values = new int[dict.Count];
        dict.Keys.CopyTo(keys, 0);
        dict.Values.CopyTo(values, 0);
        return LawHeroicMortal(keys, values);
    }



    public static bool InPrompt(float chance)
    {
        return Random.Range(0, 100) <= chance * 100;
    }
}
