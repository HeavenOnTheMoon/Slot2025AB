using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortVenomCharmCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("BounsParent")]    public GameObject DramaObsess;
[UnityEngine.Serialization.FormerlySerializedAs("BounsItem")]    public GameObject DramaSink;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]    public RectTransform Moraine;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Time")]    public Text Mine_They;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button ComicModify;

    private SourceDraw _CharmDraw;
    private List<FortCharmSink> Hart_FortCharmSink;

    protected override void Awake()
    {
        base.Awake();
        RewriteNeuronNiche.LawFigurine().Alphabet("MiniGameBounusItemUpdate", OnMiniGameBounusItemUpdate);
        RewriteNeuronNiche.LawFigurine().Alphabet("LuckyBonusTime", OnLuckyBonusTime);
        Hart_FortCharmSink = new List<FortCharmSink>();
        ComicModify.onClick.AddListener(()=> {
            ComicUIPram(nameof(FortVenomCharmCoach));
        });
    }

    public override void Display()
    {
        base.Display();
        PageBisonEmbryo.LawFigurine().SeatBison("1017");
    }

    private void Start()
    {
        CharmDrawWool();
        RegretCharmSink();
    }


    private void OnLuckyBonusTime(RewriteCopy obj)
    {
        Mine_They.text = obj.FiordExcess;
    }

    private void OnMiniGameBounusItemUpdate(RewriteCopy obj)
    {
        var Here= FortWineCopyVaguely.LawFigurine().LawWineDramaLime();
        for (int i = 0; i < Hart_FortCharmSink.Count; i++)
        {
            Hart_FortCharmSink[i].OnBonusItemUpdate(Here[i]);
        }
    }

    private void CharmDrawWool()
    {
        _CharmDraw = new SourceDraw();
        _CharmDraw.Wool("BounsItemPool", DramaObsess.transform);
        _CharmDraw.Autumn = DramaSink;
    }

    private float[] JarX= new float[] { 170,490, 490, 170 };
    private void RegretCharmSink()
    {
        var Here= FortWineCopyVaguely.LawFigurine().LawWineDramaLime();
        Moraine.sizeDelta = new Vector2(Moraine.sizeDelta.x,Here.Count/2f * 320);
        int index = 0;
        for (int i = 0; i < Here.Count; i++)
        {
            var obj = _CharmDraw.Law();
            Vector3 pos = new Vector3(170,-180);
            if (i != 0)
            {
                int groupIndex = i / 2;
                pos = new Vector3(JarX[index], -180 - groupIndex * 300);
            }
            obj.transform.localPosition = new Vector3(pos.x, pos.y, 0);
            var bonus = Here[i];
            //���ң��Ƿ���ȡ���Ƿ��棬index��0Ϊfalse��1Ϊtrue��
            FortCharmSink item =  obj.GetComponent<FortCharmSink>();
            item.MadCharmSink(bonus,i, index);
            index++;
            if (index >= 4)
            {
                index = 0;
            }
            Hart_FortCharmSink.Add(item);
        }
    }
}
