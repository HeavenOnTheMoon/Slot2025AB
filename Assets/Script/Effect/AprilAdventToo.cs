using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;
using UnityEngine;
using Random = UnityEngine.Random;

public class AprilAdventToo : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("StarObj")]    public GameObject TineBis;
[UnityEngine.Serialization.FormerlySerializedAs("FlyStarObjs")]    public List<GameObject> LadTineMoat;
[UnityEngine.Serialization.FormerlySerializedAs("StarFireworkObjs")]    public List<GameObject> TineParticleMoat;
    public string type;

    /// <summary>
    /// 初始化特效
    /// </summary>
    /// <param name="str">出现星星类型  wand 0 ring 1  bottle 2</param>
    /// <param name="endPos">最总位移位置</param>
    public void Wool(int index, Transform endPos)
    {
        
        StartCoroutine(DecayHat(index, endPos));
    }

    IEnumerator DecayHat(int index, Transform endpos)
    {
        TineBis.gameObject.SetActive(true);
        var Ani = DOTween.Sequence();
        yield return new WaitForSeconds(0.2f);
        //星星出现
        for (int i = 0; i < LadTineMoat.Count; i++)
        {
            LadTineMoat[i].gameObject.SetActive(index == i);
        }
        TineBis.gameObject.SetActive(false);
        var startpos = transform.position;
        
        Vector3 pos = Vector3.Lerp(startpos, endpos.position,10.0f) + (Random.Range(0,2) == 0 ? Vector3.left : Vector3.right) * 2;
        Vector3[] posArr = new Vector3[] {startpos,pos,endpos.position };
        DOTween.To((t) => 
        {
            transform.position = DepartGreat(posArr, t);
        },0,1,0.5f).OnComplete((() =>
        {
            for (int i = 0; i < TineParticleMoat.Count; i++)
            {
                TineParticleMoat[i].gameObject.SetActive(index == i);
                LadTineMoat[i].gameObject.SetActive(false); 
                if(i == TineParticleMoat.Count - 1)
                    RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_BoyAdventEpidermis, new RewriteCopy(index));
            }
        }));
    }
    
    public Vector3 DepartGreat(Vector3[] pos, float t)
    {
        Vector3[] arr = new Vector3[pos.Length - 1];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = pos[i] * (1 - t) + pos[i + 1] * t;
            //Debug.DrawLine(pos[i], pos[i + 1], Color.red);
        }
        if (arr.Length == 1)
        {
            return arr[0];
        }
        else
        {
            return DepartGreat(arr, t);
        }
    }


}
