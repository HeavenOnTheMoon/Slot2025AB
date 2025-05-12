using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmCoachTine : MonoBehaviour
{
    public static CharmCoachTine Instance;
[UnityEngine.Serialization.FormerlySerializedAs("BonusSliderParent")]    public GameObject CharmCoerceObsess;
[UnityEngine.Serialization.FormerlySerializedAs("CharmSink")]    public GameObject CharmSink;
[UnityEngine.Serialization.FormerlySerializedAs("BonusTitleParent")]    public GameObject CharmSpiteObsess;
    private SourceDraw _CharmDraw;
    private List<GameObject> _Hart_CharmSink;

    private readonly object _Heel= new object();

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        CharmDrawWool();
        _Hart_CharmSink = new List<GameObject>();
        MadCharmLittle(FortCopyVaguely.instance.LeoCharmLittle);
        RewriteNeuronNiche.LawFigurine().Alphabet("SendBonusNumber", OnBonusNumberUpdate);
    }

    private void OnBonusNumberUpdate(RewriteCopy obj)
    {
        lock (_Heel)
        {
            MadCharmLittle(obj.FiordAid);
        }
        
    }

    private void MadCharmLittle(int index)
    {
        int Effect= index;
        
        for (int i = 0; i < _Hart_CharmSink.Count; i++)
        {
            _CharmDraw.Leaning(_Hart_CharmSink[i]);
        }
        _Hart_CharmSink.Clear();
       
        for (int i = 0; i < index; i++)
        {
            var temp = _CharmDraw.Law();
            temp.transform.localScale = Vector3.one;
            temp.GetComponent<CharmSink>().ComicCharmMine();//SetBonusText(num);
            _Hart_CharmSink.Add(temp);
        }

        /*StopCoroutine(nameof(ShowBonusText));
        StartCoroutine(nameof(ShowBonusText));*/
        for (int i = 0; i < _Hart_CharmSink.Count; i++)
        {
            if (i == _Hart_CharmSink.Count - 1)
            {
                _Hart_CharmSink[i].GetComponent<CharmSink>().MadCharmMine(_Hart_CharmSink.Count);
            }
            else
            {
                _Hart_CharmSink[i].GetComponent<CharmSink>().ComicCharmMine();
            }
        }
    }


    IEnumerator FairCharmMine()
    {
        yield return new WaitForSeconds(0.1f);
        for (int i = 0; i < _Hart_CharmSink.Count; i++)
        {
            if (i == _Hart_CharmSink.Count - 1)
            {
                _Hart_CharmSink[i].GetComponent<CharmSink>().MadCharmMine(_Hart_CharmSink.Count);
            }
            else
            {
                _Hart_CharmSink[i].GetComponent<CharmSink>().ComicCharmMine();
            }
        }
    }

    private void CharmDrawWool()
    {
        _CharmDraw = new SourceDraw();
        _CharmDraw.Wool("BonusPool",CharmCoerceObsess.transform);
        _CharmDraw.Autumn = CharmSink;
    }

}
