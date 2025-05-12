using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GropeVaguely : EarnCommunity<GropeVaguely>
{
    public string Lime;

    public void FairGrope(string info)
    {
        Lime = info;
        UIInject.LawFigurine().FairUIMarry(nameof(AprilGrope));
    }
}
