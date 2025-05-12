using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HerdMeadowSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CashObj")]    public GameObject HomeBis;
[UnityEngine.Serialization.FormerlySerializedAs("FinishObj")]    public GameObject ShrineBis;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text HomeMine;
[UnityEngine.Serialization.FormerlySerializedAs("SpinNumberText")]    public Text HerdLittleMine;

    void Start()
    {
        
    }

    public void MadHerdStiltSinkWool(bool isLock,float cash,int number)
    {
        HomeBis.GetComponent<Image>().sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        HerdLittleMine.text = number.ToString();
        HomeMine.text = cash.ToString();
        HomeBis.SetActive(!isLock);
        ShrineBis.SetActive(isLock);
    }
   
}
