using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortSphericalSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("symbols")]
    public Transform[] Somehow; // �洢������Ԫ��
[UnityEngine.Serialization.FormerlySerializedAs("symbolHeight")]    public float symbolCobalt= 200f; // ÿ��Ԫ�صĸ߶�
    private float CenterBluebird= 0.05f; // ����һ�εĳ���ʱ��
[UnityEngine.Serialization.FormerlySerializedAs("scrollCount")]    //���index��0�����ǵ㲻���м䣬��Ҫ���ϵ�Ų�����м�λ�õĴ���
    //��Ҫʲô��һ�£�ÿ11��һ�֣�1��ʼ�ǵ�
    public int CenterWhale= 27; // ��������
[UnityEngine.Serialization.FormerlySerializedAs("playIndex")]
    public int HookMagic;

    private List<Vector3> Hart_SinkSee;
    private void Awake()
    {
        Hart_SinkSee = new List<Vector3>();
        for (int i = 0; i < Somehow.Length; i++)
        {
            var pos = Somehow[i].transform.localPosition;
            Hart_SinkSee.Add(new Vector3(pos.x, pos.y, pos.z));
        }
    }

    void Start()
    {
        //SetScorllNumber(1,1);List_ItemPos = new List<Vector3>();
        
    }

    public void HectareSinkWool()
    {
        for (int i = 0; i < Somehow.Length; i++)
        {
            Somehow[i].transform.localPosition = Hart_SinkSee[i];
        }
    }


    public void MadSuddenLittle(int index,int scroll = 1, int factor = 1)
    {
        HookMagic = index;
        CenterWhale = 5+11*factor + scroll;
        
        DecaySierra();
    }

    public void DecaySierra()
    {
        Sequence sequence = DOTween.Sequence();
        for (int i = 0; i < Somehow.Length; i++)
        {
            int nextIndex = (i + 1) >= Somehow.Length ? 0 : (i + 1);
            float targetY = Somehow[nextIndex].localPosition.y;
            sequence.Join(Somehow[i].DOLocalMoveY(targetY, CenterBluebird).SetEase(Ease.Linear));
        }
        sequence.OnComplete(()=> {
            CenterWhale--;
            DecaySierra();
        });

        if (CenterWhale == 0)
        {
            sequence.OnComplete(() =>
            {
                // ������ɺ�Ĵ���
                Debug.Log("�������");
                FortWineCopyVaguely.LawFigurine().GatherWineFistFortArchLinkBoy(HookMagic, true);
            });
        }
    }


}

