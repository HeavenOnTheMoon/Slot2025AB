using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AprilFortLazilyCopy
{
    public SlotData  data { get; set; }
}

public class SlotData
{
    /// <summary>
    /// ÿ������ͼƬ���ֵ�Ȩ��
    /// </summary>
    public List<SevenSlot> SevenSlot;
    /// <summary>
    /// ���ߵĽ���
    /// </summary>
    public List<WinLineData> winLine;
    public List<SpecialSpin> specialSpin;
    public List<SpecialSpin> dailyspecialSpin;
    /// <summary>
    /// ������ÿ��ͼ����ֵ�����
    /// </summary>
    public List<SevenSlotSpecialLimit> sevenSlotSpecialLimit;
    /// <summary>
    /// free����ͼ����ת�Ĵ���
    /// </summary>
    public List<FreeSpinReward> freeSpinReward;
    public List<StarReward> starReward;
    public List<string> sLotTwoLine;
    public int jackpotCount;

    public List<SlotPieceData> wildWeights;
}

public class SevenSlot
{
    public List<SlotPieceData> slotPiece;
}

public class SlotPieceData
{
    public int id;
    public string type; 
    public string typecount;
    public int weights;
}

public class WinLineData
{
    public string winType;
    public int lines;
    public int goldcount;
}

public class SpecialSpin
{
    public int spinCount;
    public string specialType;
    public int specialTypeCount;
    public int specialScroll;
}

public class SevenSlotSpecialLimit
{
    public string type;
    public int num;
}

public class FreeSpinReward
{
    public int count;
    public int type;
    public int value;
}

public class StarReward
{
    public int starIconCount;
    public int baseVlue;
    public int onceAddValue;
}

public class FreeSpinWeight
{
    public int cashWeight;
    public int wildWeight;
}

public class DailySpinCompensation
{
    public int compensation_value;
    public int compensation_count;
}
