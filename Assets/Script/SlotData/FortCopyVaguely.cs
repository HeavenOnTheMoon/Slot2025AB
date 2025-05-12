using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;

public class FortCopyVaguely : MonoBehaviour
{
    public static FortCopyVaguely instance;
    //-------------  ����  ------------//
    /// <summary>
    /// ת����Ϣ����
    /// </summary>
    private SlotAllInfo FortBegin;
    /// <summary>
    /// ����ת���Ľ�����Ϣ
    /// </summary>
    private List<SlotPieceData> Hart_FortRadarCopy;
    /// <summary>
    /// ����item����
    /// </summary>
    private List<SlotPieceData> Hart_FortYoung;
    /// <summary>
    /// ��ý�����������
    /// </summary>
    private LineConfigInfo CityBegin;
    /// <summary>
    /// �̶����ߵ���Ϣ
    /// </summary>
    private List<List<LineGetWinInfo>> Hart_CityFlyCopy;

    //-------------  �󽱲���  ------------//
    private List<int> Hart_BoxFlyLittle;
[UnityEngine.Serialization.FormerlySerializedAs("BigWinFreeSpinNumber")]
    public int BoxFlyWageHerdLittle;
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinNumber")]
    //-------------  FreeSpin  -------------//
    /// <summary>
    /// freeSpin����
    /// </summary>
    public int WageHerdLittle;
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinAllNumber")]    /// <summary>
    /// freeSpin�Ĵ��������ı�
    /// </summary>
    public int WageHerdHimLittle;
    //Freespin��index
    private int WageHerdMagic;
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinGetCoinNumber")]    //freespin��ȡ�Ļ�������
    public int WageHerdLawHaveLittle;
[UnityEngine.Serialization.FormerlySerializedAs("ScatterNumber")]
    public int CowhandLittle;
[UnityEngine.Serialization.FormerlySerializedAs("IsOpenFreeSpin")]    //�Ƿ���freespin
    public bool MyTillWageHerd;
[UnityEngine.Serialization.FormerlySerializedAs("IsOpenFreeSpinPanel")]
    public bool MyTillWageHerdCoach;
[UnityEngine.Serialization.FormerlySerializedAs("IsOpenSpin")]
    public bool MyTillHerd;
[UnityEngine.Serialization.FormerlySerializedAs("IsOpenFreeMiniGame")]
    public bool MyTillWageWineFist;
    /// <summary>
    /// free����ͼ����ת�Ĵ���
    /// </summary>
    private List<FreeSpinReward> Hart_WageHerdMeadow;

    //-------------  ����  -------------//
    /// <summary>
    /// ���ӵĸ���
    /// </summary>
    private int FoldDogwood;
    private int FoldDogwoodTurkic;
    //���ӵ�index
    private int FoldMagic;
    private List<float> Hart_FoldMeadow;
    private List<bool> Hart_ReputeHimFold;

    //-------------  ��ע  -------------//
    private List<SlotBetInfo> Hart_DNALime;

    private int LeoPegDNA;
    private SlotBetInfo LeoPegDNALime;
[UnityEngine.Serialization.FormerlySerializedAs("CurBonusNumber")]    //-------------  Bonus  -------------//
    //����spin��Bonus����
    public int LeoCharmLittle;

    private int CharmMagic;
    //-------------  spin����  -------------//
    //spin�Ľ���list
    private List<SlotSpinInfo> Hart_FortHerdLime;
[UnityEngine.Serialization.FormerlySerializedAs("CurSpinNumber")]    //��ǰspin����
    public int LeoHerdLittle;
[UnityEngine.Serialization.FormerlySerializedAs("RewardSpinMaxNumber")]    //�����ܴ���
    public int MeadowHerdSheLittle;

    private int _LegHerdLittle;
    public int HimHerdLittle    {
        get {
            _LegHerdLittle = GripCopyVaguely.LawAid("AllSpinNumber");
            return _LegHerdLittle;
        }
        set
        {

            _LegHerdLittle = value;
            GripCopyVaguely.MadAid("AllSpinNumber", _LegHerdLittle);
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("CruSpinRewardNumber")]
    //-------------  ͨ�ý���  -------------//

    /// <summary>
    /// ��ǰspin������õ����н�������
    /// </summary>
    public float RunHerdMeadowLittle;

    private void Awake()
    {
        instance = this;
        FoldMagic = 1;
        WageHerdMagic = 9;
        CharmMagic = 10;
        LeoCharmLittle = GripCopyVaguely.LawAid("CurBonusNumber");
        LeoHerdLittle = GripCopyVaguely.LawAid("CurSpinNumber"); 
        WageHerdLittle = 0;
        MyTillHerd = false;
        MyTillWageHerd = false;
        MyTillWageHerdCoach = false;
        Hart_ReputeHimFold = new List<bool>();
        Hart_FortYoung = new List<SlotPieceData>();
        Hart_FortRadarCopy = new List<SlotPieceData>();
        Hart_CityFlyCopy = new List<List<LineGetWinInfo>>();
        
    }

    private void Start()
    {
        
    }

    public void FortCopyYetWool()
    {
        //�󽱵�ֵ������5000Ϊ�󽱣����ĸ����ش�
        Hart_BoxFlyLittle = new List<int>() { 0, 100 * LawEnsueHomeOral(), 200 * LawEnsueHomeOral(), 500 * LawEnsueHomeOral() };
        //�������ӵĽ������������ӣ���������
        Hart_FoldMeadow = new List<float>() { 500 * LawEnsueHomeOral(), 1000 * LawEnsueHomeOral(), 3000 * LawEnsueHomeOral() };

        WoolFortCopy();
        WoolCityCopy();
        WoolDNALime();
        WoolFortHerdLime();

        LeoPegDNA = 0;
        LeoPegDNALime = Hart_DNALime[LeoPegDNA];
    }

    #region ���ݳ�ʼ��
    /// <summary>
    /// ��ʼ���ϻ�������
    /// </summary>
    private void WoolFortCopy()
    {
        TextAsset json = null;
        /*if (!RetoolJean.IsApple())*/
            json = Resources.Load<TextAsset>("JsonData/SlotDataConfig");
        /*else
            json = Resources.Load<TextAsset>("JsonData/SlotDataConfig2");*/
        Debug.Log("slotJson == " + json);
        FortBegin = JsonMapper.ToObject<SlotAllInfo>(json.text);

        for (int i = 0; i < FortBegin.data.SevenSlot.Count; i++)
        {
            for (int j = 0; j < FortBegin.data.SevenSlot[i].slotPiece.Count; j++)
            {
                if (FortBegin.data.SevenSlot[i].slotPiece[j].id == FoldMagic)
                {
                    FoldDogwood = FortBegin.data.SevenSlot[i].slotPiece[j].weights;
                    FoldDogwoodTurkic = FortBegin.data.SevenSlot[i].slotPiece[j].weights;
                }
                Hart_FortYoung.Add(FortBegin.data.SevenSlot[i].slotPiece[j]);
            }
            break;
        }

        Hart_WageHerdMeadow = FortBegin.data.freeSpinReward;
    }
    /// <summary>
    /// ��ע��Ϣ��ʼ��
    /// </summary>
    private void WoolDNALime()
    {
        Hart_DNALime = new List<SlotBetInfo>();
        Hart_DNALime.Add(new SlotBetInfo(800, 0.8f, 0.01f));
        Hart_DNALime.Add(new SlotBetInfo(900, 0.9f, 0.01125f));
        Hart_DNALime.Add(new SlotBetInfo(1000, 1f, 0.0125f));
    }

    private void WoolFortHerdLime()
    {
        Hart_FortHerdLime = new List<SlotSpinInfo>();
        Hart_FortHerdLime.Add(new SlotSpinInfo(10, 10 * LawEnsueHomeOral(), false));
        Hart_FortHerdLime.Add(new SlotSpinInfo(30, 20 * LawEnsueHomeOral(), false));
        Hart_FortHerdLime.Add(new SlotSpinInfo(60, 30 * LawEnsueHomeOral(), false));
        Hart_FortHerdLime.Add(new SlotSpinInfo(100, 50 * LawEnsueHomeOral(), false));
        /*for (int i = 0; i < List_SlotSpinInfo.Count; i++)
        {
            RewardSpinMaxNumber += List_SlotSpinInfo[i].SpinNumber;
        }*/
        MeadowHerdSheLittle = Hart_FortHerdLime[Hart_FortHerdLime.Count - 1].SpinNumber;
    }

    /// <summary>
    /// ��ʼ�����ߵ���Ϣ
    /// </summary>
    private void WoolCityCopy()
    {
        TextAsset json = Resources.Load<TextAsset>("JsonData/LineConfig");
        CityBegin = JsonMapper.ToObject<LineConfigInfo>(json.text);
        for (int i = 0; i < CityBegin.lineData.Count; i++)
        {
            List<LineGetWinInfo> list = new List<LineGetWinInfo>();
            LineData info = CityBegin.lineData[i];
            // ��ȡLineData����
            Type type = info.GetType();
            // ��ȡ���й���ʵ���ֶ�
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                object value = field.GetValue(info);
                int tempValue = Convert.ToInt32(value);

                if (field.Name != "id")
                {
                    list.Add(LawCityLawFlyLime(field.Name, tempValue));
                }
            }
            Hart_CityFlyCopy.Add(list);
        }

    }
    #endregion

    #region ��������

    public Sprite LawEnsueDuringHome()
    {
        string path = RetoolJean.MyEnsue() ? "Art/Tex/Coin/What_Have_s" : "Art/Tex/Coin/Home_SitSod";
        return Resources.Load<Sprite>(path);
    }

    public int LawEnsueHomeOral()
    {
        return RetoolJean.MyEnsue() ? 1000 : 1;
    }


    public int LawBreakageMagic()
    {
        return FoldMagic;
    }
    /// <summary>
    /// ������
    /// </summary>
    public List<SlotPieceData> LawFortFlyCopy()
    {
        if (!MyTillWageHerd)
        {
            LeoHerdLittle++;
            ADVaguely.Figurine.TurkicExtraJob(LeoHerdLittle);
            GripCopyVaguely.MadAid("CurSpinNumber", LeoHerdLittle);
            FortWineCopyVaguely.LawFigurine().TillBodeHut();
        }
        RegretEachRiseCopy();
        return Hart_FortRadarCopy;
    }

    /// <summary>
    /// ����ÿ�����ӵĻ���Ϣ
    /// </summary>
    public void RegretEachRiseCopy()
    {
        Hart_FortRadarCopy.Clear();
        Hart_ReputeHimFold.Clear();
        int scatterCount = 0;
        int bonusCount = 0;
        var Here= FortBegin.data.SevenSlot;
        for (int i = 0; i < Here.Count; i++)
        {
            var temp = RegretRibRiseCopy(Here[i]);
            Hart_FortRadarCopy.Add(temp);
        }
        //���ô󽱱���
        BoxFlyGhostly();
        if (!MyTillWageHerd)
        {
            //����freespin����
            CowhandGhostly();
        }
        for (int i = 0; i < Hart_FortRadarCopy.Count; i++)
        {
            var temp = Hart_FortRadarCopy[i];
            scatterCount = (temp.type == "Scatter") ? scatterCount + 1 : scatterCount;
            bonusCount = (temp.type == "Bonus") ? bonusCount + 1 : bonusCount;
        }
        if (bonusCount > 0)
        {
            LeoCharmLittle += bonusCount;
            GripCopyVaguely.MadAid("CurBonusNumber", LeoCharmLittle);
        }
        LedgeReport.Steep("--------------   scatterCount   " + scatterCount + " -----   IsOpenFreeSpin  " + MyTillWageHerd, 10);
        if (scatterCount > 0 && !MyTillWageHerd)
        {
            //����freespin����
            MadWageHerdLittle(scatterCount);
        }

    }


    /// <summary>
    /// �󽱲���
    /// </summary>
    private void BoxFlyGhostly()
    {
        SlotPieceData Here= new SlotPieceData();
        Here.id = 1;
        Here.type = "wild";
        Here.weights = 5;
        LedgeReport.Steep("--------------   bigwin��ǰ����   " + BoxFlyWageHerdLittle + " -----   �Ƿ�������  " + (BoxFlyWageHerdLittle % 7 == 0), 10);
        if (BoxFlyWageHerdLittle % 7 == 0 || !GripCopyVaguely.LawLeft("FirstPlaySpin"))
        {
            int random = BoxFlyDogwood();//Random.Range(3, 6);
            int[] array =  LawSeduceMortalDeclare(0, 4, random);
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i] * 3;
                for (int j = temp; j < temp + 3; j++)
                {
                    list.Add(j);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Hart_FortRadarCopy[list[i]] = Here;
            }
        }
    }

    private int BoxFlyDogwood()
    {
        if (!GripCopyVaguely.LawLeft("FirstWildBigWin"))
        {
            GripCopyVaguely.MadLeft("FirstWildBigWin", true);
            return 5;
        }
        var Here= FortBegin.data.wildWeights;
        int all = 0;
        for (int i = 0; i < Here.Count; i++)
        {
            all += Here[i].weights;
        }
        int random = Random.Range(0,all+1);
        int id = 3;
        int allrandom = 0;
        for (int i = 0; i < Here.Count; i++)
        {
            allrandom += Here[i].weights;
            if (random <= Here[i].weights)
            {
                id = Here[i].id;
                return id;
            }
        }
        return id;
    }

    /// <summary>
    /// freespin����
    /// </summary>
    private void CowhandGhostly()
    {
        SlotPieceData Here= new SlotPieceData();
        Here.id = 9;
        Here.type = "Scatter";
        Here.weights = 5;
        LedgeReport.Steep("--------------  Scatter ��ǰ����   " + BoxFlyWageHerdLittle + " -----   �Ƿ�������  " + (BoxFlyWageHerdLittle % 10 == 0)+"    �Ƿ�����  ��    " + (BoxFlyWageHerdLittle % 10 == 0 || !GripCopyVaguely.LawLeft("FirstPlaySpin") && BoxFlyWageHerdLittle > 1), 10);
        if (BoxFlyWageHerdLittle % 10== 0 || !GripCopyVaguely.LawLeft("FirstPlaySpin") && BoxFlyWageHerdLittle > 1)
        {
            int random = 3;
            int[] array = LawSeduceMortalDeclare(0, 14, random);
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Hart_FortRadarCopy[list[i]] = Here;
            }
        }
    }


    // ͨ�÷������� [min, max] ��ѡȡ count �����ظ��������
    private int[] LawSeduceMortalDeclare(int min, int max, int count)
    {
        List<int> candidates = new List<int>();
        for (int i = min; i <= max; i++)
        {
            candidates.Add(i);
        }

        List<int> selected = new List<int>();
        for (int i = 0; i < count; i++)
        {
            int index = Random.Range(0, candidates.Count);
            selected.Add(candidates[index]);
            candidates.RemoveAt(index);
        }

        return selected.ToArray();
    }


    /// <summary>
    /// ������Ϣ
    /// </summary>
    public Dictionary<int, AwardWinningData> TrailCityCopyFly( SlotPieceData[,] data,out Dictionary<int, List<SlotPiecePositionData>> dic_Reward)
    {
        int index = 0;
        Dictionary<int, List<SlotPiecePositionData>> dic = new Dictionary<int, List<SlotPiecePositionData>>();
        for (int i = 0; i < Hart_CityFlyCopy.Count; i++)
        {
            List<SlotPiecePositionData> tempList = new();
            for (int j = 0; j < Hart_CityFlyCopy[i].Count; j++)
            {
                SlotPiecePositionData posdata = new SlotPiecePositionData();
                posdata.x = Hart_CityFlyCopy[i][j].x;
                posdata.y = Hart_CityFlyCopy[i][j].y;
                posdata.WinItemData = data[Hart_CityFlyCopy[i][j].y, Hart_CityFlyCopy[i][j].x];
                tempList.Add(posdata);
            }
            dic.Add(index, tempList);
            index++;
        }
        //�񽱵��ߣ��񽱵�item
        Dictionary<int, AwardWinningData> awardWinDic = new();
        //�񽱵�list
        dic_Reward = new Dictionary<int, List<SlotPiecePositionData>>();
        List<SlotPiecePositionData> list_tempPiece = new();
        foreach (var item in dic)
        {
            int rewardNum = TrailProgressiveLocallyPro(item.Value,out list_tempPiece, out SlotPieceData pieceData);
            if (rewardNum > 0)
            {
                AwardWinningData reward = new AwardWinningData();
                reward.WinNumber = rewardNum;
                reward.WinItemData = pieceData;//item.Value[0].WinItemData;
                awardWinDic.Add(item.Key,reward);
                dic_Reward.Add(item.Key, list_tempPiece);
            }
        }
        return awardWinDic;
    }

    /// <summary>
    /// ��ȡ�������еĶ�ά����
    /// �ṹ��0,0   0,1  0,2  0,3  0,4
    ///       1,0   1,1  1,2  1,3  1,4  
    ///       2,0   2,1  2,2  2,3  2,4  
    /// </summary>
    public SlotPieceData[,] LawTreatRimFeatSeaGrope(List<SlotPieceData> list)
    {
        // ����3��5�еĶ�ά����
        int rows = 3;
        int cols = 5;
        SlotPieceData[,] array2D = new SlotPieceData[rows, cols];
        // ��������˳�����
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                int index = col * rows + row; // ����List�е�����
                if (index < list.Count)
                {
                    array2D[row, col] = list[index];
                }
            }
        }
        return array2D;
    }


    /// <summary>
    /// ��ȡת�̻�õĽ���
    /// </summary>
    public float LawFortMeadowVine(Dictionary<int, AwardWinningData> data)
    {
        float gold = 0;
        foreach (var item in data)
        {
            int tempgold = LawFortMeadowSinkVine(item.Value.WinItemData.type, item.Value.WinNumber);
            gold += tempgold;
        }
        //gold = gold;
        return gold * LawEnsueHomeOral();
    }

    /// <summary>
    /// ���û��Ӹ����Ƿ�����,Ϊtrue����
    /// </summary>
    public void FortBreakageDogwoodTurkic(bool isWin)
    {
        if (isWin)
        {
            FoldDogwoodTurkic = FoldDogwood;
        }
        else
        {
            FoldDogwoodTurkic += 50;
        }
        LedgeReport.Steep("   ���ӵĸ���  ��  " + FoldDogwoodTurkic);
    }

    /// <summary>
    /// ͨ��ID��ȡ��������Ϣ
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public SlotPieceData LawFortYoungLime(int index)
    {
        if (index >= Hart_FortYoung.Count) return Hart_FortYoung[0];
        SlotPieceData Here= new SlotPieceData();
        for (int i = 0; i < Hart_FortYoung.Count; i++)
        {
            if (Hart_FortYoung[i].id == index)
            {
                Here =  Hart_FortYoung[i];
            }
        }
        return Here;
    }


    public void SeatLeoHerdMeadow()
    {
        RewriteNeuronNiche.LawFigurine().Seat("TokenUpdate", null);
    }

    //-------------------------------  �󽱲���  ---------------------//
    /// <summary>
    /// ����Ƿ�Ϊ��
    /// </summary>
    public WinRewardType TrailMeadowBoxFly(float number )
    {
        // Ĭ�Ϸ�����ͽ���
        int typeIndex = 0;
        if (Hart_BoxFlyLittle.Count == 0)
            return (WinRewardType)typeIndex;

        // �Ӹߵ��ͼ�飬�ҵ���һ������������
        for (int i = Hart_BoxFlyLittle.Count - 1; i >= 0; i--)
        {
            if (number >= Hart_BoxFlyLittle[i])
            {
                typeIndex = i;
                break;
            }
        }
        return (WinRewardType)typeIndex;
    }

    //-------------------------------  ����ӽ���  ---------------------//
    public List<float> LawGateFoldMeadow()
    {
        List<float> list = new List<float>();
        for (int i = 0; i < Hart_FoldMeadow.Count; i++)
        {
            decimal Dual= (int)Hart_FoldMeadow[i] * (decimal)LeoPegDNALime.OddsNum;
            list.Add((float)Dual);
        }
        return list;
    }

    public List<float> LawFoldMeadowLime()
    {
        return Hart_FoldMeadow;
    }

    /// <summary>
    /// ÿһ���Ƿ��ǻ���
    /// </summary>
    public void MadReputeFoldHim(int x, bool isAll)
    {
        Hart_ReputeHimFold.Add(isAll);
    }

    public void LawFoldMeadow()
    {
        int count = 0;
        for (int i = 0; i < Hart_ReputeHimFold.Count; i++)
        {
            if (Hart_ReputeHimFold[i])
            {
                count++;
            }
        }
        if (count >= 3)
        {
            var Here= LawGateFoldMeadow();
            LedgeReport.Steep("-------  ��ȡ���ӽ�����ǰΪ�� " + count + "    ��ȡ�Ľ��� �� " + Here[count - 3], 10);
            UIInject.LawFigurine().FairUIMarry(nameof(FortFoldMeadowCoach));
            FortWineCopyVaguely.LawFigurine().SeatFoldFistCoach((count - 3), Here[count - 3],"wild");
        }
        else
        {
            FortFistCoach.Instance.TrailHerdShrine();
        }
    }

    //-------------------------------  ����  ---------------------//

    public void HerdMandanHome(double cash)
    {
        //float cash = RetoolJean.IsApple() ? CurUseBetInfo.GoldNum : CurUseBetInfo.CashNum;
        
        AprilFistCopyVaguely.LawFigurine().LotBloom(cash);
        SeatLeoHerdMeadow();
    }

    public void OnBetUpdate(bool isAdd)
    {
        if (MyTillHerd) return;
        if (MyTillWageHerd) return;
        if (isAdd && LeoPegDNA >=2) return;
        if (!isAdd && LeoPegDNA == 0) return;
        LeoPegDNA = isAdd ? ++LeoPegDNA : --LeoPegDNA;
        LeoPegDNALime = Hart_DNALime[LeoPegDNA];
        LedgeReport.Steep("-------  ��ǰʹ�õı��ʣ� " + LeoPegDNALime.OddsNum, 10);
        RewriteSeatDNA();
    }

    public void OnChangeBet(int num)
    {
        if (MyTillHerd) return;
        if (MyTillWageHerd) return;
        if (num < 0 || num > 2) return;
        LeoPegDNA = num;
        LeoPegDNALime = Hart_DNALime[num];
        RewriteSeatDNA();
    }

    public SlotBetInfo LawLeoPegDNALime()
    {
        return LeoPegDNALime;
    }

    private void RewriteSeatDNA()
    {
        RewriteNeuronNiche.LawFigurine().Seat("SendBet");
    }

    //-------------------------------  Bonus  ---------------------//
    public void GatherCharmTurkic()
    {
        LedgeReport.Steep("    Bonus�ۼ� �� " + LeoCharmLittle);
       
        var Here= new RewriteCopy(LeoCharmLittle);
        RewriteNeuronNiche.LawFigurine().Seat("SendBonusNumber", Here);
    }

    public void TillCharmCoach()
    {
        if (LeoCharmLittle >= 20)
        {
            LeoCharmLittle = 0;
            GripCopyVaguely.MadAid("CurBonusNumber", LeoCharmLittle);
            //GildFistVaguely.GetInstance().OpenSlotFlopGamePanel();
            UIInject.LawFigurine().FairUIMarry(nameof(FortGildFistCoach));
            //FortGildFistCoach.instance.SlotFlopGamePanelInit();
            LedgeReport.Steep("      Bonus�ۼ�������ȡ���� ������");
            GatherCharmTurkic();
        }
        else
        {
            FortFistCoach.Instance.TrailHerdShrine();
        }
        
    }
    //-------------------------------  SpinReward  ---------------------//
    public List<SlotSpinInfo> LawHerdMeadowLime()
    {
        return Hart_FortHerdLime;
    }

    public void GatherHerdLittleTurkic()
    {
        for (int i = 0; i < Hart_FortHerdLime.Count; i++)
        {
            if (LeoHerdLittle >= Hart_FortHerdLime[i].SpinNumber && !Hart_FortHerdLime[i].IsGetReward)
            {
                LedgeReport.Steep("      Spin�ﵽ " + Hart_FortHerdLime[i].SpinNumber  +"��ȡ���� ������");
                Hart_FortHerdLime[i].IsGetReward = true;
                AprilFistCopyVaguely.LawFigurine().LotBloom(Hart_FortHerdLime[i].CashNumber, HerdCoachTine.instance.Hart_MeadowSink[i].transform);
                SitCoachTine.instance.HomeRotEpidermis(HerdCoachTine.instance.Hart_MeadowSink[i].transform,Hart_FortHerdLime[i].CashNumber);
            }
        }
        if (LeoHerdLittle >= MeadowHerdSheLittle)
        {
            LeoHerdLittle = 0;
            GripCopyVaguely.MadAid("CurSpinNumber", LeoHerdLittle);
            WoolFortHerdLime();
            LedgeReport.Steep($"----------   Spin�ۼ���{MeadowHerdSheLittle},����Spin�������� ������");
        }
        var Here= new RewriteCopy(LeoHerdLittle);
        RewriteNeuronNiche.LawFigurine().Seat("SendSpinNumber", Here);
    }

    //-------------------------------  FreeSpin  ---------------------//
    public void GatherWageHerdLittle()
    {
        if (!MyTillWageHerd) return;
        
        WageHerdLittle--;
        
    }

    //-------------  ͨ�ý���  -------------//
    /// <summary>
    /// һ��spin�����н���������freeSpin
    /// </summary>
    public void GatherLeoHerdMeadow(float number)
    {
        if (number == 0)
        {
            RunHerdMeadowLittle = 0;
        }
        else
        {
            RunHerdMeadowLittle += number;
        }
        RewriteNeuronNiche.LawFigurine().Seat("CurSpinRewardUpdate", new RewriteCopy(RunHerdMeadowLittle));
    }

    #endregion

    #region ˽�з���

    /// <summary>
    /// �����ߵ���Ϣ
    /// </summary>
    private LineGetWinInfo LawCityLawFlyLime(string name, int value)
    {
        LineGetWinInfo lineinfo = new LineGetWinInfo();
        switch (name)
        {
            case "nodeOne":
                lineinfo.x = 0;
                break;
            case "nodeTwo":
                lineinfo.x = 1;
                break;
            case "nodeThree":
                lineinfo.x = 2;
                break;
            case "nodeFour":
                lineinfo.x = 3;
                break;
            case "nodeFive":
                lineinfo.x = 4;
                break;
        }
        lineinfo.y = value;
        return lineinfo;
    }

    /// <summary>
    /// �ж��Ƿ��
    /// </summary>
    private int TrailProgressiveLocallyPro(List<SlotPiecePositionData> list, out List<SlotPiecePositionData> rewardList,out SlotPieceData pieceData)
    {
        rewardList = new List<SlotPiecePositionData>();
        pieceData = new SlotPieceData();
        if (list == null || list.Count < 3) return 0;

        int reference = list[0].WinItemData.id;
        //���reference��ֵ�ǻ��ӣ��鿴��һ����ֱ����Ϊ����
        int referIndex = 0;
        pieceData = list[referIndex].WinItemData;
        while (referIndex < list.Count && reference == FoldMagic)
        {
            if (reference == FoldMagic)
            {
                reference = list[referIndex].WinItemData.id;
                pieceData = list[referIndex].WinItemData;
            }
            referIndex++;
        }
        int matchCount = 1;
        rewardList.Add(list[0]);
        for (int i = 1; i < list.Count; i++)
        {
            //��������id == ��id || ����id == ����id  �� && ����id != ���spin  && ��id != ����
            if ((list[i].WinItemData.id == reference || list[i].WinItemData.id == FoldMagic) && 
                list[i].WinItemData.id != WageHerdMagic  && reference != CharmMagic)//&& reference != WildIndex
            {
                matchCount++;
                rewardList.Add(list[i]);
                // ��ǰ��ֹ����
                if (matchCount >= 5) return 5;
            }
            else
            {
                break;
            }
        }
       
        return matchCount >= 3 ? matchCount : 0;
    }

    /// <summary>
    /// �����������ӵĻ���Ϣ
    /// </summary>
    /// <param name="data"></param>
    private SlotPieceData RegretRibRiseCopy(SevenSlot data)
    {
        int allWeights = 0;
        var list = data.slotPiece;
        for (int i = 0; i < list.Count; i++)
        {
            int weight = list[i].weights;
            if (list[i].id == FoldMagic)
            {
                weight = FoldDogwoodTurkic;
            }
            if (list[i].type == "Scatter" && MyTillWageHerd)
            {
                weight = 0;
            }
            allWeights +=weight;
        }
        int random = Random.Range(0, allWeights + 1);
        int tempWeight = 0;
        SlotPieceData tempData = list[list.Count - 1];
        for (int i = 0; i < list.Count; i++)
        {
            int weight = list[i].weights;
            if (list[i].id == FoldMagic)
            {
                weight = FoldDogwoodTurkic;
            }
            if (list[i].type == "Scatter" && MyTillWageHerd)
            {
                weight = 0;
            }
            tempWeight += weight;
            if (random < tempWeight)
            {
                tempData = list[i];
                break;
            }
        }
        return tempData;
    }

    /// <summary>
    /// ��õ����ߵĽ���
    /// </summary>
    private int LawFortMeadowSinkVine(string winType, int winNumber)
    {
        if (FortBegin == null || FortBegin.data == null) return 0;
        int goldNum = 0;
        foreach (var item in FortBegin.data.winLine)
        {
            if (winType == item.winType && winNumber == item.lines)
            {
                goldNum = item.goldcount;
            }
        }
        return goldNum;
    }

    /// <summary>
    /// ����FreeSpin�Ĵ���
    /// </summary>
    private void MadWageHerdLittle(int count)
    {
        if (count < Hart_WageHerdMeadow[0].count) return;
        for (int i = 0; i < Hart_WageHerdMeadow.Count; i++)
        {
            if (count == Hart_WageHerdMeadow[i].count)
            {
                MyTillWageHerd = true;
                MyTillWageHerdCoach = true;
                WageHerdLittle = Hart_WageHerdMeadow[i].value;
                WageHerdHimLittle = WageHerdLittle;
                CowhandLittle = count;
                LedgeReport.Steep("-------------------     FreeSpin����   " + WageHerdLittle,10);
            }
        }
    }


  
    #endregion
}

public class SlotAllInfo
{
    public SlotData data { get; set; }
}

public class LineConfigInfo
{
    public List<LineData> lineData { get; set; }
}

public class LineGetWinInfo
{
    public int x;
    public int y;
}
/// <summary>
/// �񽱵���
/// </summary>
public class AwardWinningData
{
    /// <summary>
    /// ������
    /// </summary>
    public int WinNumber;
    /// <summary>
    /// ������
    /// </summary>
    public SlotPieceData WinItemData;
}

/// <summary>
/// �񽱵�item��λ��+��Ϣ(������ʾ����ʹ��)
/// </summary>
public class SlotPiecePositionData
{
    public int x;
    public int y;
    public SlotPieceData WinItemData;
}

/// <summary>
/// ������
/// </summary>
public class SlotBetInfo
{
    public float GoldNum;
    public float CashNum;
    public float OddsNum;

    public SlotBetInfo(float goldNum, float cashNum, float oddsNum)
    {
        GoldNum = goldNum;
        CashNum = cashNum;
        OddsNum = oddsNum;
    }
}

/// <summary>
/// Slot��spin����
/// </summary>
public class SlotSpinInfo
{
    public int SpinNumber;
    public float CashNumber;
    public bool IsGetReward;

    public SlotSpinInfo(int spinNumber, float cashNumber,bool isGetReward)
    {
        SpinNumber = spinNumber;
        CashNumber = cashNumber;
        IsGetReward = isGetReward;
    }
}

public enum WinRewardType {None, Big , Mega, Super }

public enum WildRewardType { Mini,Major,Grand}
