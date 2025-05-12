using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortCityVaguely : EarnCommunity<FortCityVaguely>
{
    public List<Sprite> Hart_CitySlice;
    protected override void Awake()
    {
        base.Awake();
    }

    /// <summary>
    /// ��ȡ�ߵ�ͼƬ
    /// </summary>
    public Sprite LawFortCityDuring(int index)
    {
        return index >= Hart_CitySlice.Count ? Hart_CitySlice[0] : Hart_CitySlice[index];
    }
}
