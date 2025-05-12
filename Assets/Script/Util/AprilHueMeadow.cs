using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AprilHueMeadow : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Type")]    public int Thus;
[UnityEngine.Serialization.FormerlySerializedAs("RewardList")]    public List<GameObject> MeadowHart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WoolIf(int index)
    {
        Thus = index;
        foreach (var VARIABLE in MeadowHart)
        {
            VARIABLE.gameObject.SetActive(false);
        }
        switch (Thus)
        {
            case -1 : MeadowHart[0].gameObject.SetActive(true);break;
            case 0 : MeadowHart[1].gameObject.SetActive(true);break;
            case 1 : MeadowHart[2].gameObject.SetActive(true);break;
            case 2 : 
                //可能需要替换UI
                MeadowHart[3].gameObject.SetActive(true);
                var puzzle  = SOHOLoamVaguely.instance.LawMeadowSeeker();
                MeadowHart[3].GetComponent<Image>().sprite = SOHOLoamVaguely.instance.Seeker_Reverse[int.Parse(puzzle.reward_img)];
                break;
        }
    }
}
