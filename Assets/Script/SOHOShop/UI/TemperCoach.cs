using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("BackBtn")]    public Button ChopIts;
[UnityEngine.Serialization.FormerlySerializedAs("EmptyObj")]    public GameObject CacheBis;
[UnityEngine.Serialization.FormerlySerializedAs("Container")]    public Transform Deprecate;

    // Start is called before the first frame update
    void Start()
    {
        ChopIts.onClick.AddListener(() =>
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_SOHOTemperHart, (md) => {
            HaleCopy(md.FiordExcess);
        });
    }

    public override void Display()
    {
        base.Display();

        int childCount = Deprecate.childCount;
        if (childCount > 0)
        {
            for (int i = 0; i < childCount; i++)
            {
                DestroyImmediate(Deprecate.GetChild(0).gameObject);
            }
        }
        
    }

    private void HaleCopy(string type)
    {
        int recordNum = 0;
        GameObject recordItemPrefab =SOHOLoamVaguely.instance.TemperSink;
        if (type == "cash")
        {
            // 加载现金提现列表
            HomeThoughVaguely.instance.HomeThoughHart.ForEach((item) =>
            {
                if (item.state == Though.RedeemState.Complete)
                {
                    GameObject recordItem = Instantiate(recordItemPrefab, Deprecate);
                    recordItem.transform.Find("AllObj").gameObject.SetActive(false);
                    recordItem.transform.Find("CashText").GetComponent<Text>().text = "$" + LittleJean.SummerMyNut(item.cashout);
                    recordItem.transform.Find("EmailText").GetComponent<Text>().text = item.userAccount.Sloth;
                    recordItem.transform.Find("DateTimeText").GetComponent<Text>().text = "withdraw in " + CanyJean.CanyTheySquirt(CanyJean.ParadoxMyCanyThey(item.lastUpdateRankTime), "d");
                    recordNum++;
                }
            });
        }
        else if(type == "All")
        {
            // 加载金币提现列表
            if (HimThoughVaguely.instance.ScatHimEarthen != null)
                foreach (HimThough item in HimThoughVaguely.instance.ScatHimEarthen)
                {
                    if (item.state == Though.RedeemState.Waiting)
                    {
                        GameObject recordItem = Instantiate(recordItemPrefab, Deprecate);
                        recordItem.transform.Find("Image").GetComponent<Image>().sprite = 
                            SOHOLoamVaguely.instance.PryConsult[(int)item.userAccount.Suburb];
                        recordItem.transform.Find("AllObj").gameObject.SetActive(true);
                        recordItem.transform.Find("AllObj/Rank").GetComponent<Text>().text = item.rank.ToString();
                        recordItem.transform.Find("CashText").GetComponent<Text>().text = "$" + LittleJean.SummerMyNut(item.cashout);
                        recordItem.transform.Find("EmailText").GetComponent<Text>().text = item.userAccount.Sloth;
                        recordItem.transform.Find("DateTimeText").GetComponent<Text>().text = "withdraw in " + CanyJean.CanyTheySquirt(CanyJean.TheyAngle2CanyThey(item.lastUpdateRankTime), "d");
                        recordNum++;
                    }
                    if (item.state == Though.RedeemState.Complete)
                    {
                        GameObject recordItem = Instantiate(recordItemPrefab, Deprecate);
                        recordItem.transform.Find("Image").GetComponent<Image>().sprite = 
                            SOHOLoamVaguely.instance.PryConsult[(int) item.userAccount.Suburb];
                        recordItem.transform.Find("AllObj").gameObject.SetActive(false);
                        recordItem.transform.Find("CashText").GetComponent<Text>().text = "$" + LittleJean.SummerMyNut(item.cashout);
                        recordItem.transform.Find("EmailText").GetComponent<Text>().text = item.userAccount.Sloth;
                        recordItem.transform.Find("DateTimeText").GetComponent<Text>().text = "withdraw in " + CanyJean.CanyTheySquirt(CanyJean.ParadoxMyCanyThey(item.lastUpdateRankTime), "d");
                        recordNum++;
                    }
                }
        }
        else
        {
            // 加载金币提现列表
            foreach(VineThough item in VineThoughVaguely.instance.EpicThoughSpout)
            {
                if (item.state == Though.RedeemState.Complete)
                {
                    GameObject recordItem = Instantiate(recordItemPrefab, Deprecate);
                    recordItem.transform.Find("AllObj").gameObject.SetActive(false);
                    recordItem.transform.Find("CashText").GetComponent<Text>().text = "$" + LittleJean.SummerMyNut(item.cashout);
                    recordItem.transform.Find("EmailText").GetComponent<Text>().text = item.userAccount.Sloth;
                    recordItem.transform.Find("DateTimeText").GetComponent<Text>().text = "withdraw in " + CanyJean.CanyTheySquirt(CanyJean.ParadoxMyCanyThey(item.lastUpdateRankTime), "d");
                    recordNum++;
                }
            }
        }
        
        if (recordNum == 0)
        {
            CacheBis.SetActive(true);
            Deprecate.parent.parent.gameObject.SetActive(false);
        }
        else
        {
            CacheBis.SetActive(false);
            Deprecate.parent.parent.gameObject.SetActive(true);
            Deprecate.GetComponent<RectTransform>().sizeDelta = new Vector2(Deprecate.GetComponent<RectTransform>().sizeDelta.x, 238 * recordNum);
        }
    }

}
