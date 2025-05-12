using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FootGildSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("front")]    public GameObject Dough;
[UnityEngine.Serialization.FormerlySerializedAs("back")]    public GameObject Diva;
[UnityEngine.Serialization.FormerlySerializedAs("ItemButton")]    public Button SinkModify;
[UnityEngine.Serialization.FormerlySerializedAs("BackIcon")]    public GameObject ChopWhat;
[UnityEngine.Serialization.FormerlySerializedAs("BackCash")]    public GameObject ChopHome;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text HomeMine;
[UnityEngine.Serialization.FormerlySerializedAs("backImage")]    public Image DivaSlice;
[UnityEngine.Serialization.FormerlySerializedAs("flipDuration")]    public float LoomBluebird= 0.5f; // ����ʱ��
[UnityEngine.Serialization.FormerlySerializedAs("isFlipped")]    public bool BeNitinol= false;   // ��ǰ״̬
[UnityEngine.Serialization.FormerlySerializedAs("ChipItemType")]
    public LuckyChipType FootSinkThus;
    private double _DogMeadow;
    void Start()
    {
        // �󶨰�ť����¼�
        SinkModify.onClick.AddListener(SpewHale);
        //back.SetActive(false); // ��ʼ���ر���
        GildWool();
    }

    public void GildSinkWool(LuckyChipType type,float rewardNum)
    {
        GildWool();
        FootSinkThus = type;
        _DogMeadow = rewardNum;
        ChopWhat.gameObject.SetActive(type != LuckyChipType.Cash);
        ChopHome.gameObject.SetActive(type == LuckyChipType.Cash);
        ChopHome.transform.localRotation = new Quaternion(0, 180, 0, 0);
        ChopHome.GetComponent<Image>().sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        HomeMine.text = _DogMeadow.ToString();
        if (type != LuckyChipType.Cash)
        {
            DivaSlice.sprite = Resources.Load<Sprite>("Art/Tex/FlopGame/CarveMeadow_" + type.ToString());
            DivaSlice.transform.localRotation = new Quaternion(0, 180, 0, 0);
            DivaSlice.SetNativeSize();
        }
    }
    private void GildWool()
    {
        Dough.SetActive(true);
        Diva.SetActive(false);
        BeNitinol = false;
        this.transform.localRotation = new Quaternion(0, 0, 0, 0);
        this.transform.DOKill();
    }

    /// <summary>
    /// ���ر���
    /// </summary>
    public void FundSacChop()
    {
        // ��һ������ Y ����ת�� 90 �ȣ��������棩
        transform.DORotate(new Vector3(0, 270, 0), LoomBluebird / 2)
           .SetEase(Ease.OutQuad).OnComplete(() =>
           {
               Dough.SetActive(true);
               Diva.SetActive(false);
               BeNitinol = false;
               transform.DORotate(new Vector3(0, 360, 0), LoomBluebird / 2)
                .OnComplete(() =>
                {
                    
                });
           });
    }

    
    public void SpewHale()
    {
        if (DOTween.IsTweening(transform)) return; // ��ֹ�ظ����
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Scratch_Click);
        // ��һ������ Y ����ת�� 90 �ȣ��������棩
        transform.DORotate(new Vector3(0, 90, 0), LoomBluebird / 2)
           .SetEase(Ease.OutQuad).OnComplete(() =>
           {
               GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Scratch_End);
               FundSacLearn();
               
           });
    }

    /// <summary>
    /// ��������
    /// </summary>
    public void FundSacLearn()
    {
        Dough.SetActive(false);
        Diva.SetActive(true);
        BeNitinol = true;
        // �ڶ�����������ת�� 180 �ȣ���ʾ���棩
        transform.DORotate(new Vector3(0, 180, 0), LoomBluebird / 2)
            .OnComplete(() => {
                GildFistVaguely.LawFigurine().SeatGildFistSinkThus(FootSinkThus);
                if (FootSinkThus == LuckyChipType.Cash)
                {
                    SitCoachTine.instance.HomeRotEpidermis(null, _DogMeadow);
                }
            });
    }


    IEnumerator HabitFundSacChop()
    {
        yield return new WaitForSeconds(1f);
        FundSacChop();
    }

}
