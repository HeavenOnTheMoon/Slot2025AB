using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AprilCityLazilyCopy
{
    public List<LineData> lineData { get; set;}
}

public class LineData
{
    public int id;
    public string nodeOne;
    public string nodeTwo;
    public string nodeThree;
    public string nodeFour;
    public string nodeFive;
}

public class DotweenInfo
{
    public List<DotweenData> dotweenInfo { get; set;}
}

public class DotweenData
{
    public int id;
    public int isMask;
    public string maskA;
    public List<string> group_id;
}
