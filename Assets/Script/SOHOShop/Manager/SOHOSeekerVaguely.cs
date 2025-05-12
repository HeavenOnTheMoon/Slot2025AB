using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHOSeekerVaguely : MonoBehaviour
{
    public static SOHOSeekerVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("puzzleShopGroup")]
    public Seeker[] TropicLoamSpout;    // 碎片

    public Dictionary<string, double> puzzle_multi_group;
[UnityEngine.Serialization.FormerlySerializedAs("CurrentPuzzleReward")]
    public Seeker PredateSeekerMeadow;
    private void Awake()
    {
        instance = this;
    }

    public void HaleSeeker()
    {
        string[] puzzles = GripCopyVaguely.LawExcessGrope(SOHOLoamGuard.Dy_Seeker);
        if (puzzles.Length == 0)
        {
            TropicLoamSpout = SOHOLoamCopyVaguely.instance.DrabJson.puzzle_shop_group;
        }
        else
        {
            TropicLoamSpout = new Seeker[puzzles.Length];
            for (int i = 0; i < puzzles.Length; i++)
            {
                TropicLoamSpout[i] = JsonMapper.ToObject<Seeker>(puzzles[i]);
            }
        }

        string[] keys = new string[SOHOLoamCopyVaguely.instance.DrabJson.puzzle_multi_group.Count];
        SOHOLoamCopyVaguely.instance.DrabJson.puzzle_multi_group.Keys.CopyTo(keys, 0);
        List<string> keyList = new List<string>(keys);
        keyList.Sort((a, b) => {
            float diff = float.Parse(a) - float.Parse(b);
            if (diff == 0)
            {
                return 0;
            }
            else if (diff > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        });
        puzzle_multi_group = new Dictionary<string, double>();
        foreach (string key in keyList)
        {
            puzzle_multi_group.Add(key, SOHOLoamCopyVaguely.instance.DrabJson.puzzle_multi_group[key]);
        }
    }

    /// <summary>
    /// 获取比例未达到99%的碎片
    /// </summary>
    /// <returns></returns>
    public Seeker JobMissionarySeeker()
    {
        List<Seeker> unachievedPuzzles = new List<Seeker>();
        if (TropicLoamSpout == null)
        {
            HaleSeeker();
        }
        foreach (Seeker item in TropicLoamSpout)
        {
            if (item.claim_count * 100 / item.sum_count < 99)
            {
                unachievedPuzzles.Add(item);
            }
        }
        Seeker result = unachievedPuzzles.Count == 0 ? null : unachievedPuzzles[Random.Range(0, unachievedPuzzles.Count)];
        if (result != null)
        {
            // 获得的碎片数量 = multi * 碎片总数
            result.reward_count = JobSeekerPoint(result) * result.sum_count;
        }
        PredateSeekerMeadow = result;
        return result;
    }

    public double JobSeekerPoint(Seeker puzzle)
    {
        double achievePercent = puzzle.claim_count / puzzle.sum_count;
        foreach (string key in puzzle_multi_group.Keys)
        {
            if (achievePercent <= float.Parse(key))
            {
                return puzzle_multi_group[key];
            }
        }
        return puzzle_multi_group["1"];
    }

    /// <summary>
    /// 增加碎片
    /// </summary>
    /// <param name="puzzle"></param>
    public void LotSeeker(Seeker puzzle)
    {
        if (TropicLoamSpout.Length == 0)
        {
            HaleSeeker();
        }
        foreach (Seeker item in TropicLoamSpout)
        {
            if (item.name == puzzle.name)
            {
                item.claim_count += puzzle.reward_count;
                break;
            }
        }
        SpitSeeker();
    }

    private void SpitSeeker()
    {
        List<string> strings = new List<string>();
        foreach (Seeker item in TropicLoamSpout)
        {
            strings.Add(JsonMapper.ToJson(item));
        }
        GripCopyVaguely.MadExcessGrope(SOHOLoamGuard.Dy_Seeker, strings.ToArray());
    }
}
