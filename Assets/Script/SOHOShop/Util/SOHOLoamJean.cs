using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHOLoamJean
{
    public static string CoachNeon(string name)
    {
        return RetoolJean.MyFidelity() ? "Portrait" + name : "Landscape" + name;
    }
}
