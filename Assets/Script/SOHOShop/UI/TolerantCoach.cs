using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TolerantCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("EmailText")]    public InputField CheerMine;
[UnityEngine.Serialization.FormerlySerializedAs("SubmitBtn")]    public Button PurpleIts;
[UnityEngine.Serialization.FormerlySerializedAs("CancelBtn")]    public Button WeightIts;
[UnityEngine.Serialization.FormerlySerializedAs("ChooseItemList")]    public GameObject[] BuckleSinkHart;
[UnityEngine.Serialization.FormerlySerializedAs("AccountText")]    public Text JanuaryMine;

    private int ResettleMethodMagic;

    // Start is called before the first frame update
    void Start()
    {
        PurpleIts.onClick.AddListener(() =>
        {
            if (string.IsNullOrEmpty(CheerMine.text))
            {
                // 提示用户填写账户
                GropeVaguely.LawFigurine().FairGrope("Please fill in your account");
            }
            else
            {
                SlitJanuary userAccount = new SlitJanuary();
                userAccount.Suburb = (SlitJanuary.WithdrawMethod)(ResettleMethodMagic);
                userAccount.Sloth = CheerMine.text;
                SOHOLoamCopyVaguely.instance.ClutchSlitJanuary(userAccount);

                if (SOHOCoachVaguely.instance.RecentCoachModify == SOHOCoachVaguely.SourceButton.Cashout
                && (SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.ThoughCoach && SOHOCoachVaguely.instance.SeminarHomeThough != null
                || SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.GoldAndAmazonPanel && SOHOCoachVaguely.instance.SeminarVineThough != null
                || SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.HimThoughCoach && SOHOCoachVaguely.instance.WarblerHimThough != null))
                {
                    UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(IndianaCheerCoach)));
                }

                ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
            }
        });

        WeightIts.onClick.AddListener(() =>
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });

        foreach (GameObject obj in BuckleSinkHart)
        {
            obj.GetComponent<Button>().onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(obj.name, @"[^0-9]+", "");
                int index = indexStr == "" ? 0 : int.Parse(indexStr);
                BelongSummer(index);
            });
        }
    }

    public override void Display()
    {
        base.Display();

        if (SOHOLoamCopyVaguely.instance.BluefinSlitJanuary == null)
        {
            string language = I2.Loc.LocalizationManager.CurrentLanguage;
            SlitJanuary.WithdrawMethod Default = SlitJanuary.WithdrawMethod.A;
            if (language == "Russian")
                Default = SlitJanuary.WithdrawMethod.Q;
            else if (language == "Portuguese (Brazil)")
                Default = SlitJanuary.WithdrawMethod.P;
            else if (language == "Japanese")
                Default = SlitJanuary.WithdrawMethod.M;
            else if (language == "Arabic")
                Default = SlitJanuary.WithdrawMethod.S;
            else if (language == "Indonesian")
                Default = SlitJanuary.WithdrawMethod.F;
            else if (language == "English")
            {
                Default = SlitJanuary.WithdrawMethod.A;
                string Conutry = SpyLimeYet.instance.Loosely;
                if (Conutry == "IN")
                    Default = SlitJanuary.WithdrawMethod.O;
            }
            ResettleMethodMagic = (int)Default;
            CheerMine.text = "";
        }
        else
        {
            CheerMine.text = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Sloth;
            ResettleMethodMagic = (int)SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Suburb;
        }
        string Name = SOHOLoamVaguely.instance.LawLintMusicianNut((SlitJanuary.WithdrawMethod)ResettleMethodMagic);
        JanuaryMine.text = "Please enter your " + Name + " accout";

        BelongSummer(ResettleMethodMagic);

    }

    private void BelongSummer(int index)
    {
        Sprite selectedBg = SOHOLoamVaguely.instance.UI_SynapsisBG;
        Sprite notSelectedBg = SOHOLoamVaguely.instance.UI_YamSynapsisBG;
        foreach (GameObject item in BuckleSinkHart)
        {
            item.transform.Find("Image (1)").gameObject.SetActive(false);
            item.GetComponent<Image>().sprite = notSelectedBg;
        }

        ResettleMethodMagic = index;
        BuckleSinkHart[ResettleMethodMagic].transform.Find("Image (1)").gameObject.SetActive(true);
        BuckleSinkHart[ResettleMethodMagic].GetComponent<Image>().sprite = selectedBg;

        string Name = SOHOLoamVaguely.instance.LawLintMusicianNut((SlitJanuary.WithdrawMethod)ResettleMethodMagic);
        JanuaryMine.text = "Please enter your " + Name + " accout";
        if (SOHOLoamCopyVaguely.instance.BluefinSlitJanuary != null && ResettleMethodMagic == (int)SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Suburb)
        {
            CheerMine.text = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Sloth;
        }
        else
        {
            CheerMine.text = ""; ;
        }
    }
}
