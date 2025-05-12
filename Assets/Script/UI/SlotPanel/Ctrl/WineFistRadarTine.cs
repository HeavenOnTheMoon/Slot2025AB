using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WineFistRadarTine : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("WheelObj")]    public GameObject RadarBis;
[UnityEngine.Serialization.FormerlySerializedAs("WheelGameParent")]    public GameObject RadarFistObsess;
[UnityEngine.Serialization.FormerlySerializedAs("MiniGameParent")]    public GameObject WineFistObsess;
[UnityEngine.Serialization.FormerlySerializedAs("SpinPanel")]    public GameObject HerdCoach;
[UnityEngine.Serialization.FormerlySerializedAs("LeftPanel")]    public GameObject BoomCoach;
[UnityEngine.Serialization.FormerlySerializedAs("List_MiniGameItem")]
    public List<GameObject> Hart_WineFistSink;

    [Header("����")]
[UnityEngine.Serialization.FormerlySerializedAs("ChessManObj")]    public GameObject LeaveManBis;
[UnityEngine.Serialization.FormerlySerializedAs("ChessManStartObj")]    public GameObject LeaveTanDecayBis;

    private float MainBluebird= 3.0f;  // ��ת��ʱ��
    private int MainTurnip= 3;        // ������תȦ������ǿ����Ч����
    private Ease MainStay= Ease.OutCubic; // ��ת��������
    private bool _BeThriller; // ����Ƿ�������ת
    private int _BluefinMagic= 0;     // ��ǰĿ��λ������

    private float YeanCobalt= 1f;       // ��Ծ�߶�
    private float YeanBluebird= 0.3f;     // ������Ծʱ��
    private Ease TearStay= Ease.OutQuad; // �ƶ���������

    private Vector3 _originalSpeed;   // ���ӳ�ʼ����
[UnityEngine.Serialization.FormerlySerializedAs("IsOpenMiniGame")]
    public bool MyTillWineFist;

    private int _RockDecaySeeX= 310;
    private int _RockFaint= 125;
    void Start()
    {
        MyTillWineFist = false;
        _originalSpeed = transform.localScale;
        WineFistRadarFund();
    }


    //ʹ��С��Ϸ
    public void PegWineFistRadar()
    {
        if (!MyTillWineFist)
        {
            WineFistRadarFair();
            MyTillWineFist = true;
        }
        WineFistWhatWool();
       
    }

    //�ر�С��Ϸ����
    public void WineFistRadarFund()
    {
        MyTillWineFist = false;
        RadarFistObsess.SetActive(false);
        WineFistObsess.SetActive(false);
        BoomCoach.SetActive(true);
        HerdCoach.SetActive(true);
    }

    //չʾС��Ϸ����
    public void WineFistRadarFair()
    {
        RadarFistObsess.SetActive(true);
        WineFistObsess.SetActive(true);
        BoomCoach.SetActive(false);
        HerdCoach.SetActive(false);
        //MiniGameIconInit();
    }

    #region ˽�з���


    //С��Ϸ��list����
    public void WineFistWhatWool(Action action = null)
    {
        var Here= FortWineCopyVaguely.LawFigurine().LawFortWineFistCopy();
        for (int i = 0; i < Hart_WineFistSink.Count; i++)
        {
            int index = Here[i];
            if (RetoolJean.MyEnsue() && index == 3)
            {
                index = 4;
            }
            Hart_WineFistSink[i].GetComponent<Image>().sprite = WaistVaguely.Instance.FortWineFistDuringGrope[index];
        }
        RadioWineFist();
        WineFistWhatLink();
    }

    public void RadioWineFist()
    {
        LeaveManBis.transform.localPosition = Hart_WineFistSink[0].transform.localPosition;
        RadioRadar();
    }

    /// <summary>
    /// ����С��Ϸ����
    /// </summary>
    public void WineFistWhatLink()
    {
        Sequence miniSq = DOTween.Sequence();
        for (int i = 0; i < Hart_WineFistSink.Count; i++)
        {
            Hart_WineFistSink[i].transform.localPosition = new Vector3(_RockDecaySeeX, Hart_WineFistSink[i].transform.localPosition.y,0);
        }
        for (int i = 0; i < Hart_WineFistSink.Count; i++)
        {
            miniSq.Append(Hart_WineFistSink[i].transform.DOLocalMoveX(_RockDecaySeeX - i * _RockFaint, 0.05f * i));
        }
        miniSq.AppendCallback(()=> {
            
        });
    }

    public void BuckleWineFist()
    {
        int index = FortWineCopyVaguely.LawFigurine().LeoWineFistRadarMagic;
        HerdMyMagic(index);
    }

    /// <summary>
    /// ��ת��ָ������λ��
    /// </summary>
    /// <param name="targetIndex">Ŀ��������0~7��</param>
    private void HerdMyMagic(int targetIndex)
    {
        if (_BeThriller)
        {
            Debug.LogWarning("ת��������ת�У������ظ�����");
            return;
        }

        if (targetIndex < 0 || targetIndex >= 8)
        {
            Debug.LogError($"���� {targetIndex} ������Χ (0-7)");
            return;
        }

        _BeThriller = true;

        // ����Ŀ��Ƕȣ���ʱ�뷽��
        float targetAngle = -45 * targetIndex;

        // ��������ת�Ƕȣ����Ӷ���Ȧ����
        float totalAngle = MainTurnip * 360 + targetAngle;
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Wheel_Rolling);
        // ʹ��DOTween��ת
        RadarBis.transform.DORotate(
                new Vector3(0, 0, totalAngle),
                MainBluebird,
                RotateMode.FastBeyond360
            )
            .SetEase(MainStay)
            .OnComplete(() =>
            {
                
                // ��ȷ�������սǶȣ����⸡����
                RadarBis.transform.eulerAngles = new Vector3(0, 0, targetAngle);
                _BeThriller = false;
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Wheel_Stop);
                Debug.Log($"��ת��ɣ���ǰλ������: {targetIndex}");
                int index = FortWineCopyVaguely.LawFigurine().LeoWineFistMagic;
                StartCoroutine(MadLeaveMagic(index));
                //JumpToIndex(index);
            });
    }


    /// <summary>
    /// ��������λ��
    /// </summary>
    /// <param name="index"></param>
    IEnumerator MadLeaveMagic(int index)
    {
        for (int i = 0; i < Hart_WineFistSink.Count; i++)
        {
            if (i <= index && i != 0)
            {
                MilkMyMagic(i);
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Chess_jump);
                yield return new WaitForSeconds(0.5f);
            }
        }
        yield return new WaitForSeconds(0.5f);
        FortWineCopyVaguely.LawFigurine().TillWineFistCoach();
    }

    /// <summary>
    /// ����ת�̵���ʼλ�ã���ѡ��
    /// </summary>
    private void RadioRadar()
    {
        RadarBis.transform.DOKill(); // ֹͣ���ж���
        RadarBis.transform.eulerAngles = Vector3.zero;
        _BeThriller = false;
    }

    // ֱ����ת��ָ������λ��
    private void MilkMyMagic(int index)
    {
        if (index < 0 || index >= Hart_WineFistSink.Count)
        {
            Debug.LogError("����������Χ��");
            return;
        }
        _BluefinMagic = index;
        MilkMyReadCommerce();
    }


    // ��ת���б��е���һ��λ��
    private void MilkMyReadCommerce()
    {
        if (_BluefinMagic >= Hart_WineFistSink.Count)
        {
            Debug.LogWarning("�ѵ������һ��λ�ã�");
            return;
        }

        Vector3 startPos = LeaveManBis.transform.position;
        Vector3 targetPos = Hart_WineFistSink[_BluefinMagic].transform.position;
        // �����������м��
        Vector3 midPoint = (startPos + targetPos) / 2;
        midPoint.y += YeanCobalt;
        // ������������
        Sequence sequence = DOTween.Sequence();
        
        // 1. ��������Ծ
        sequence.Append(

            LeaveManBis.transform.DOPath(new[] { startPos, midPoint, targetPos }, YeanBluebird, PathType.CatmullRom)
                .SetEase(TearStay)

        );

        /*// 2. ���Ŷ�������Ծʱ���
        sequence.Join(
            ChessManObj.transform.DOScale(_originalScale * 1.2f, jumpDuration / 2)
                .SetLoops(2, LoopType.Yoyo)
        );*/
    }
    #endregion


    

    

    
}
