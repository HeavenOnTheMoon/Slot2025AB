using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AprilArchSliceEpidermis_r1 : MonoBehaviour
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
        StartCoroutine(nameof(HookGreedy));
    }
    private void OnEnable()
    {
        Cruel = GetComponent<Image>();
        StartCoroutine(nameof(HookGreedy));
    }
    private void OnDisable()
    {
        StopCoroutine(nameof(HookGreedy));
    }
}
