using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalveSale : MonoBehaviour
{
    public static CalveSale instance;
[UnityEngine.Serialization.FormerlySerializedAs("RectMask")]
    public GameObject BoldSale;       // ��͸������
[UnityEngine.Serialization.FormerlySerializedAs("LucentMask")]    public GameObject LivingSale;   // ͸�����ֲ�
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]    public GameObject Lung;

    private void Awake()
    {
        instance = this;
    }

    public void MadLungCombat(bool isActive)
    {
        Lung.SetActive(isActive);
    }

    public void FairLycentSale()
    {
        BoldSale.SetActive(false);
        LivingSale.SetActive(true);
    }

    public void FairCalve(GameObject _target, string text)
    {
        LivingSale.SetActive(false);
        BoldSale.SetActive(true);
        BoldCalveSale.instance.FairCalve(_target, text);
    }

    public void FundCalve()
    {
        LivingSale.SetActive(false);
        BoldSale.SetActive(false);
    }

    public void FundActiveSale()
    {
        LivingSale.SetActive(false);
    }
}
