using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughTollCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("HomeButton")]    public Button LiveModify;
[UnityEngine.Serialization.FormerlySerializedAs("AddressButton")]    public Button UniformModify;
[UnityEngine.Serialization.FormerlySerializedAs("RandomButton")]    public Button MortalModify;
[UnityEngine.Serialization.FormerlySerializedAs("InstructionsButton")]    public Button AccumulationModify;
[UnityEngine.Serialization.FormerlySerializedAs("Container")]    public Transform Deprecate;

    private Seeker FacadeSeeker;

    // Start is called before the first frame update
    void Start()
    {
        AccumulationModify.onClick.AddListener(() =>
        {
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(ReverseTollSubtractionCoach)));
        });

        LiveModify.onClick.AddListener(() =>
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });
        UniformModify.onClick.AddListener(() =>
        {
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(UniformCoach)));
        });

        MortalModify.onClick.AddListener(() =>
        {
            if (FacadeSeeker != null)
            {
                ADVaguely.Figurine.HookMeadowAlike((success) =>
                {
                    SOHOLoamVaguely.instance.RotMeadowSeeker(FacadeSeeker);
                    MammothHart();
                }, "110");

            }
        });
    }

    public override void Display()
    {
        base.Display();

        MammothHart();

        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1303");
    }

    private void MammothHart()
    {
        FacadeSeeker = SOHOSeekerVaguely.instance.JobMissionarySeeker();
        if (FacadeSeeker == null)
        {
            MortalModify.gameObject.SetActive(false);
        }
        else
        {
            MortalModify.gameObject.SetActive(true);
        }

        int childCount = Deprecate.childCount;
        List<GameObject> removeObjList = new List<GameObject>();
        if (childCount > 0)
        {
            for (int i = 0; i < childCount; i++)
            {
                if (!Deprecate.GetChild(i).gameObject.CompareTag("DonotRemoveItem"))
                {
                    removeObjList.Add(Deprecate.GetChild(i).gameObject);
                }
            }
        }
        if (removeObjList.Count > 0)
        {
            foreach (GameObject obj in removeObjList)
            {
                Destroy(obj);
            }
        }


        GameObject Regard= SOHOLoamVaguely.instance.ThoughTollSink;
        foreach (Seeker item in SOHOSeekerVaguely.instance.TropicLoamSpout)
        {
            GameObject obj = Instantiate(Regard, Deprecate);
            obj.transform.Find("TitleText").GetComponent<Text>().text = item.name;
            obj.transform.Find("RewardImage").GetComponent<Image>().sprite = SOHOLoamVaguely.instance.Seeker_Reverse[int.Parse(item.reward_img)];
            obj.transform.Find("PuzzleSliderBG/PuzzleSlider").GetComponent<Image>().fillAmount = (float)item.claim_count / item.sum_count;
            obj.transform.Find("PuzzleSliderBG/Text").GetComponent<Text>().text = LittleJean.SummerMyNut(item.claim_count) + "/" + item.sum_count;
        }

        Deprecate.GetComponent<RectTransform>().sizeDelta = new Vector2(Deprecate.GetComponent<RectTransform>().sizeDelta.x, 236 * (SOHOSeekerVaguely.instance.TropicLoamSpout.Length + 1) / (RetoolJean.MyFidelity() ? 3 : 5));
    }
}
