using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CashOutBtn")]    public Button HomeBusIts;
[UnityEngine.Serialization.FormerlySerializedAs("State_1")]    public GameObject Seedy_1;
[UnityEngine.Serialization.FormerlySerializedAs("State_2")]    public GameObject Seedy_2;
[UnityEngine.Serialization.FormerlySerializedAs("State_3")]    public GameObject Seedy_3;
[UnityEngine.Serialization.FormerlySerializedAs("State_4")]    public GameObject Seedy_4;
[UnityEngine.Serialization.FormerlySerializedAs("State_1_CountDownText")]    public Text Seedy_1_WhaleWideMine;  // 新建状态的提现记录的倒计时
[UnityEngine.Serialization.FormerlySerializedAs("State_1_ConditionText")]    public Text Seedy_1_MetalworkMine;
[UnityEngine.Serialization.FormerlySerializedAs("State_2_Text1")]    public GameObject Seedy_2_Mine1;
[UnityEngine.Serialization.FormerlySerializedAs("State_2_Text2")]    public GameObject Seedy_2_Mine2;
[UnityEngine.Serialization.FormerlySerializedAs("State_2_CountDownText")]    public Text Seedy_2_WhaleWideMine;
[UnityEngine.Serialization.FormerlySerializedAs("State_3_FillAmount")]    public Image Seedy_3_HumpArmory;
[UnityEngine.Serialization.FormerlySerializedAs("State_3_ProcessText")]    public Text Seedy_3_KinfolkMine;
[UnityEngine.Serialization.FormerlySerializedAs("State_3_DescText")]    public Text Seedy_3_PaveMine;
[UnityEngine.Serialization.FormerlySerializedAs("State_4_RankText")]    public Text Seedy_4_MuleMine;
[UnityEngine.Serialization.FormerlySerializedAs("State_4_ItemLong")]    public Button Seedy_4_SinkDeft;
[UnityEngine.Serialization.FormerlySerializedAs("State_4_ItemLongText1")]    public Text Seedy_4_SinkDeftMine1;
[UnityEngine.Serialization.FormerlySerializedAs("State_4_ItemLongText2")]    public Text Seedy_4_SinkDeftMine2;
[UnityEngine.Serialization.FormerlySerializedAs("State_4_DetailBtn")]    public Button Seedy_4_ExpertIts;

    private HomeThough DualThough;
    private long init_Necessity;         // 距离可提现倒计时
    private Coroutine NecessityNaturalism;

    // Start is called before the first frame update
    void Start()
    {
        // 提现按钮点击
        HomeBusIts.onClick.AddListener(() =>
        {
            SOHOCoachVaguely.instance.WoolEntailCoach(SOHOCoachVaguely.SourcePanel.ThoughCoach, SOHOCoachVaguely.SourceButton.Cashout, DualThough, null, null);
            if (SOHOLoamCopyVaguely.instance.BluefinSlitJanuary == null)
            {
                UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
            }
            else
            {
                UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(IndianaCheerCoach)));
            }
        });

        Seedy_4_ExpertIts.onClick.AddListener(() =>
        {
            Seedy_4_ExpertIts.gameObject.SetActive(false);
            Seedy_4_SinkDeft.gameObject.SetActive(true);
            GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 590f);
        });
        Seedy_4_SinkDeft.onClick.AddListener(() =>
        {
            Seedy_4_ExpertIts.gameObject.SetActive(true);
            Seedy_4_SinkDeft.gameObject.SetActive(false);
            GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 430);
        });
    }

    public void WoolThoughSink(HomeThough cashItem)
    {
        DualThough = cashItem;

        Seedy_1.SetActive(false);
        Seedy_2.SetActive(false);
        Seedy_3.SetActive(false);
        Seedy_4.SetActive(false);

        GameObject SelectedState = Seedy_1;
        Though.RedeemState state = cashItem.state;
        if (state == Though.RedeemState.Init && !DualThough.ManChapbook)
        {
            SelectedState = Seedy_1;
            init_Necessity = cashItem.endTime - CanyJean.Predate();
            if (NecessityNaturalism == null)
            {
                NecessityNaturalism = StartCoroutine(DecayWhaleWide());
            }
            if (DualThough.preCompaction != null && DualThough.preCompaction.Count > 0)
            {
                Seedy_1_MetalworkMine.text = DualThough.preCompaction[0].desc.Replace("${value}", DualThough.preCompaction[0].condition_num.ToString());
                Seedy_1_MetalworkMine.gameObject.SetActive(true);
            }
            else
            {
                Seedy_1_MetalworkMine.gameObject.SetActive(false);
            }
        }
        else if (state == Though.RedeemState.Unchecked || state == Though.RedeemState.Init && DualThough.ManChapbook)
        {
            SelectedState = Seedy_2;
            Seedy_2_Mine1.SetActive(state == Though.RedeemState.Init);
            Seedy_2_Mine2.SetActive(state == Though.RedeemState.Init);
            if (state == Though.RedeemState.Init)
            {
                Seedy_2_Mine1.SetActive(true);
                Seedy_2_Mine2.SetActive(true);
                init_Necessity = cashItem.endTime - CanyJean.Predate();
                if (NecessityNaturalism == null)
                {
                    NecessityNaturalism = StartCoroutine(DecayWhaleWide());
                }
            }
            else
            {
                Seedy_2_Mine1.SetActive(false);
                Seedy_2_Mine2.SetActive(false);
            }
        }
        else if (state == Though.RedeemState.Checked)
        {
            SelectedState = Seedy_3;
            double value = cashItem.currentTask.value;
            double task_num = cashItem.currentTask.task_num;
            Seedy_3_HumpArmory.fillAmount = (float)(value / task_num);
            string processText = value + "/" + task_num;
            Seedy_3_KinfolkMine.text = processText;
            Seedy_3_PaveMine.text = cashItem.currentTask.desc.Replace("${value}", value.ToString()).Replace("${task_num}", task_num.ToString());
        }
        else if (state == Though.RedeemState.Waiting)
        {
            SelectedState = Seedy_4;
            Seedy_4_MuleMine.text = "Your current queue position is : " + cashItem.rank;
            Seedy_4_SinkDeft.gameObject.SetActive(false);
            Seedy_4_ExpertIts.gameObject.SetActive(true);
            Seedy_4_SinkDeftMine1.text = "You have collected $" + LittleJean.SummerMyNut(cashItem.cashout) + " Within " + CanyJean.ParadoxSquirt(SOHOLoamCopyVaguely.instance.DrabJson.cash_withdraw_time);
            Seedy_4_SinkDeftMine2.text = "There are " + (cashItem.rank - 1) + " players in front. Your position will be refreshed every minute.Thank you for your patience";
        }

        if (SelectedState != null)
        {
            SelectedState.SetActive(true);
            double num = cashItem.cashout <= 0 ? 0 : cashItem.cashout;
            SelectedState.transform.Find("BalanceNumber").GetComponent<Text>().text = "$ " + LittleJean.SummerMyNut(num);
            SlitJanuary userAccount = cashItem.userAccount;

            if (userAccount != null)
            {
                SelectedState.transform.Find("PayPalImage").gameObject.SetActive(true);
                SelectedState.transform.Find("PayPalImage").GetComponent<Image>().sprite = SOHOLoamVaguely.instance.PryConsult[(int)userAccount.Suburb];
            }
            else
            {
                SelectedState.transform.Find("PayPalImage").gameObject.SetActive(false);
            }

        }

    }

    // 未到可以提现时间，则开启倒计时
    private IEnumerator DecayWhaleWide()
    {
        while (init_Necessity > 0)
        {
            init_Necessity--;
            Seedy_1_WhaleWideMine.text = CanyJean.ParadoxSquirt(init_Necessity);
            Seedy_2_WhaleWideMine.text = CanyJean.ParadoxSquirt(init_Necessity);
            yield return new WaitForSeconds(1f);

            if (init_Necessity <= 0)
            {
                HomeThoughVaguely.instance.ShrineWoolWhaleWide(DualThough);
            }
        }
    }


}
