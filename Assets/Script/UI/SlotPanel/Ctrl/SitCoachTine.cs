using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SitCoachTine : MonoBehaviour
{
    public static SitCoachTine instance;
[UnityEngine.Serialization.FormerlySerializedAs("StarText")]    public Text TineMine;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text HomeMine;
[UnityEngine.Serialization.FormerlySerializedAs("CoinImage")]   
    public Image HaveSlice;
[UnityEngine.Serialization.FormerlySerializedAs("CoinAimaStartObj")]    public GameObject HaveBeakDecayBis;
[UnityEngine.Serialization.FormerlySerializedAs("StarButton")]    public Button TineModify;
[UnityEngine.Serialization.FormerlySerializedAs("SettingButton")]    public Button UselessModify;
[UnityEngine.Serialization.FormerlySerializedAs("CollectButton")]    public Button TreasonModify;
    private void Awake()
    {
        instance = this;
        RewriteNeuronNiche.LawFigurine().Alphabet("TokenUpdate", OnTokenUpdate);
        TineModify.onClick.AddListener(()=> {
            if (RetoolJean.MyEnsue())
                return;
            UIInject.LawFigurine().FairUIMarry(nameof(FortVenomCharmCoach));
        });

        UselessModify.onClick.AddListener(()=> {
            UIInject.LawFigurine().FairUIMarry(nameof(FortUselessCoach));
        });

        TreasonModify.onClick.AddListener(()=> {
            UIInject.LawFigurine().FairUIMarry(nameof(FortVenomHaleCoach));
        });

        
    }

  

    void Start()
    {
        //RewriteNeuronNiche.GetInstance().Register(CLazily.mg_ui_addtoken, OnCoinTextUpdate);
        OnCoinTextUpdate(null);
        MadHaveSlice();
    }
    private void OnTokenUpdate(RewriteCopy obj)
    {
        HomeMine.text = LittleJean.SummerMyNut(AprilFistCopyVaguely.LawFigurine().JobBloom());
    }
    private void OnCoinTextUpdate(RewriteCopy obj)
    {
        //obj.valueTransform;
        HomeMine.text = LittleJean.SummerMyNut(AprilFistCopyVaguely.LawFigurine().JobBloom());
    }

    private void MadHaveSlice()
    {
        HaveSlice.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        /*RetoolJean.IsApple() ?
        Resources.Load<Sprite>("Art/Tex/Coin/Icon_Coin_s")
        : Resources.Load<Sprite>("Art/Tex/Coin/Icon_Cash_s_1");*/
        HaveSlice.SetNativeSize();
    }

    #region ����
    public void HomeRotEpidermis(Transform startTransform, double num)
    {
        Transform endTransform = HaveSlice.transform;
        startTransform = startTransform == null ? HaveBeakDecayBis.transform : startTransform;
        float Sail= float.Parse(HomeMine.text);
        LotEpidermis(startTransform, endTransform, HaveSlice.gameObject, HomeMine, Sail, num);
        AprilFistCopyVaguely.LawFigurine().LotBloom(num);
        //ChangeNumbers(AprilFistCopyVaguely.GetInstance().getToken(), num, 0.1f, CashText);
    }
   

    private void LotEpidermis(Transform startTransform, Transform endTransform, GameObject icon, Text text, double textValue, double num)
    {
        if (startTransform != null)
        {
            EpidermisPalimpsest.VinePeakAkin(icon, Mathf.Max((int)num, 1), startTransform, endTransform, () =>
            {
                
                double startNum = double.Parse(text.text.Replace("$", ""));
                
                double endNum = AprilFistCopyVaguely.LawFigurine().JobBloom();

                EpidermisPalimpsest.GatherDeclare(startNum, endNum, 0.1f, HomeMine,()=> {
                   
                });
            });
        }
        else
        {
            double startNum = double.Parse(text.text.Replace("$", ""));
            //AprilFistCopyVaguely.GetInstance().addToken(num);
            double endNum = AprilFistCopyVaguely.LawFigurine().JobBloom();
            EpidermisPalimpsest.GatherDeclare(startNum, endNum, 0.1f, HomeMine, () => {

            });
        }
    }
    #endregion
}
