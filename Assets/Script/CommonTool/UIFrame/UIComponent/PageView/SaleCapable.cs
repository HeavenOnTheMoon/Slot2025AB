using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaleCapable : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Pine;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public BootStar Meaningful;
    private void Awake()
    {
        Meaningful.OnBootGather = Legitimate;
    }

    void Legitimate(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Pine.GetComponent<RectTransform>().position = pos;
    }
}
