using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrphanageRadarCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("WheelObj")]    public GameObject RadarBis;
[UnityEngine.Serialization.FormerlySerializedAs("List_WheelItem")]
    public List<GameObject> Hart_RadarSink;
[UnityEngine.Serialization.FormerlySerializedAs("List_BigWinText")]
    public List<Text> Hart_BoxFlyMine;

    [Header("��ת����")]
    [SerializeField] private float MainBluebird= 3.0f;  // ��ת��ʱ��
    [SerializeField] private int MainTurnip= 3;        // ������תȦ������ǿ����Ч����
    [SerializeField] private Ease MainStay= Ease.OutCubic; // ��ת��������

    private bool _BeThriller; // ����Ƿ�������ת

    protected override void Awake()
    {
        base.Awake();
       
    }

    public override void Display()
    {
        base.Display();
        RadioRadar();
        MadRadarCoach();
        int index =FortWineCopyVaguely.LawFigurine().LawWineFistRadarMagic();
        HerdMyMagic(index);
    }

    private void MadRadarCoach()
    {
        var Here= FortWineCopyVaguely.LawFigurine().LawWineFistRadarCopy();
        for (int i = 0; i < Here.Count; i++)
        {
            if (Here[i].number != 1 && Hart_RadarSink[i].transform.childCount > 0)
            {
                Hart_RadarSink[i].GetComponent<Image>().sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
                Text cashText = Hart_RadarSink[i].transform.GetChild(0).GetComponent<Text>();
                cashText.text = Here[i].number.ToString();
            }
        }

        var wilddata = FortCopyVaguely.instance.LawGateFoldMeadow();
        
        for (int i = 0; i < Hart_BoxFlyMine.Count; i++)
        {
            string str = RetoolJean.MyEnsue() ? "" : "$";
            Hart_BoxFlyMine[i].text = str+ wilddata[i].ToString("f2");
        }
    }

    /// <summary>
    /// ��ת��ָ������λ��
    /// </summary>
    /// <param name="targetIndex">Ŀ��������0~7��</param>
    public void HerdMyMagic(int targetIndex)
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
                GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Wheel_Stop);
                // ��ȷ�������սǶȣ����⸡����
                RadarBis.transform.eulerAngles = new Vector3(0, 0, targetAngle);
                _BeThriller = false;
                ComicUIPram(nameof(OrphanageRadarCoach));
                Debug.Log("--------------------------------------      ת��  �� " + targetIndex);
                FortWineCopyVaguely.LawFigurine().TillWineFistRadarMeadowCoach(targetIndex);
                Debug.Log($"��ת��ɣ���ǰλ������: {targetIndex}");

            });
    }

    /// <summary>
    /// ����ת�̵���ʼλ�ã���ѡ��
    /// </summary>
    public void RadioRadar()
    {
        RadarBis.transform.DOKill(); // ֹͣ���ж���
        RadarBis.transform.eulerAngles = Vector3.zero;
        _BeThriller = false;
    }

}
