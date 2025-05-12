using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoomCoachTine : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("List_WildText")]    public List<Text> Hart_FoldMine;
    private List<float> _Deed_WashMeadow;
    void Start()
    {
        RewriteNeuronNiche.LawFigurine().Alphabet("SendBet", OnBetUpdate);
        MadFoldMineLime();
    }

    private void OnBetUpdate(RewriteCopy obj)
    {
        MadFoldMineLime();
    }

    private void MadFoldMineLime()
    {
        _Deed_WashMeadow = FortCopyVaguely.instance.LawGateFoldMeadow();
        for (int i = 0; i < _Deed_WashMeadow.Count; i++)
        {
            decimal Dual= (decimal)_Deed_WashMeadow[i];
            string str = RetoolJean.MyEnsue() ? "" : "$";
            Hart_FoldMine[i].text = str + Dual.ToString("f2");
        }
    }
}
