using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FortWineCopyVaguely : EarnCommunity<FortWineCopyVaguely>
{
    public MiniGameInfo WineCopy;

    //----------------- slotС��Ϸ -----------------//
    public bool[] WineFistFortLinkBoy;
    //ս���
    private string[] WineFistCharmShirtWeird;
    //ս����Ϣ
    public List<MiniBonusRewardInfo> Hart_WineCharmMeadowLime;

    public long LeoWineCharmThey;

    /// <summary>
    /// �ղ�Ʒ
    /// </summary>
    public List<MiniBonusCardInfo> Hart_WineSimulationHaleLime;
    // �ղ�Ʒ����
    private string[] WineFistHaleShirtWeird;

    //----------------- freeSpinת��С��Ϸ -----------------//
    public List<int> Hart_WineFistRadarSpurWhale;
    //С��Ϸtypelist��ÿ�ε�6��С��Ϸ����ͬ
    public List<int> Hart_WineFistThusCopy;
    public int LeoWineFistID;
    //С��Ϸ��index
    public int LeoWineFistMagic;
    //ת�̵�index
    public int LeoWineFistRadarMagic;
    //----------------- ���� -----------------//
    public bool MyTillVineHut    {
        get {
            return GripCopyVaguely.LawLeft("OpenGoldPig");
        }
        set {
            GripCopyVaguely.MadLeft("OpenGoldPig", value);
        }
    }
    public long LeoBodeHutThey;

    public double LeoBodeHutHome;

    protected override void Awake()
    {
        base.Awake();
        
        Hart_WineFistThusCopy = new List<int>();
        Hart_WineCharmMeadowLime = new List<MiniBonusRewardInfo>();
        WineFistFortLinkBoy = new bool[4] { false, false, false, false };
        Hart_WineFistRadarSpurWhale = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2 };
    }


    //----------------- С��Ϸ���� -----------------//

    public void WineCopyWool()
    {
        TextAsset json = Resources.Load<TextAsset>("JsonData/MiniGameConfig");
        WineCopy = JsonMapper.ToObject<MiniGameInfo>(json.text);
        Debug.Log("MiniJson == " + json);

        WineFistCharmShirtCopyWool();
        FortHaleMeadowWeirdWool();
        TrailCharmTheyTreatGram();
        if (MyTillVineHut)
        {
            TrailVineHutThey();
        }
    }

 

    //----------------- slotС��Ϸ -----------------//
    /// <summary>
    /// �޸�С��Ϸslot����
    /// </summary>
    public void GatherWineFistFortArchLinkBoy(int index,bool isend)
    {
        if (index >= WineFistFortLinkBoy.Length) return;
        WineFistFortLinkBoy[index] = isend;

        int endIndex = 0;
        for (int i = 0; i < WineFistFortLinkBoy.Length; i++)
        {
            if (WineFistFortLinkBoy[i])
            {
                endIndex += 1;
            }
        }
        if (endIndex >= 4)
        {
            GlobeYet.LawFigurine().HardAdvent(GlobeThus.UIMusic.Sound_SlotsRolling);
            //GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Chest_Get);
            Debug.Log("-----------  ��ý���");
            StartCoroutine(nameof(SeatWineFistFortMeadow));
        }
    }

    IEnumerator SeatWineFistFortMeadow()
    {
        yield return new WaitForSeconds(0.5f);
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Chest_Get);
        RewriteNeuronNiche.LawFigurine().Seat("MiniGameSlotsFinish", null);
    }

    public float LawWineFistFortMeadow()
    {
        WineFistFortLinkBoy = new bool[4] { false, false, false, false };
        return Random.Range(0.1f, 9.99f); 
    }

    //----------------- ս�� -----------------//

    public List<MiniBonusRewardInfo> LawWineDramaLime()
    {
        return Hart_WineCharmMeadowLime;
    }
    /// <summary>
    /// ս���Ƿ���ȡ��0δ��ȡ/δ������1��ȡ/������ 
    /// ��0��0��ǰ���ǽ�������������ȡ
    /// </summary>
    public void WineFistCharmShirtCopyWool()
    {
        WineFistCharmShirtWeird = GripCopyVaguely.LawExcessGrope("BonusItemInfo");
        if (WineFistCharmShirtWeird.Length == 0)
        {
            WineFistCharmShirtWeird = new string[WineCopy.data.LuckyBonusData.Count];
            for (int i = 0; i < WineCopy.data.LuckyBonusData.Count; i++)
            {
                WineFistCharmShirtWeird[i] = i == 0 ? "1,0" :"0,0";
            }
            GripCopyVaguely.MadExcessGrope("BonusItemInfo", WineFistCharmShirtWeird);
        }
        WineFistCharmMeadowWool();
    }
    /// <summary>
    /// ����list��ʼ��
    /// </summary>
    public void WineFistCharmMeadowWool()
    {
        for (int i = 0; i < WineCopy.data.LuckyBonusData.Count; i++)
        {
            var Here= WineCopy.data.LuckyBonusData[i];
            string[] tempstr = WineFistCharmShirtWeird[i].Split(',');
            int locknum = int.Parse(tempstr[0]);
            int claimnum = int.Parse(tempstr[1]);
            Hart_WineCharmMeadowLime.Add(new MiniBonusRewardInfo(Here.id, Here.cash, (Here.Ad == 1), (locknum == 1), (claimnum == 1)));
        }
        GatherCharmMeadowWeird();
        RewriteNeuronNiche.LawFigurine().Seat("MiniGameBounusItemUpdate", null);
    }

    /// <summary>
    /// ����ս����ȡ����Ϣ  0δ��ȡ��1��ȡ
    /// </summary>
    public void MadWineFistStarveMeadow(int index)
    {
        for (int i = 0; i < Hart_WineCharmMeadowLime.Count; i++)
        {
            if (i == index)
            {
                if (i + 1 < Hart_WineCharmMeadowLime.Count)
                {
                    Hart_WineCharmMeadowLime[i + 1].IsLock = true;
                }
                Hart_WineCharmMeadowLime[i].IsLock = true;
                Hart_WineCharmMeadowLime[i].IsClaim = true;
            }
        }
        GatherCharmMeadowWeird();
        RewriteNeuronNiche.LawFigurine().Seat("MiniGameBounusItemUpdate", null);
    }

    /// <summary>
    /// �������ݻ���
    /// </summary>
    public void GatherCharmMeadowWeird()
    {
        string[] strArray = new string[Hart_WineCharmMeadowLime.Count];
        for (int i = 0; i < Hart_WineCharmMeadowLime.Count; i++)
        {
            string lockstr = Hart_WineCharmMeadowLime[i].IsLock ? "1" : "0";
            string claimstr = Hart_WineCharmMeadowLime[i].IsClaim ? "1" : "0";
            strArray[i] = lockstr + "," + claimstr;
        }
        GripCopyVaguely.MadExcessGrope("BonusItemInfo", strArray);
    }

    // ��ȡ��ǰʱ������Ժ���Ϊ��λ��
    public void MadPredateWaterside()
    {
        DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        TimeSpan timeSpan = DateTime.UtcNow - epochStart;
        GripCopyVaguely.MadExcess("MiniGameBonusTime", timeSpan.TotalSeconds.ToString());
    }

    public void TrailCharmTheyTreatGram()
    {
        // ����֮ǰ��ʱ������뼶�����磺1696147200 = 2023-10-01 00:00:00 UTC��
        LeoWineCharmThey = 3 * 24 * 60 * 60;
        string Luck= GripCopyVaguely.LawExcess("MiniGameBonusTime");
        if (long.TryParse(Luck, out long previousTimestamp))
        {
            // ��ȡ��ǰʱ������뼶��
            long currentTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            // ����ʱ���룩
            long differenceInSeconds = currentTimestamp - previousTimestamp;

            // ת��Ϊ������86400�� = 1�죩
            double differenceInDays = differenceInSeconds / 86400.0;

            // �ж��Ƿ񳬹�3��
            if (differenceInDays >= 3)
            {
                WineFistCharmShirtCopyWool();
                MadPredateWaterside();
            }
            else
            {
                LeoWineCharmThey = (3 * 24 * 60 * 60) - differenceInSeconds;
            }
        }
        StartCoroutine(nameof(TillWineCharmThey));
    }

    IEnumerator TillWineCharmThey()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            LeoWineCharmThey--;
            // ��ʱ���ת��Ϊ DateTime ����
            DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime dateTime = epochStart.AddSeconds(LeoWineCharmThey);
            RewriteNeuronNiche.LawFigurine().Seat("LuckyBonusTime", new RewriteCopy(dateTime.ToString("HH:mm:ss")));
            //Debug.Log("��ʽ�����ʱ��: " + dateTime.ToString("HH:mm:ss"));
            if (LeoWineCharmThey == 0)
            {
                WineFistCharmShirtCopyWool();
                MadPredateWaterside();
                LeoWineCharmThey = 3 * 24 * 60 * 60;
            }
        }
    }

    //----------------- ת��С��Ϸ -----------------//
    public List<MiniWheelRewardData> LawWineFistRadarCopy()
    {
        return WineCopy.data.LuckyWheelData;
    }
    //���ת�̽���
    public int LawWineFistRadarMagic()
    {
        int wights = 0;
        var Here= WineCopy.data.LuckyWheelData;
        for (int i = 0; i < Here.Count; i++)
        {
            wights += Here[i].weights;
        }
        int random = Random.Range(0, Here.Count);
        for (int i = 0; i < Here.Count; i++)
        {
            if (random == Here[i].id)
            {
                return i;
            }
        }
        return 0;
    }

    public void TillWineFistRadarMeadowCoach(int index)
    {
        var Here= WineCopy.data.LuckyWheelData[index];
        var wilddata = FortCopyVaguely.instance.LawGateFoldMeadow();
        switch (Here.type)
        {
            case "cash":
                WineFistRotHome(Here.number);
                //FortFistCoach.Instance.OpenFreeSpin();
                FortFistCoach.Instance.TrailHerdShrine();
                break;
            case "mini":
                UIInject.LawFigurine().FairUIMarry(nameof(FortFoldMeadowCoach));
                SeatFoldFistCoach((int)WildRewardType.Mini, wilddata[0],"wheel");
                break;
            case "major":
                UIInject.LawFigurine().FairUIMarry(nameof(FortFoldMeadowCoach));
                SeatFoldFistCoach((int)WildRewardType.Major, wilddata[1], "wheel");
                break;
            case "grand":
                UIInject.LawFigurine().FairUIMarry(nameof(FortFoldMeadowCoach));
                SeatFoldFistCoach((int)WildRewardType.Grand, wilddata[2], "wheel");
                break;
            default:
                break;
        }
    }

    public void SeatFoldFistCoach(int type,float num,string mini)
    {
        RewriteCopy Here= new RewriteCopy();
        Here.FiordAid = type;
        Here.FiordAlarm = num;
        Here.FiordExcess = mini;
        RewriteNeuronNiche.LawFigurine().Seat("MiniGameWildGamePanelUpdate", Here);
    }

    //----------------- �ղ�Ʒ -----------------//

    public List<MiniBonusCardInfo> LawFortHaleCopy()
    {
        return Hart_WineSimulationHaleLime;
    }

    /// <summary>
    /// �ղ�Ʒ����
    /// </summary>
    public void FortHaleMeadowWeirdWool()
    {
        WineFistHaleShirtWeird = GripCopyVaguely.LawExcessGrope("SlotCardCache");
        Hart_WineSimulationHaleLime = new List<MiniBonusCardInfo>();
        var Here= WineCopy.data.LuckyCardsData;
        for (int i = 0; i < Here.Count; i++)
        {
            Hart_WineSimulationHaleLime.Add(new MiniBonusCardInfo(Here[i].id, Here[i].cash * FortCopyVaguely.instance.LawEnsueHomeOral(), false, false));
        }

        if (WineFistHaleShirtWeird.Length != 0)
        {
            for (int i = 0; i < WineFistHaleShirtWeird.Length; i++)
            {
                string[] tempstr = WineFistHaleShirtWeird[i].Split(',');
                int idnum = int.Parse(tempstr[0]);
                int havenum = int.Parse(tempstr[1]);
                for (int j = 0; j < Hart_WineSimulationHaleLime.Count; j++)
                {
                    if (idnum == Hart_WineSimulationHaleLime[j].Id)
                    {
                        Hart_WineSimulationHaleLime[i].IsLock = true;
                        Hart_WineSimulationHaleLime[i].IsHaveReward = (havenum == 1);
                    }
                }
            }
        }
    }

    /// <summary>
    /// �޸��ղ�Ʒ����
    /// </summary>
    /// <param name="index"></param>
    /// <param name="ishave"></param>
    public void GatherFortHaleMeadowWeird(int index,bool ishave)
    {
        for (int j = 0; j < Hart_WineSimulationHaleLime.Count; j++)
        {
            if (index == Hart_WineSimulationHaleLime[j].Id)
            {
                Hart_WineSimulationHaleLime[j].IsLock = true;
                Hart_WineSimulationHaleLime[j].IsHaveReward = ishave;
            }
        }
        GripFortHaleMeadowWeird();
    }

    /// <summary>
    /// �洢
    /// </summary>
    public void GripFortHaleMeadowWeird()
    {
        List<string> list = new List<string>();
        for (int i = 0; i < Hart_WineSimulationHaleLime.Count; i++)
        {
            string islock = Hart_WineSimulationHaleLime[i].IsLock ? Hart_WineSimulationHaleLime[i].Id.ToString() : "-1";
            string isreward = Hart_WineSimulationHaleLime[i].IsHaveReward ? "1" : "0";
            list.Add(islock+","+isreward);
        }
        string[] strArray= list.ToArray();
        GripCopyVaguely.MadExcessGrope("SlotCardCache",strArray);
    }

    //��ȡ����Ľ���Ʒ
    public MiniBonusRewardData LawVenomHaleMagic()
    {
        var Here= WineCopy.data.LuckyCardsData;
        int random = Random.Range(0, Here.Count );
        for (int i = 0; i < Here.Count; i++)
        {
            if (random == Here[i].id)
            {
                return Here[i];
            }
        }
        return Here[0];
    }

    //----------------- freeSpin С��Ϸ-----------------//
    public List<int> LawFortWineFistCopy()
    {
        Hart_WineFistThusCopy.Clear();
        int wights = 0;
        var Here= WineCopy.data.LuckyMiniGameData;
        for (int i = 0; i < Here.Count; i++)
        {
            wights += Here[i].weights;
        }

        for (int i = 0; i < 6; i++)
        {
            int id = LawWineFistThus(wights);
            Hart_WineFistThusCopy.Add(id);
        }
        //�����������Ϸid
        LeoWineFistID = BuckleWineFistThusID();
        //����С��Ϸ��index
        LeoWineFistMagic = -1;
        for (int i = 0; i < Hart_WineFistThusCopy.Count; i++)
        {
            if (LeoWineFistID == Hart_WineFistThusCopy[i])
            {
                LeoWineFistMagic = i;
                break;
            }
        }
        if (LeoWineFistMagic == -1 || LeoWineFistMagic == 0)
        {
            Hart_WineFistThusCopy[4] = LeoWineFistID;
            LeoWineFistMagic = 4;
        }
        //����ɸ�ӵ�index
        for (int i = 0; i < Hart_WineFistRadarSpurWhale.Count; i++)
        {
            if (Hart_WineFistRadarSpurWhale[i] == LeoWineFistMagic)
            {
                LeoWineFistRadarMagic = i;
                break;
            }
        }
        return Hart_WineFistThusCopy;
    }
    //��ȡÿ��С��Ϸ��type
    private int LawWineFistThus(int wights)
    {
        int random = Random.Range(0, wights + 1);
        int weightAll = 0;
        var Here= WineCopy.data.LuckyMiniGameData;
        for (int i = 0; i < Here.Count; i++)
        {
            weightAll += Here[i].weights;
            if (random < weightAll)
            {
                return Here[i].id;
            }
        }
        return 0;
    }
    //ѡ��С��ϷID
    public int BuckleWineFistThusID()
    {
        var Here= WineCopy.data.ChooseLuckyMiniGameData;
        int wights = 0;
        int weightAll = 0;
        for (int i = 0; i < Here.Count; i++)
        {
            wights += Here[i].weights;
        }
        int random = Random.Range(0, wights + 1);
        for (int i = 0; i < Here.Count; i++)
        {
            weightAll += Here[i].weights;
            if (random < weightAll)
            {
                return Here[i].id;
            }
        }
        return 0;
    }

    //���С��Ϸ�е�cash��Ϸ����
    public void LawWineFistHome()
    {
        double Get= WineCopy.data.LuckyMiniGameCashData.min;
        double Son= WineCopy.data.LuckyMiniGameCashData.max;
        double Dual=  Random.Range((float)Get,(float)Son);
        WineFistRotHome(Dual);
        //FortFistCoach.Instance.OpenFreeSpin();
        FortFistCoach.Instance.TrailHerdShrine();
    }

    public void WineFistRotHome(double cash)
    {
        PageBisonEmbryo.LawFigurine().SeatBison("1012");
        FortCopyVaguely.instance.GatherLeoHerdMeadow((float)cash);
        SitCoachTine.instance.HomeRotEpidermis(null, cash);
    }

    

    /// <summary>
    /// ��С��Ϸ����
    /// </summary>
    public void TillWineFistCoach()
    {
        switch (LeoWineFistID)
        {
            case 0:
                //slots
                UIInject.LawFigurine().FairUIMarry(nameof(FortVenomFortCoach));
                break;
            case 1:
                //luxury
                UIInject.LawFigurine().FairUIMarry(nameof(FortVenomHaleMeadowCoach));
                break;
            case 2:
                //wheel
                UIInject.LawFigurine().FairUIMarry(nameof(OrphanageRadarCoach));
                break;
            case 3:
                //cash
                LawWineFistHome();
                break;
            default:
                break;
        }
    }

    //----------------- ���� -----------------//
  
    public void LawVineHutHome()
    {
        LeoBodeHutHome = GripCopyVaguely.LawSummer("GlodPigCash");
        if (LeoBodeHutHome == 0)
        {
            int maxBank = WineCopy.data.LuckyBankData.Count;
            int random = Random.Range(0, maxBank);
            LeoBodeHutHome = WineCopy.data.LuckyBankData[random].cash;
            GripCopyVaguely.MadSummer("GlodPigCash", LeoBodeHutHome);
        }
        LeoBodeHutHome = LeoBodeHutHome * FortCopyVaguely.instance.LawEnsueHomeOral();
        
    }

    public void TillBodeHut()
    {
        if (!MyTillVineHut && FortCopyVaguely.instance.LeoHerdLittle % 20 == 0)
        {
            TrailVineHutThey();
        }
    }

    public void TrailVineHutThey()
    {
        LawVineHutHome();
        // ����֮ǰ��ʱ������뼶�����磺1696147200 = 2023-10-01 00:00:00 UTC��
        //CurGlodPigTime = 24 * 60 * 60;
        string Luck= GripCopyVaguely.LawExcess("GlodPigTime");
        // ��ȡ��ǰʱ������뼶��
        long currentTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        if ( !string.IsNullOrEmpty(Luck)&&Luck !="0" && long.TryParse(Luck, out long previousTimestamp))
        {
            LeoBodeHutThey = previousTimestamp;
            // ����ʱ���룩
            long differenceInSeconds = currentTimestamp - previousTimestamp;

            // ת��Ϊ������86400�� = 1�죩
            double differenceInDays = differenceInSeconds / 86400.0;
            // �ж��Ƿ񳬹�1��
            if (differenceInDays > 1)
            {
                MyTillVineHut = false;
                LeoBodeHutThey = 0;
                GripCopyVaguely.MadExcess("GlodPigTime", "0");
            }
            else
            {
                LeoBodeHutThey = (24 * 60 * 60) - differenceInSeconds;
                MyTillVineHut = true;
            }
        }
        else
        {
            LeoBodeHutThey = 24 * 60 * 60;
            MyTillVineHut = true;
            GripCopyVaguely.MadExcess("GlodPigTime", currentTimestamp.ToString());
        }
        GripCopyVaguely.MadLeft("OpenGoldPig", MyTillVineHut);
        if (LeoBodeHutThey >= 0 && MyTillVineHut)
        {
            StartCoroutine(nameof(TillVineHutAuthorityThey));
        }
        
    }

    IEnumerator TillVineHutAuthorityThey()
    {
        while (true)
        {
            LeoBodeHutThey--;
            // ��ʱ���ת��Ϊ DateTime ����
            DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime dateTime = epochStart.AddSeconds(LeoBodeHutThey);
            //Debug.Log("��ʽ�����ʱ��: " + dateTime.ToString("HH:mm:ss"));
            if (LeoWineCharmThey == 0)
            {
                MyTillVineHut = false;
                LeoBodeHutThey = 0;
                GripCopyVaguely.MadLeft("OpenGoldPig", MyTillVineHut);
            }
            RewriteNeuronNiche.LawFigurine().Seat("GlodPigTime", new RewriteCopy(dateTime.ToString("HH:mm:ss")));
            yield return new WaitForSeconds(1);
        }
    }

    public void LawVineHutMeadow()
    {
        MyTillVineHut = false;
        LeoBodeHutThey = 0;
        GripCopyVaguely.MadExcess("GlodPigTime", LeoBodeHutThey.ToString());
        GripCopyVaguely.MadLeft("OpenGoldPig", MyTillVineHut);
    }
}

public class MiniGameInfo
{
    public MiniGameData data;
}

public class MiniGameData
{
    public List<MiniChipsRewardData> LuckyChipsData;
    public List<MiniChipsRewardData> LuckyBankData;
    public List<MiniWheelRewardData> LuckyWheelData;
    public List<MiniBonusRewardData> LuckyBonusData;
    public List<MiniBonusRewardData> LuckyCardsData;
    public List<MiniWheelRewardData> LuckyMiniGameData;
    public LuckyMiniGameCashRangeData LuckyMiniGameCashData;
    public LuckyMiniGameCashRangeData LuckyMiniGoldPigData;
    public List<MiniWheelRewardData> ChooseLuckyMiniGameData;
}

public class MiniChipsRewardData
{
    public int id;
    public double cash;
}

public class MiniWheelRewardData
{
    public int id;
    public string type;
    public double number;
    public int weights;
}

public class MiniBonusRewardData
{
    public int id;
    public double cash;
    public int Ad;
}

public class LuckyMiniGameCashRangeData
{
    public double min;
    public double max;
}

public class MiniBonusRewardInfo
{
    public int Id;
    public double Cash;
    public bool IsAd;
    public bool IsLock;
    public bool IsClaim;

    public MiniBonusRewardInfo(int id, double cash, bool isAd, bool isLook,bool isClaim)
    {
        Id = id;
        Cash = cash;
        IsAd = isAd;
        IsLock = isLook;
        IsClaim = isClaim;
    }
}

public class MiniBonusCardInfo
{
    public int Id;
    public double Cash;
    public bool IsLock;
    public bool IsHaveReward;

    public MiniBonusCardInfo(int id, double cash, bool isLock, bool isHaveReward)
    {
        Id = id;
        Cash = cash;
        IsLock = isLock;
        IsHaveReward = isHaveReward;
    }
}

