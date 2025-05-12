using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortVenomHaleCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("CardParent")]    public GameObject HaleObsess;
[UnityEngine.Serialization.FormerlySerializedAs("CardItem")]    public GameObject HaleSink;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]    public Button Modify_Comic;

    private SourceDraw _HaleDraw;
    private List<FortHaleSink> Hart_FortHaleRocky;

    protected override void Awake()
    {
        base.Awake();
        CharmDrawWool();
        Hart_FortHaleRocky = new List<FortHaleSink>();
        Modify_Comic.onClick.AddListener(()=> {
            ComicUIPram(nameof(FortVenomHaleCoach));
        });
    }

    public override void Display()
    {
        base.Display();
        PageBisonEmbryo.LawFigurine().SeatBison("1015");
        //FortWineCopyVaguely.GetInstance().ChangeSlotCardRewardCache(2, true);
        RegretHaleSink();

    }

    private void CharmDrawWool()
    {
        _HaleDraw = new SourceDraw();
        _HaleDraw.Wool("BounsItemPool", HaleObsess.transform);
        _HaleDraw.Autumn = HaleSink;
    }

    public void RegretHaleSink()
    {
        for (int i = 0; i < Hart_FortHaleRocky.Count; i++)
        {
            _HaleDraw.Leaning(Hart_FortHaleRocky[i].gameObject);
        }
        Hart_FortHaleRocky.Clear();
        var Here= FortWineCopyVaguely.LawFigurine().LawFortHaleCopy();
        for (int i = 0; i < Here.Count; i++)
        {
            var obj = _HaleDraw.Law();
            obj.transform.localScale = Vector3.one * 0.85f;
            FortHaleSink item = obj.GetComponent<FortHaleSink>();
            item.MadFortHaleSinkLime(i,Here[i].IsLock,Here[i].IsHaveReward,Here[i].Cash);
            Hart_FortHaleRocky.Add(item);
        }
    }

}
