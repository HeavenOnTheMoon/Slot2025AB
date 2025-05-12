using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GildMeadowSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text MeadowMine;
[UnityEngine.Serialization.FormerlySerializedAs("List_Reward")]    public List<GameObject> Hart_Meadow;
    void Start()
    {
        
    }


    public void GildMeadowSinkWool(float reward)
    {
        string str = RetoolJean.MyEnsue() ? "" : "$";
        MeadowMine.text =str+ reward.ToString("f2");
        for (int i = 0; i < Hart_Meadow.Count; i++)
        {
            Hart_Meadow[i].gameObject.SetActive(false);
        }
    }

    public void MadMeadowSinkFly(int index)
    {
        for (int i = 0; i < Hart_Meadow.Count; i++)
        {
            Hart_Meadow[i].gameObject.SetActive(i < index);
        }
    }
}
