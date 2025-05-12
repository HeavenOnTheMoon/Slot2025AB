using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HerdCoachTine : MonoBehaviour
{
    public static HerdCoachTine instance;
[UnityEngine.Serialization.FormerlySerializedAs("SpinRewardSlider")]    public Image HerdMeadowCoerce;
[UnityEngine.Serialization.FormerlySerializedAs("List_RewardItem")]    public List<HerdMeadowSink> Hart_MeadowSink;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        RewriteNeuronNiche.LawFigurine().Alphabet("SendSpinNumber", OnSpinNumberUpdate);
        HerdMeadowTurkic();
    }

    private void OnSpinNumberUpdate(RewriteCopy obj)
    {
        HerdMeadowTurkic();
    }

    public void HerdMeadowTurkic()
    {
        var Here= FortCopyVaguely.instance.LawHerdMeadowLime();
        int curnumber = FortCopyVaguely.instance.LeoHerdLittle;
        for (int i = 0; i < Hart_MeadowSink.Count; i++)
        {
            Hart_MeadowSink[i].MadHerdStiltSinkWool(curnumber >= Here[i].SpinNumber, Here[i].CashNumber, Here[i].SpinNumber);
        }
         HerdMeadowCoerce.fillAmount = curnumber / (float)FortCopyVaguely.instance.MeadowHerdSheLittle;
    }

}
