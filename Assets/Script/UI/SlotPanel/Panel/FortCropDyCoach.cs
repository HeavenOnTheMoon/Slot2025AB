using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortCropDyCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Decay;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Doom1During;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Doom2During;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button star in Decay)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int index = indexStr == "" ? 0 : int.Parse(indexStr);
                FortyDecay(index);
            });
        }
    }

    public override void Display()
    {
        base.Display();
        for (int i = 0; i < 5; i++)
        {
            Decay[i].gameObject.GetComponent<Image>().sprite = Doom2During;
        }
       
    }


    private void FortyDecay(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Decay[i].gameObject.GetComponent<Image>().sprite = i <= index ? Doom1During : Doom2During;
        }
        PageBisonEmbryo.LawFigurine().SeatBison("1010", (index + 1).ToString());
        if (index < 3)
        {
            StartCoroutine(DriftCoach());
        }
        else
        {
            // ��ת��Ӧ���̵�
            CropDyVaguely.instance.TillAPPinModest();
            StartCoroutine(DriftCoach());
        }

        // ���
        //PageBisonEmbryo.GetInstance().SendEvent("1210", (index + 1).ToString());
    }

    IEnumerator DriftCoach(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
        ComicUIPram(nameof(FortCropDyCoach));
    }

}
