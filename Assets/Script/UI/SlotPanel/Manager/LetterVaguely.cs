using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterVaguely : EarnCommunity<LetterVaguely>
{
    public void TrailHerdLetterTill(GameObject obj, string newbieKey, string str)
    {
        if (RetoolJean.MyEnsue())
        {
            return;
        }
        bool isNewbie = GripCopyVaguely.LawLeft(newbieKey);
        if (!isNewbie)
        {
            TillLetterCoach(obj, str);
        }
    }


    public void TrailLetterFund(string key)
    {
        if (RetoolJean.MyEnsue())
        {
            return;
        }
        if (!GripCopyVaguely.LawLeft(key))
        {
            CalveSale.instance.FundCalve();
            GripCopyVaguely.MadLeft(key, true);
        }
    }


    public void TillLetterCoach(GameObject obj, string str)
    {
        if (RetoolJean.MyEnsue())
        {
            return;
        }
        CalveSale.instance.FairCalve(obj, str);
        CalveSale.instance.MadLungCombat(true);
    }
}
