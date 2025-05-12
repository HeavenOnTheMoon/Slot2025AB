using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortFistCoach : LeftUIMarry
{
    public static FortFistCoach Instance;
[UnityEngine.Serialization.FormerlySerializedAs("RealItemParent")]    /// <summary>
    /// ��ĳ��ֵ����Ÿ���
    /// </summary>
    public Transform ComeSinkObsess;
    List<List<FortFistSink>> ComeRocky;
    List<List<Vector3>> ComeSinkCoachSee;
    int[] ComeJoltWhale= new int[5]; //��ʵ�������Ŵ���ͳ��
[UnityEngine.Serialization.FormerlySerializedAs("FakeItemsParent")]    /// <summary>
    /// �ٵĶ���
    /// </summary>
    public Transform EvenRockyObsess;
    List<List<FortFistSink>> EvenRocky;
    List<List<Vector3>> EvenSinkCoachSee;
    int[] EvenJoltWhale= new int[5]; //�ٶ������Ŵ���ͳ��
    int EvenJoltShe= 15; //�ٶ�����󲥷Ŵ���
    int SinkDime= 130;//item�߶�
    int Sit= 390; // ��ߵ�
    int Danger= -400; // ��͵�
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("IsAnimPlaying")]public bool MyLinkViolent= false; //�Ƿ����ڲ���
    //����������һЩ��ʱִ�е����� ��������ֹͣ����StopSpin_Immediately
    List<Coroutine> SierraLinkTheyArriveIEs= new List<Coroutine>(); 
    /// <summary>
    /// ����ֹͣ
    /// </summary>
    bool HardHerd= false;
    bool HardHerd_Scrubbiness= false;
    bool MyHardFortLink= false;
    /// <summary>
    /// 15���񽱵�����
    /// </summary>
    private List<SlotPieceData> Hart_FortYoungCopy;
    private Coroutine FortSinkFairSway;
    /// <summary>
    /// ��ʵ����Sink��list
    /// </summary>
    private FortFistSink[,] _FortFistRockyGrope;

    private Dictionary<int, Queue<FortFistSink>> _Ray_EvenFortFistSink;
[UnityEngine.Serialization.FormerlySerializedAs("SpinButton")]
    public Button HerdModify;
[UnityEngine.Serialization.FormerlySerializedAs("StopButton")]    public Button HardModify;
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinButton")]    public Button WageHerdModify;
[UnityEngine.Serialization.FormerlySerializedAs("CoinParent")]    public GameObject HaveObsess;
[UnityEngine.Serialization.FormerlySerializedAs("SohoShop")]    public GameObject DutyLoam;
[UnityEngine.Serialization.FormerlySerializedAs("LineCtrl")]
    public FortCityTine CityCtrl;
[UnityEngine.Serialization.FormerlySerializedAs("TopCtrl")]    public SitCoachTine SitTine;
[UnityEngine.Serialization.FormerlySerializedAs("MiniGameCtrl")]    public WineFistRadarTine WineFistTine;

    private int _WashID;

    private float _CrowHerdScatThey;
    private float _SeniorFairThey;
   
    private bool _BeTillWageWineFist;
    //һ��spin��ȡ��gold
    private float _DogHerdVine;
    //��⽱��index
    private int _SealMeadowMagic;
    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        HerdModify.onClick.AddListener(OnSpinClick);
        HardModify.onClick.AddListener(OnStopClick);
        Application.targetFrameRate = 60;
        _SeniorFairThey = 2f;
        RewriteNeuronNiche.LawFigurine().Alphabet("SendFreeSpinStart", OnSendFreeSpinStart);
        
    }

   

    private void Start()
    {
        _BeTillWageWineFist = false;
           _WashID = FortCopyVaguely.instance.LawBreakageMagic();
        Hart_FortYoungCopy = new List<SlotPieceData>();
        _Ray_EvenFortFistSink = new Dictionary<int, Queue<FortFistSink>>();
        _FortFistRockyGrope = new FortFistSink[3, 5];
        MadHerdOrHardItsFair(true);
        WageHerdModify.gameObject.SetActive(FortCopyVaguely.instance.MyTillWageHerd);
        ComeRockyWool();
        EvenRockyWool();
        LetterVaguely.LawFigurine().TrailHerdLetterTill(HerdModify.gameObject, "NewbieSpinFinish", "Welcome to Your Wealth Journey! Just tap SPlN to win amazing reward!");
    }

    private void Update()
    {
        
    }
    private void OnSendFreeSpinStart(RewriteCopy obj)
    {
        Debug.Log("===============================     �ص�    " + FortCopyVaguely.instance.MyTillWageWineFist);
        _CrowHerdScatThey = 1;
        WineFistTine.PegWineFistRadar();
    }

    #region ˽�з���
    /// <summary>
    /// ���ŵ���¼�
    /// </summary>
    private void OnSpinClick()
    {
        if (MyLinkViolent) return;
        if (FortSinkFairSway!=null)
        {
            StopCoroutine(FortSinkFairSway);
            FortSinkFairSway = null;
        }

        LetterVaguely.LawFigurine().TrailLetterFund("NewbieSpinFinish");

        //û�п���freeSpin
        if (!FortCopyVaguely.instance.MyTillWageHerd)
        {
            FortCopyVaguely.instance.GatherLeoHerdMeadow(0);
            FortCopyVaguely.instance.BoxFlyWageHerdLittle++;
            SOHOLoamVaguely.instance.RotPestAdult("Spin");
            if (GripCopyVaguely.LawLeft("FirstPlaySpin"))
            {
                FortCopyVaguely.instance.HimHerdLittle += 1;
                var Here= FortCopyVaguely.instance.LawLeoPegDNALime();
                float Dual= RetoolJean.MyEnsue() ? Here.GoldNum : Here.CashNum;
                double allcash = AprilFistCopyVaguely.LawFigurine().JobBloom();
                if (allcash < Dual)
                {
                    UIInject.LawFigurine().FairUIMarry(nameof(FortADMeadowCoach));
                    return;
                }
                else
                {
                    FortCopyVaguely.instance.HerdMandanHome(-Dual);
                    PageBisonEmbryo.LawFigurine().SeatBison("1003",Dual.ToString());
                }
            }
        }
        _SealMeadowMagic = 0;
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_SpinButton);
        FortCopyVaguely.instance.MyTillHerd = true;
        MyLinkViolent = true;
        HardHerd = false;
        HardHerd_Scrubbiness = false;
        //���������
        CityCtrl.FortMeadowCityFund();
        //������ʼ��
        FortEpidermisWool();
        //��ȡ3��5��ÿ��ͼ������� ��ʼ����
        WoolRecruitment();
        //����spin����stop��ʾ
        MadHerdOrHardItsFair(false);

        GripCopyVaguely.MadLeft("FirstPlaySpin", true);
    }

    private void OnStopClick()
    {
        if (MyHardFortLink) return;
        MyHardFortLink = true;
        //���������� ��ͨ��ͣ�����̼�ͣ
        if (HardHerd)
        {
            //�Ѿ���������ͨ��ͣ �ٴ���������̼�ͣ ���ж���ֹͣ item˲�䵽��涨λ��
            FortEpidermisHard();
            return;
        }
        if (MyLinkViolent && !HardHerd) //��ͨ��ͣ �ٶ���������Ϊ����3�Σ�ʹ�涯�����̿�ʼ����
        {
            HardHerd = true;
            for (int i = 0; i < 5; i++)
            {
                if (EvenJoltWhale[i] < EvenJoltShe - 3)
                    EvenJoltWhale[i] = EvenJoltShe - 3;
            }
        }
    }
    /// <summary>
    /// ���üٶ������н�����item
    /// </summary>
    private void MadEvenLawMeadowSink(int j, FortFistSink FakeItem)
    {
        if (_Ray_EvenFortFistSink.ContainsKey(j))
        {   
            if (_Ray_EvenFortFistSink[j].Count == 3)//�Ƴ���һλ��ֵ
            {
                _Ray_EvenFortFistSink[j].Dequeue();
            }
        }
        else
        {
            _Ray_EvenFortFistSink.Add(j, new Queue<FortFistSink>());
        }
        _Ray_EvenFortFistSink[j].Enqueue(FakeItem);
    }
    /// <summary>
    /// ���ļٶ�����λ�õ�iconͼ�꣨�Ƿ�Ϊ����wild
    /// </summary>
    private void MadTreatFoldEvenWhat()
    {
        int itemIndex = 0;
        foreach (var item in _Ray_EvenFortFistSink)
        {
            int index = 0;//����˳��
           
            var Here= item.Value;
            //����
            List<int> list = new List<int>();
            foreach (var fake in Here)
            {
                if (fake.SinkDuringMagic == _WashID)
                {
                    list.Add(index);
                }
                index++;
            }

            if (list.Count == 3)
            {
                int fakeIndex = 0;
                foreach (var fakeItem in Here)
                {
                    if (fakeIndex == 0)
                    {
                        fakeItem.WoolTreatFold(_WashID, "wild", 3);
                    }
                    else
                    {
                        fakeItem.FairWhat(false, true);
                    }
                    fakeIndex++;
                }
            }
            if (list.Count == 2)
            {
                if (list[0] + 1 == list[1])
                {
                    int fakeIndex = 0;
                    foreach (var fakeItem in Here)
                    {
                        if (list[0] == 0 && fakeIndex == 0)
                        {
                            fakeItem.WoolTreatFold(_WashID, "wild", 2);
                        }
                        if (list[0] == 0 && fakeIndex == 1)
                        {
                            fakeItem.FairWhat(false, true);
                        }

                        if (list[0] == 1 && fakeIndex == 1)
                        {
                            fakeItem.WoolTreatFold(_WashID, "wild", 2);
                        }
                        if (list[0] == 1 && fakeIndex == 2)
                        {
                            fakeItem.FairWhat(false, true);
                        }
                        fakeIndex++;
                    }
                }
            }
            itemIndex++;
        }
    }



    /// <summary>
    /// ����չʾ�м�item
    /// </summary>
    private void FortSinkEpithet(List<SlotPiecePositionData> data)
    {
        FortSinkEpithetPalimpsest(true);
        for (int i = 0; i < data.Count; i++)
        {
            ComeRocky[data[i].x][data[i].y].WhatSaleFair(false);
            ComeRocky[data[i].x][data[i].y].WhatAlongFair(true);
        }
    }
    /// <summary>
    /// ��15�����Mask���ƣ�true����mask
    /// </summary>
    /// <param name="isShow"></param>
    private void FortSinkEpithetPalimpsest(bool isShow)
    {
        int Scatter = 0;
        for (int i = 0; i < ComeRocky.Count; i++)
        {
            for (int j = 0; j < ComeRocky[i].Count; j++)
            {
                ComeRocky[i][j].WhatSaleFair(isShow);
                ComeRocky[i][j].WhatAlongFair(false);
                if (ComeRocky[i][j].SinkDuringMagic == 9)
                {
                    Scatter++;
                }
            }
        }
        
    }

    
    /// <summary>
    /// ��ȡ3��5��ÿ��ͼ������� ��ʼ����
    /// </summary>
    private void WoolRecruitment()
    {
        Hart_FortYoungCopy = FortCopyVaguely.instance.LawFortFlyCopy();
        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            int wildIndex = 0;
            //��λ�ô���1��2���⴦��
            int twoWild = 0;
            List<int> list = new List<int>();
            for (int j = 0; j < 3; j++)
            {
                FortFistSink Sink = ComeRocky[i][j];
                Sink.Wool(Hart_FortYoungCopy[index].id, Hart_FortYoungCopy[index].type,index);
                Sink.gameObject.SetActive(true);
                Sink.transform.localPosition = new Vector2(Sink.transform.localPosition.x, Sink.transform.localPosition.y + 3 * SinkDime);
                _FortFistRockyGrope[j, i] = Sink;
                wildIndex = (Hart_FortYoungCopy[index].id == _WashID) ? wildIndex + 1 : wildIndex;
                twoWild = ( Hart_FortYoungCopy[index].id == _WashID) ? twoWild + 1 : twoWild;
                if (Hart_FortYoungCopy[index].id == _WashID )
                {
                    list.Add(j);
                }
                index++;
            }
            //�������ȫΪ����
            MadTreatFoldWhatFair(i, list);
        }
    }
    /// <summary>
    /// ������ʵ�����������Ŷ�Ϊ���ӵ�ͼƬ��ʾ
    /// </summary>
    /// <param name="wildIndex">���ӳ��ִ���</param>
    /// <param name="index">����list  count= 15��index��������λ��</param>
    /// <param name="x"></param>
    private void MadTreatFoldWhatFair(int x,List<int> list)
    {
        FortCopyVaguely.instance.MadReputeFoldHim(x, (list.Count == 3));
        if (list.Count == 3)
        {
            for (int k = 0; k < 3; k++)
            {
                if (k == 0)
                    _FortFistRockyGrope[k, x].WoolTreatFold(_WashID, "wild",3);
                else
                    _FortFistRockyGrope[k, x].FairWhat(false, true);
            }
        }
        else if (list.Count ==2 )
        {
            if (list[0] + 1 == list[1] )
            {
                if (list[0] == 0)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == 0)
                            _FortFistRockyGrope[k, x].WoolTreatFold(_WashID, "wild", 2);
                        if(k == 1)
                            _FortFistRockyGrope[k, x].FairWhat(false, true);
                    }
                }
                if (list[0] == 1)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == 1)
                            _FortFistRockyGrope[k, x].WoolTreatFold(_WashID, "wild", 2);
                        if (k == 2)
                            _FortFistRockyGrope[k, x].FairWhat(false, true);
                    }
                }
            }
        }
    }

   
    /// <summary>
    /// ����spin����stop��ʾ
    /// </summary>
    private void MadHerdOrHardItsFair(bool SpinTrue)
    {
        HerdModify.gameObject.SetActive(SpinTrue);
        HardModify.gameObject.SetActive(!SpinTrue);
        
        //FreeSpinButton.gameObject.SetActive(FortCopyVaguely.instance.IsOpenFreeSpin);
    }
    // ------------------   �������   -------------------------------
    /// <summary>
    /// ��ʵitem��ʼ��
    /// </summary>
    private void ComeRockyWool()
    {
        //��ʼ����ʵ���
        ComeRocky = new List<List<FortFistSink>>();
        ComeSinkCoachSee = new List<List<Vector3>>();
        for (int i = 0; i < 5; i++)
        {
            ComeRocky.Add(new List<FortFistSink>());
            ComeSinkCoachSee.Add(new List<Vector3>());
            for (int j = 0; j < 3; j++)
            {
                FortFistSink Sink = ComeSinkObsess.GetChild(i * 3 + j).GetComponent<FortFistSink>();
                Sink.gameObject.SetActive(false);
                Sink.name = $"��{i + 1}�� ��{j + 1}��";
                ComeRocky[i].Add(Sink);
                ComeSinkCoachSee[i].Add(Sink.transform.localPosition);
            }
        }
    }
    /// <summary>
    /// �ٶ�����Sink��ʼ��
    /// </summary>
    private void EvenRockyWool()
    {
        //��ʼ�������
        EvenRocky = new List<List<FortFistSink>>();
        EvenSinkCoachSee = new List<List<Vector3>>();
        for (int i = 0; i < 5; i++)
        {
            EvenRocky.Add(new List<FortFistSink>());
            EvenSinkCoachSee.Add(new List<Vector3>());
            for (int j = 0; j < 7; j++)
            {
                FortFistSink Sink = EvenRockyObsess.GetChild(i * 7 + j).GetComponent<FortFistSink>();
                Sink.Wool(j, FortCopyVaguely.instance.LawFortYoungLime(j).type);
                Sink.name = $"��{i + 1}�� ��{j + 1}��";
                EvenRocky[i].Add(Sink);
                EvenSinkCoachSee[i].Add(Sink.transform.localPosition);
            }
        }
    }
    /// <summary>
    /// slot������ʼ��
    /// </summary>
    private void FortEpidermisWool()
    {
        SierraLinkTheyArriveIEs.Clear();
        for (int i = 0; i < 5; i++)
        {
            ComeJoltWhale[i] = 0;
            EvenJoltWhale[i] = 0;
            for (int j = 0; j < 7; j++)
                EvenRocky[i][j].EvenFairWhatWool();
            int Magic= i;
            Coroutine DelayIE = TheyVaguely.LawFigurine().Habit(Magic * .2f, () =>
            {
                EvenSeaSierraLink(Magic, "开始");
            });
            SierraLinkTheyArriveIEs.Add(DelayIE);
        }
    }
    /// <summary>
    /// ֹͣslot����
    /// </summary>
    private void FortEpidermisHard()
    {
        //�Ѿ���������ͨ��ͣ �ٴ���������̼�ͣ ���ж���ֹͣ item˲�䵽��涨λ��
        if (!HardHerd_Scrubbiness && ComeRocky[0][0].transform.localPosition != ComeSinkCoachSee[0][0])
        {
            HardHerd_Scrubbiness = true;
            for (int i = 0; i < SierraLinkTheyArriveIEs.Count; i++)
            {
                if (SierraLinkTheyArriveIEs[i] != null)
                {
                    TheyVaguely.LawFigurine().HardHabit(SierraLinkTheyArriveIEs[i]);
                    //GlobeYet.GetInstance().PlayEffect(GlobeThus.UIMusic.Sound_SlotsStop_Normal);
                }
                    
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FortFistSink RealItem = ComeRocky[i][j];
                    RealItem.transform.DOKill();
                    RealItem.transform.localPosition = ComeSinkCoachSee[i][j];
                }
                for (int j = 0; j < 7; j++)
                {
                    FortFistSink FakeItem = EvenRocky[i][j];
                    FakeItem.transform.DOKill();
                    FakeItem.transform.localPosition = EvenSinkCoachSee[i][j];
                    if (j == 2 || j == 3 || j == 4)
                    {
                        FortFistSink RealItem = ComeRocky[i][j - 2];
                        FakeItem.FundWhat(j, RealItem.SinkThus);
                        MadEvenLawMeadowSink(i, FakeItem);
                    }
                }
            }
            GlobeYet.LawFigurine().HardAdvent(GlobeThus.UIMusic.Sound_SlotsRolling);
        }
    }


    /// <summary>
    /// �ٹ������� ��ʼ������� Ȼ���ظ�����N�� �����ص�
    /// </summary>
    private void EvenSeaSierraLink(int Index, string AnimType)
    {
        float AnimTime = 0;
        Ease AnimEase = Ease.Linear;
        if (AnimType == "开始")
        {
            AnimTime = 0.15f;
            AnimEase = Ease.InSine;
            GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_SlotsRolling);
        }
        else if (AnimType == "持续")
        {
            AnimTime = 0.05f;
            AnimEase = Ease.Linear;
        }
        else if (AnimType == "结束")
        {
            AnimTime = 0.15f;
            AnimEase = Ease.OutBack;
            GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_SlotsStop_Normal);
        }
        for (int i = 0; i < 7; i++)
        {
            FortFistSink Sink = EvenRocky[Index][i];
            Sink.transform.DOLocalMoveY(Sink.transform.localPosition.y - SinkDime, AnimTime).SetEase(AnimEase);
        }
        Coroutine DelayIE = TheyVaguely.LawFigurine().Habit(AnimTime, () =>
        {
            for (int i = 0; i < 7; i++)
            {
                FortFistSink Sink = EvenRocky[Index][i];
                if (Sink.transform.localPosition.y < Danger) //ͼ���������� ����ͼ�� �ƶ����
                {
                    Sink.transform.localPosition = new Vector2(Sink.transform.localPosition.x, Sit);
                    Sink.Wool(i, Sink.SinkThus);
                    break;
                }
            }

            if (AnimType == "开始")
                EvenSeaSierraLink(Index, "持续");
            else if (AnimType == "持续")
            {
                EvenJoltWhale[Index]++;
                if (EvenJoltWhale[Index] < EvenJoltShe)
                    EvenSeaSierraLink(Index, "持续");
                else
                    EvenSeaSierraLink(Index, "结束");

                //����ٶ������ŵ�������2��  ��ʼ������ʵ�ж���
                if (EvenJoltWhale[Index] == EvenJoltShe - 2)
                    ComeSeaSierraLink(Index, "持续");
            }
            else if (AnimType == "结束" && Index == 4)
            {
                GlobeYet.LawFigurine().HardAdvent(GlobeThus.UIMusic.Sound_SlotsRolling);
            }
        });
        SierraLinkTheyArriveIEs.Add(DelayIE);
    }

    /// <summary>
    /// ��ʵ�������Ž�����
    /// </summary>
    private void ComeEpidermisBoy()
    {
        ComeArchLinkMagic++;
        if (ComeArchLinkMagic >= 5)
        {
            TheyVaguely.LawFigurine().Habit(0.5f, () =>
            {
                MyLinkViolent = false;
                MyHardFortLink = false;
                ComeArchLinkMagic = 0;
                MadTreatFoldEvenWhat();
                LedgeReport.Steep("----------------------   ����  -------------------");
                FortFistShrine();
            });
        }
    }

    private void FortFistShrine()
    {

        SlotPieceData[,] tempdata = FortCopyVaguely.instance.LawTreatRimFeatSeaGrope(Hart_FortYoungCopy);
        Dictionary<int, AwardWinningData> Here= FortCopyVaguely.instance.TrailCityCopyFly(tempdata, out Dictionary<int, List<SlotPiecePositionData>> dic_Reward);
        foreach (var item in Here)
        {
            LedgeReport.Steep("    ��    �� �� " + item.Key + "   ����    ID��  " + item.Value.WinItemData.id + "   ������  " + item.Value.WinNumber);
        }
        _DogHerdVine = 0;
        float oddGold = 0;
        _CrowHerdScatThey = 1.5f;
        if (Here.Count > 0)
        {
            CityCtrl.FortMeadowCityFair(Here);
            FortSinkFairSway = StartCoroutine(JoltEpithetFortSink(dic_Reward));
            _CrowHerdScatThey = _CrowHerdScatThey + dic_Reward.Count * _SeniorFairThey;
            _DogHerdVine = FortCopyVaguely.instance.LawFortMeadowVine(Here);
            LedgeReport.Steep("    ��    ����� �� " + _DogHerdVine, 10);
        }
        else
        {
            FoldEpidermisArch();
        }
        //���û��Ӹ����Ƿ�����
        WinRewardType bigType = FortCopyVaguely.instance.TrailMeadowBoxFly(_DogHerdVine);
        LedgeReport.Steep("     �Ƿ��  ��  " + (Here.Count > 0) + "   �Ƿ�Ϊ��  �� " + bigType);

        if (!FortCopyVaguely.instance.MyTillWageHerd)
        {
            //���û���
            FortCopyVaguely.instance.FortBreakageDogwoodTurkic((Here.Count > 0) && (int)bigType >= (int)WinRewardType.Big);
        }
        
        //��bet����
        FortCopyVaguely.instance.OnChangeBet(0);
        FortCopyVaguely.instance.GatherHerdLittleTurkic();
        FortCopyVaguely.instance.MyTillHerd = false;
        TrailHerdShrine();
    }

    
    public void TrailHerdShrine()
    {
        _SealMeadowMagic++;
        if (_SealMeadowMagic == 1)
        {
            ArchCharmLink();
        }
        else if (_SealMeadowMagic == 2)
        {
            ArchCowhandLink();
        }
        else if (_SealMeadowMagic == 3)
        {
            FortCopyVaguely.instance.TillCharmCoach();
        }
        else if (_SealMeadowMagic == 4)
        {
            //��ȡȫ�л��ӵĽ���
            FortCopyVaguely.instance.LawFoldMeadow();
        }
        else if (_SealMeadowMagic == 5)
        {
            //���û��Ӹ����Ƿ�����
            WinRewardType bigType = FortCopyVaguely.instance.TrailMeadowBoxFly(_DogHerdVine);
            if (_DogHerdVine > 0)
            {
                float oddGold = _DogHerdVine * FortCopyVaguely.instance.LawLeoPegDNALime().OddsNum;
                if ((int)bigType >= (int)WinRewardType.Big && !FortCopyVaguely.instance.MyTillWageHerd)
                {
                    UIInject.LawFigurine().FairUIMarry(nameof(FortMeadowCoach));
                    FortMeadowCoach.instance.MadMeadowLime(bigType, oddGold);
                }
                else
                {
                    FortCopyVaguely.instance.GatherLeoHerdMeadow(oddGold);
                    SitTine.HomeRotEpidermis(HaveObsess.transform, oddGold);
                    TrailHerdShrine();
                }
            }
            else
            {
                TrailHerdShrine();
            }
        }
        else if (_SealMeadowMagic == 6)
        {
            if (FortCopyVaguely.instance.MyTillWageWineFist)
            {
                WineFistTine.BuckleWineFist();
            }
            else
            {
                TrailHerdShrine();
            }
        }
        else
        {
            TillWageHerd();
        }
        
    }
    /// <summary>
    /// ȫ���ӽ���
    /// </summary>
    private void FoldEpidermisArch()
    {
        int wildIndex = 0;

        //ȫ�ǻ��ӵĲ���
        for (int i = 0; i < ComeRocky.Count; i++)
        {
            for (int j = 0; j < ComeRocky[i].Count; j++)
            {
                if (ComeRocky[i][j].MyTreatFold)
                {
                    wildIndex++;
                }
            }
        }
        if (wildIndex >= 15)
        {
            foreach (var item in ComeRocky)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].MyTreatFold && item[i]._WashMagic == 3)
                    {
                        item[i].FoldAlongArch();
                    }
                }
            }
        }
    }



    private void ArchCharmLink()
    {
        bool isOpen = false;
        for (int i = 0; i < ComeRocky.Count; i++)
        {
            for (int j = 0; j < ComeRocky[i].Count; j++)
            {
                if (ComeRocky[i][j].SinkDuringMagic == 10)
                {
                    ComeRocky[i][j].ArchCharmWhatLadLink();
                    isOpen = true;
                }
            }
        }
        if (isOpen)
        {
            StartCoroutine(nameof(CharmGatherTurkic));
        }

        float Luck= isOpen ? 1.5f : 0.5f;
        StartCoroutine(HabitLadLink(Luck));
    }

    IEnumerator CharmGatherTurkic()
    {
        yield return new WaitForSeconds(3);
        FortCopyVaguely.instance.GatherCharmTurkic();
    }

    private void ArchCowhandLink()
    {
        int Scatter = 0;
        for (int i = 0; i < ComeRocky.Count; i++)
        {
            for (int j = 0; j < ComeRocky[i].Count; j++)
            {
                if (ComeRocky[i][j].SinkDuringMagic == 9)
                {
                    Scatter += 1;
                }
            }
        }

        if (Scatter >= 3)
        {
            foreach (var item in ComeRocky)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].SinkDuringMagic == 9)
                    {
                        item[i].CowhandAlongArch();
                    }
                }
            }
        }
        StartCoroutine(HabitLadLink(0.5f));
    }

    IEnumerator HabitLadLink(float time)
    {
        
        yield return new WaitForSeconds(time);
        TrailHerdShrine();
    }
    /// <summary>
    /// ����freespin
    /// </summary>
    public void TillWageHerd()
    {
        if (FortCopyVaguely.instance.MyTillWageWineFist)
        {
            WineFistTine.PegWineFistRadar();
        }
        if (FortCopyVaguely.instance.WageHerdLittle <= 0 && FortCopyVaguely.instance.MyTillWageHerd)
        {
            FortCopyVaguely.instance.MyTillWageHerd = false;
            FortCopyVaguely.instance.MyTillWageWineFist = false;
            UIInject.LawFigurine().FairUIMarry(nameof(FortWageHerdShrineCoach));
            FortWageHerdShrineCoach.Instance.MadHerdShrineGreedy(()=> {
                
                WineFistTine.WineFistRadarFund();
                //����spin����stop��ʾ
                MadHerdOrHardItsFair(true);
                WageHerdModify.gameObject.SetActive(FortCopyVaguely.instance.MyTillWageHerd);
                GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Quick7_Bgm);
                if (!GripCopyVaguely.LawLeft("FirtSlotRateUsPanel") && !RetoolJean.MyEnsue())
                {
                    GripCopyVaguely.MadLeft("FirtSlotRateUsPanel", true);
                    UIInject.LawFigurine().FairUIMarry(nameof(FortCropDyCoach));
                }
                
            });
        }
        if (FortCopyVaguely.instance.MyTillWageHerd)
        {
           StartCoroutine(nameof(WageHerdMaybe));
        }
        else 
        {
            LetterVaguely.LawFigurine().TrailHerdLetterTill(DutyLoam.gameObject, "NewbieSohoFinish", "Congratulations! You can cash outyour winnings once you reach the goal!");
            MadHerdOrHardItsFair(true);
        }
    }

    IEnumerator WageHerdMaybe()
    {
        //freespinģʽ�£��ȴ�ʱ���������ʱ��Ϊ0.5f
        _CrowHerdScatThey = 0.5f;// _freeSpinWaitTime > 3 ? 3 : _freeSpinWaitTime;
        yield return new WaitForSeconds(_CrowHerdScatThey);
        if (FortCopyVaguely.instance.MyTillWageHerdCoach)
        {
            WageHerdModify.gameObject.SetActive(FortCopyVaguely.instance.MyTillWageHerd);
            FortCopyVaguely.instance.MyTillWageHerdCoach = false;
            UIInject.LawFigurine().FairUIMarry(nameof(FortWageHerdCoach));
            FortWageHerdCoach.Instance.MadWageGreedy(()=> {
                OnSpinClick();
                FortCopyVaguely.instance.GatherWageHerdLittle();
                FortCopyVaguely.instance.MyTillWageWineFist = true;
                LedgeReport.Steep("    ---------  FreeSpinNumber ʣ�����  ��   " + FortCopyVaguely.instance.WageHerdLittle);
            });
            yield break;
        }
        OnSpinClick();
        FortCopyVaguely.instance.GatherWageHerdLittle();
        LedgeReport.Steep("    ---------  FreeSpinNumber ʣ�����  ��   " + FortCopyVaguely.instance.WageHerdLittle);
    }

    /// <summary>
    /// ѭ������չʾ�м�item
    /// </summary>
    IEnumerator JoltEpithetFortSink(Dictionary<int, List<SlotPiecePositionData>> dic_Reward)
    {
        int index = 0;
        List<List<SlotPiecePositionData>> list = new();
        foreach (var item in dic_Reward)
        {
            list.Add(item.Value);
        }
        while (true)
        {
            FortSinkEpithet(list[index]);
            index++;
            if (index >= list.Count)
            {
                yield return new WaitForSeconds(_SeniorFairThey);
                index = 0;
                //SlotItemDisplayController(false);
            }
            yield return new WaitForSeconds(_SeniorFairThey);
        }
    }

    private int ComeArchLinkMagic= 0;
    /// <summary>
    /// ��ʵ�ж��� �ٶ�������������� ���żٶ���һ�𲥷�
    /// </summary>
    private void ComeSeaSierraLink(int Index, string AnimType) 
    {
        float AnimTime = 0;
        Ease AnimEase = Ease.Linear;
        if (AnimType == "持续")
        {
            AnimTime = 0.05f;
            AnimEase = Ease.Linear;
        }
        else if (AnimType == "结束")
        {
            AnimTime = 0.15f;
            AnimEase = Ease.OutBack;
        }
        for (int i = 0; i < 3; i++)
        {
            int IndexI = i;
            FortFistSink Sink = ComeRocky[Index][i];
            Sink.transform.DOLocalMoveY(Sink.transform.localPosition.y - SinkDime, AnimTime).SetEase(AnimEase).OnUpdate(() =>
            {
                //���Ź����� �Ѿ�����ʵͼ������ļ�ͼ�����ص� �������ͼ���ص��� ͬʱ�����ͼ��һ�� �����´ζ����Ӿ�������
                for (int j = 0; j < 7; j++)
                {
                    FortFistSink FakeItem = EvenRocky[Index][j];
                    if (Mathf.Abs(Sink.transform.position.y - FakeItem.transform.position.y) < .5f)
                    {
                        FakeItem.FundWhat(Sink.SinkDuringMagic, Sink.SinkThus);
                        MadEvenLawMeadowSink(Index, FakeItem);
                    }
                }
            });
            
        }
        Coroutine DelayIE = TheyVaguely.LawFigurine().Habit(AnimTime, () =>
        {
            if (AnimType == "持续")
            {
                ComeJoltWhale[Index]++;
                if (ComeJoltWhale[Index] < 2)
                    ComeSeaSierraLink(Index, "持续");
                else
                    ComeSeaSierraLink(Index, "结束");
            }
            else if (AnimType == "结束")
            {
                ComeEpidermisBoy();
            }
        });
        SierraLinkTheyArriveIEs.Add(DelayIE);
    }
    #endregion

   
}
