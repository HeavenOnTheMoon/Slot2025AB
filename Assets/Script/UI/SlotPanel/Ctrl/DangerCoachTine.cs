using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerCoachTine : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public Text HaveMine;
[UnityEngine.Serialization.FormerlySerializedAs("ChipText")]    public Text FootMine;
[UnityEngine.Serialization.FormerlySerializedAs("CoinImage")]    public Image HaveSlice;
[UnityEngine.Serialization.FormerlySerializedAs("SubButton")]    public Button LieModify;
[UnityEngine.Serialization.FormerlySerializedAs("AddButton")]    public Button RotModify;
[UnityEngine.Serialization.FormerlySerializedAs("MaxBetButton")]    public Button SheDNAModify;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Pig")]    public Button Modify_Hut;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Cash")]    public Button Modify_Home;
[UnityEngine.Serialization.FormerlySerializedAs("GoldPigObj")]
    public GameObject VineHutBis;
[UnityEngine.Serialization.FormerlySerializedAs("Text_GoldText")]    public Text Mine_GoldMine;
    private void Start()
    {
        LieModify.onClick.AddListener(OnSubClick);
        RotModify.onClick.AddListener(OnAddClick);
        SheDNAModify.onClick.AddListener(OnMaxBetClick);
        Modify_Hut.onClick.AddListener(OnGoldPig);
        Modify_Home.onClick.AddListener(()=> {
            LetterVaguely.LawFigurine().TrailLetterFund("NewbieSohoFinish");
            SOHOLoamVaguely.instance.FairThoughCoach();
        });
        // RewriteNeuronNiche.GetInstance().Register("TokenUpdate", OnCoinTextUpdate);

        RewriteNeuronNiche.LawFigurine().Alphabet("SendBet", OnBetUpdate);
        RewriteNeuronNiche.LawFigurine().Alphabet("CurSpinRewardUpdate", OnCurSpinRewardUpdate);
        RewriteNeuronNiche.LawFigurine().Alphabet("GlodPigTime", OnGlodPigTime);
        //OnCoinTextUpdate(null);
        MadHaveSlice();
        OnBetUpdate(null);
        HaveMine.text = "0";
        VineHutBis.SetActive(FortWineCopyVaguely.LawFigurine().MyTillVineHut);
        Modify_Home.gameObject.SetActive(!RetoolJean.MyEnsue());
    }

   
    private void OnGlodPigTime(RewriteCopy obj)
    {
        VineHutBis.SetActive(FortWineCopyVaguely.LawFigurine().MyTillVineHut);
        Mine_GoldMine.text = obj.FiordExcess;
    }

    private void OnCurSpinRewardUpdate(RewriteCopy obj)
    {
        if (obj == null) return;
        float endNum = obj.FiordAlarm;
        if (endNum == 0)
        {
            HaveMine.text = "0";
        }
        else
        {
            //CoinText.text = LittleJean.DoubleToStr(AprilFistCopyVaguely.GetInstance().getToken());
            float startNum = float.Parse(HaveMine.text.Replace("$", ""));
            GatherDeclare(startNum, endNum, 0.1f, HaveMine);
        }
    }

    private void OnBetUpdate(RewriteCopy obj)
    {
        var Here= FortCopyVaguely.instance.LawLeoPegDNALime();
        float num = RetoolJean.MyEnsue() ? Here.GoldNum : Here.CashNum;
        FootMine.text = num.ToString();
    }

   /* private void OnCoinTextUpdate(RewriteCopy obj)
    {
        if (obj == null) return;
        double endNum = obj.valueDouble;
        //CoinText.text = LittleJean.DoubleToStr(AprilFistCopyVaguely.GetInstance().getToken());
        double startNum = double.Parse(CoinText.text.Replace("$", ""));
        ChangeNumbers(startNum, endNum, 0.1f, CoinText);
    }*/

    public void GatherDeclare(double startNum, double endNum, float delay, Text text, Action finish = null)
    {
        DOTween.To(() => startNum, x => text.text = LittleJean.SummerMyNut(x), endNum, 0.5f).SetDelay(delay).OnComplete(() =>
        {
            finish?.Invoke();
        });
    }

    private void OnSubClick()
    {
        FortCopyVaguely.instance.OnBetUpdate(false);
    }

    private void OnAddClick()
    {
        FortCopyVaguely.instance.OnBetUpdate(true);
    }

    private void OnMaxBetClick()
    {
        FortCopyVaguely.instance.OnChangeBet(2);
    }

    private void OnGoldPig()
    {
        UIInject.LawFigurine().FairUIMarry(nameof(FortVineHutCoach));
    }


    private void MadHaveSlice()
    {
        HaveSlice.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
           /* RetoolJean.IsApple() ?
            Resources.Load<Sprite>("Art/Tex/Coin/Icon_Coin_s")
            : Resources.Load<Sprite>("Art/Tex/Coin/Icon_Cash_s_1");*/
        HaveSlice.SetNativeSize();
    }
}
