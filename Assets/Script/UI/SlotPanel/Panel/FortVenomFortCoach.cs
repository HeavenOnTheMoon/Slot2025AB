using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortVenomFortCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("List_SlotLuckyslotItem")]    public List<FortSphericalSink> Hart_FortSphericalSink;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Claim")]
    public Button Modify_Shirt;
[UnityEngine.Serialization.FormerlySerializedAs("Button_TenClaim")]    public Button Modify_DNAShirt;

    private float _Dual;
    protected override void Awake()
    {
        base.Awake();
        RewriteNeuronNiche.LawFigurine().Alphabet("MiniGameSlotsFinish", OnMiniGameSlotsFinish);

        Modify_Shirt.onClick.AddListener(()=> {
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    LawMeadow(true);
                }
                
            }, "5");
            
        });

        Modify_DNAShirt.onClick.AddListener(() => {
            ADVaguely.Figurine.WeVacuumRotWhale();
            LawMeadow(false);
        });
    }

   
    public override void Display()
    {
        base.Display();
        StartCoroutine(nameof(ArchLatin));
        Modify_Shirt.gameObject.SetActive(false);
        Modify_DNAShirt.gameObject.SetActive(false);
    }

    private void LawMeadow(bool isad)
    {
        double Dual= isad ? _Dual * 2 : _Dual;
        FortWineCopyVaguely.LawFigurine().WineFistRotHome(Dual);
        string adid = isad ? "1" : "0";
        PageBisonEmbryo.LawFigurine().SeatBison("1010", adid, Dual.ToString());
        ComicUIPram(nameof(FortVenomFortCoach));
        //FortFistCoach.Instance.OpenFreeSpin();
        FortFistCoach.Instance.TrailHerdShrine();
    }

    private void OnMiniGameSlotsFinish(RewriteCopy obj)
    {
        Modify_Shirt.gameObject.SetActive(true);
        //Button_TenClaim.gameObject.SetActive(true);
        StartCoroutine(nameof(HabitFairWeADModify));
    }

    IEnumerator ArchLatin()
    {
        yield return new WaitForSeconds(0.5f);
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_SlotsRolling);
        for (int i = 0; i < Hart_FortSphericalSink.Count; i++)
        {
            Hart_FortSphericalSink[i].HectareSinkWool();
        }
        //NumberItemInit();
        float random = FortWineCopyVaguely.LawFigurine().LawWineFistFortMeadow();
        _Dual = random;
        // ������λС��
        string formattedNumber = random.ToString("F2");
        // ��ֳ� char ����
        char[] charArray = formattedNumber.ToCharArray();
        int index = 0;
        // ������
        foreach (char c in charArray)
        {
            if (index == 1)
            {
                Hart_FortSphericalSink[index].MadSuddenLittle(index, 1, (1 + index));
            }
            else
            {
                int Effect= c - '0';
                Hart_FortSphericalSink[index].MadSuddenLittle(index, Effect + 2, (1 + index));
            }
            index++;
        }
    }

    IEnumerator HabitFairWeADModify()
    {
        Modify_DNAShirt.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        Modify_DNAShirt.gameObject.SetActive(true);
    }
}
