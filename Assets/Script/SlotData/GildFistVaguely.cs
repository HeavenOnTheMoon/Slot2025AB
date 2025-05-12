using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GildFistVaguely :EarnCommunity<GildFistVaguely>
{
    public float GildSinkMeadow;
    protected override void Awake()
    {
        base.Awake();
        
    }

    public float LawGildSinkMeadowHome()
    {
        float Dual= Random.Range(1, 2) * FortCopyVaguely.instance.LawEnsueHomeOral();
        if (RetoolJean.MyEnsue())
        {
            Dual = Dual * 1000;
        }
        return Dual;
    }

    public void TillFortGildFistCoach()
    {
        UIInject.LawFigurine().FairUIMarry(nameof(FortGildFistCoach));
        //FortGildFistCoach.instance.SlotFlopGamePanelInit();
    }

    public void SeatGildFistSinkThus(LuckyChipType type)
    {
        RewriteNeuronNiche.LawFigurine().Seat("SendFlopGameItemType", new RewriteCopy((int)type));
    }

    public List<LuckyChipType> GildFistCopyWool()
    {
        List<LuckyChipType> list = new List<LuckyChipType>();
        for (int i = 0; i < 4; i++)
        {
            list.Add((LuckyChipType)i);
            list.Add((LuckyChipType)i);
        }
        int random = Random.Range(1,4);
        list.Add((LuckyChipType)random);
        Ontario(list);
        return list;
    }

    /// <summary>
    /// ϴ���㷨
    /// </summary>
    public void Ontario<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1); 
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

}

public enum LuckyChipType { 
    Cash,Mini,Major,Grand
}
