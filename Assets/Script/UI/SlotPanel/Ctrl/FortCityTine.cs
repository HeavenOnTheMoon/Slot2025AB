using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortCityTine : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("LineParent")]    public GameObject CityObsess;
[UnityEngine.Serialization.FormerlySerializedAs("LineItem")]    public GameObject CitySink;
    //�ߵĶ����
    private SourceDraw _CitySinkDraw;
    /// <summary>
    /// ���ֵ���
    /// </summary>
    private List<FortCitySink> Hart_FortCitySink;


    private void Start()
    {
        Hart_FortCitySink = new();
        CitySinkDrawWool();
    }


    /// <summary>
    /// ���ߵ���ʾ
    /// </summary>
    public void FortMeadowCityFair(Dictionary<int, AwardWinningData> data)
    {
        /*SlotRewardLineHide();
        foreach (var item in data)
        {
            GameObject obj = _LineItemPool.Get();
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one * 0.65f;
            FortCitySink line = obj.GetComponent<FortCitySink>();
            line.SetLineItemInfo(item.Key);
            line.gameObject.SetActive(false);
            List_SlotLineItem.Add(line);
        }
        if (List_SlotLineItem.Count > 0)
        {
            StartCoroutine(nameof(LoopDisplayLine));
        }*/
    }

    IEnumerator JoltEpithetCity()
    {
        int index = 0;
        while (true)
        {
            OneLineDisplay(index);
            index++;
            if (index >= Hart_FortCitySink.Count)
            {
                yield return new WaitForSeconds(1.5f);
                index = 0;
                CityEpithetPalimpsest(true);
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    /// <summary>
    /// ��������ʾ
    /// </summary>
    /// <param name="index"></param>

    private void OneLineDisplay(int index)
    {
        CityEpithetPalimpsest(false);
        Hart_FortCitySink[index].gameObject.SetActive(true);
    }

    /// <summary>
    /// ���н����߶εĿ���
    /// </summary>
    /// <param name="isShow"></param>
    private void CityEpithetPalimpsest(bool isShow)
    {
        for (int i = 0; i < Hart_FortCitySink.Count; i++)
        {
            Hart_FortCitySink[i].gameObject.SetActive(isShow);
        }
    }

    /// <summary>
    /// �����ߵ����
    /// </summary>
    public void FortMeadowCityFund()
    {
        /*StopCoroutine(nameof(LoopDisplayLine));
        for (int i = 0; i < List_SlotLineItem.Count; i++)
        {
            _LineItemPool.Recycle(List_SlotLineItem[i].gameObject);
        }
        List_SlotLineItem.Clear();*/
    }

    private void CitySinkDrawWool()
    {
        _CitySinkDraw = new SourceDraw();
        _CitySinkDraw.Wool("LineItemPool", CityObsess.transform);
        _CitySinkDraw.Autumn = CitySink;
    }

}
