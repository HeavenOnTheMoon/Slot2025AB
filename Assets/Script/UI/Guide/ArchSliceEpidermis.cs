using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArchSliceEpidermis : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("imageList")]    public List<Sprite> CruelHart;
    private Image Cruel;
[UnityEngine.Serialization.FormerlySerializedAs("speen")]    public float Eject;
    IEnumerator HookGreedy()
    {
        foreach(Sprite sprite in CruelHart)
        {
            Cruel.sprite = sprite;
            yield return new WaitForSeconds(Eject);
        }
        StartCoroutine("HookGreedy");
    }
    private void OnEnable()
    {
        Cruel = GetComponent<Image>();
        StartCoroutine("HookGreedy");
    }
    private void OnDisable()
    {
        StopCoroutine("HookGreedy");
    }
}
