using System;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class HaleMuseum : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("GetCashBtn")]    //1  状态，2  进度， 3  时间 
    public Button LawHomeIts;
[UnityEngine.Serialization.FormerlySerializedAs("CashNormalObj")]    
    public GameObject HomeTariffBis;
[UnityEngine.Serialization.FormerlySerializedAs("CoinNorObj")]    public GameObject HaveBigBis;
[UnityEngine.Serialization.FormerlySerializedAs("CashNorObj")]    public GameObject HomeBigBis;
[UnityEngine.Serialization.FormerlySerializedAs("ACardNorObj")]    public GameObject AHaleBigBis;
[UnityEngine.Serialization.FormerlySerializedAs("GetCashText")]    public Text LawHomeMine;
[UnityEngine.Serialization.FormerlySerializedAs("NorSchText")]    public Text BigTanMine;
[UnityEngine.Serialization.FormerlySerializedAs("NorSchImage")]    public Image BigTanSlice;
[UnityEngine.Serialization.FormerlySerializedAs("CountDownText")]    public Text WhaleWideMine;
[UnityEngine.Serialization.FormerlySerializedAs("CashTaskObj")]
    public GameObject HomePestBis;
[UnityEngine.Serialization.FormerlySerializedAs("CashCheckObj")]
    public GameObject HomeTrailBis;
[UnityEngine.Serialization.FormerlySerializedAs("TaskOneDescriptionText")]
    public Text PestRibElaborationMine;
[UnityEngine.Serialization.FormerlySerializedAs("PayImage")]    
    public Image PrySlice;
[UnityEngine.Serialization.FormerlySerializedAs("HimThough")]    public HimThough HimThough;

    double _BluefinAdult= 0;
    // Start is called before the first frame update
    void Start()
    {
        
        LawHomeIts.onClick.AddListener(() =>
        {
            _BluefinAdult = HimThough.type switch{
                "gold" => SOHOLoamVaguely.instance.JobVineGreedy(),
                "amazon" => SOHOLoamVaguely.instance.JobSteppeGreedy(),
                "cash" => SOHOLoamVaguely.instance.getHomeGreedy(),
                _ => _BluefinAdult
            };
            if (_BluefinAdult >= HimThough.num)
            {
                SOHOCoachVaguely.instance.WoolEntailCoach(SOHOCoachVaguely.SourcePanel.HimThoughCoach, 
                    SOHOCoachVaguely.SourceButton.Cashout, null,null, HimThough);
                UIInject.LawFigurine().FairUIMarry(SOHOLoamCopyVaguely.instance.BluefinSlitJanuary == null ? 
                    SOHOLoamJean.CoachNeon("TolerantCoach") : SOHOLoamJean.CoachNeon("IndianaCheerCoach"));
            }
            else
            {
                string msg = HimThough.type switch{
                    "gold" => "Gold is not enough",
                    "amazon" => "Amazon is not enough",
                    "cash" => "Cash is not enough",
                    _ => "Gold is not enough"
                };
                GropeVaguely.LawFigurine().FairGrope(msg);
            }

        });
    }

    // Update is called once per frame
    void Update()
    {
        if (HomeTrailBis.gameObject.activeSelf)
        {
            
            WhaleWideMine.text = CanyJean.ParadoxSquirt(HimThoughVaguely.instance.LawPredateWhaleWide(HimThough));
            
        }
    }

    /// <summary>
    ///  初始化信息
    /// </summary>
    public void WoolLime()
    {
        BroadenUI();
    }

    public void BroadenUI()
    {
        SlitJanuary BluefinSlitJanuary= SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
        PrySlice.sprite = BluefinSlitJanuary == null ? SOHOLoamVaguely.instance.LawYucatanPryDuring()
            : SOHOLoamVaguely.instance.PryConsult[(int)BluefinSlitJanuary.Suburb];
        LawHomeMine.text = String.Format("$ {0:N0}", HimThough.cashout);
        
        //状态总控
        HomeTariffBis.SetActive(false);
        HomePestBis.SetActive(false);
        HomeTrailBis.SetActive(false);
        switch (HimThough.state)
        {
            case Though.RedeemState.Init :
                HomeTariffBis.SetActive(true);
                HomeBigBis.gameObject.SetActive(HimThough.type == "cash");
                HaveBigBis.gameObject.SetActive(HimThough.type == "gold"); 
                AHaleBigBis.gameObject.SetActive(HimThough.type == "amazon");
                
                _BluefinAdult = HimThough.type switch{
                    "gold" => SOHOLoamVaguely.instance.JobVineGreedy(),
                    "amazon" => SOHOLoamVaguely.instance.JobSteppeGreedy(),
                    "cash" => SOHOLoamVaguely.instance.getHomeGreedy(),
                    _ => _BluefinAdult
                }; 
                
                BigTanMine.text = String.Format("{0:N0}", _BluefinAdult) + "/" + HimThough.num;
                BigTanSlice.fillAmount = (float)_BluefinAdult / HimThough.num;
                break;
            case Though.RedeemState.Checked :
                HomePestBis.SetActive(true);
                if (HimThough.currentTask != null)
                {
                    if (HimThough.currentTask.type != "Time")
                    {
                        double value = HimThough.currentTask.value;
                        double task_num = HimThough.currentTask.task_num;
                        PestRibElaborationMine.text = HimThough.currentTask.desc.Replace("${value}",
                            value.ToString()).Replace("${task_num}", task_num.ToString()); 
                    }
                    else
                    {
                        HomePestBis.SetActive(false); 
                        HomeTrailBis.SetActive(true);
                        WhaleWideMine.text = CanyJean.ParadoxSquirt(HimThoughVaguely.instance.LawPredateWhaleWide(HimThough));
                    }
                }
                else
                {
                    if (SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks != null && SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks.Length > 0)
                    {
                        HimThough.checkoutTasks = new List<CheckoutTask>();
                        foreach (CheckoutTask task in SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks)
                        {
                            HimThough.checkoutTasks.Add((CheckoutTask)task.Clone());
                        }
                        HimThough.currentTaskIndex = 0;
                        HimThough.currentTask = HimThough.checkoutTasks[0];
                    }
                    
                    if (HimThough.currentTask != null)
                    {
                        if (HimThough.currentTask.type != "Time")
                        {
                            double value = HimThough.currentTask.value;
                            double task_num = HimThough.currentTask.task_num;
                            PestRibElaborationMine.text = HimThough.currentTask.desc.Replace("${value}",
                                value.ToString()).Replace("${task_num}", task_num.ToString()); 
                        }
                        else
                        {
                            HomePestBis.SetActive(false); 
                            HomeTrailBis.SetActive(true);
                            WhaleWideMine.text = CanyJean.ParadoxSquirt(HimThoughVaguely.instance.LawPredateWhaleWide(HimThough));
                        }
                    }
                }
                break;
            case Though.RedeemState.Waiting : 
                HomeTrailBis.gameObject.SetActive(false);
                break;
        }
    }
}
