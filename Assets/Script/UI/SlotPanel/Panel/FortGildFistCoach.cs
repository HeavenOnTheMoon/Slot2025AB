using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortGildFistCoach : LeftUIMarry
{
    public static FortGildFistCoach instance;
[UnityEngine.Serialization.FormerlySerializedAs("List_ChipFlopItem")]    public List<FootGildSink> Hart_FootGildSink;
[UnityEngine.Serialization.FormerlySerializedAs("List_FlopReward")]
    public List<GildMeadowSink> Hart_GildMeadow;

    Dictionary<int, int> Ray_GildThus;

    protected override void Awake()
    {
        base.Awake();
        instance = this;
        
        RewriteNeuronNiche.LawFigurine().Alphabet("SendFlopGameItemType", OnFlopGameItemType);

    }
    void Start()
    {

    }
    public override void Display()
    {
        base.Display();
        PageBisonEmbryo.LawFigurine().SeatBison("1006");
        FortGildFistCoachWool();
    }

    private void OnFlopGameItemType(RewriteCopy obj)
    {
        int value = obj.FiordAid;
        if (value != 0)
        {
            if (Ray_GildThus.ContainsKey(value))
                Ray_GildThus[value]++;
            else
                Ray_GildThus.Add(value, 1);
        }

        foreach (var item in Ray_GildThus)
        {
            for (int i = 0; i < Ray_GildThus.Count; i++)
            {
                if (i < item.Value)
                    Hart_GildMeadow[item.Key - 1].Hart_Meadow[i].SetActive(true);
            }
           
            if (item.Value == 3)
            {
                ComicUIPram(nameof(FortGildFistCoach));
                Debug.Log("-------------    �� �� " + (WildRewardType)(item.Key - 1) );
                UIInject.LawFigurine().FairUIMarry(nameof(FortFoldMeadowCoach));
                var wilddata = FortCopyVaguely.instance.LawGateFoldMeadow();
                RewriteCopy Here= new RewriteCopy();
                Here.FiordAid = item.Key - 1;
                Here.FiordAlarm = wilddata[item.Key - 1];
                Here.FiordExcess = "bonus";
                RewriteNeuronNiche.LawFigurine().Seat("MiniGameWildGamePanelUpdate", Here);
                
            }
        }
    }

   

    public void FortGildFistCoachWool()
    {
        Ray_GildThus = new Dictionary<int, int>();
        
        var flopdata = FortCopyVaguely.instance.LawGateFoldMeadow();
        for (int i = 0; i < flopdata.Count; i++)
        {
            Hart_GildMeadow[i].GildMeadowSinkWool(flopdata[i]);
        }

        var chipdata = GildFistVaguely.LawFigurine().GildFistCopyWool();
        for (int i = 0; i < Hart_FootGildSink.Count; i++)
        {
            Hart_FootGildSink[i].GildSinkWool(chipdata[i],GildFistVaguely.LawFigurine().LawGildSinkMeadowHome());
        }
        
    }
    
}
