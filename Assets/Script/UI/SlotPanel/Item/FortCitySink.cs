using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortCitySink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Index")]    public int Magic;
[UnityEngine.Serialization.FormerlySerializedAs("LineImage")]
    public Image CitySlice;
    public void MadCitySinkLime(int index)
    {
        Magic = index;
        CitySlice.sprite = FortCityVaguely.LawFigurine().LawFortCityDuring(Magic);
        CitySlice.SetNativeSize();
        CitySlice.transform.localPosition = Vector3.zero;
        CitySlice.transform.localScale = Vector3.one;
    }
}
