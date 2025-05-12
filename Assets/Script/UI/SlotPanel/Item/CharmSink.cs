using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BonusText")]    public Text CharmMine;
    void Start()
    {
        
    }

    public void MadCharmMine(int num = 0)
    {
        CharmMine.gameObject.SetActive(true);
        CharmMine.text = num.ToString();
    }

    public void ComicCharmMine()
    {
        CharmMine.gameObject.SetActive(false);
    }
}
