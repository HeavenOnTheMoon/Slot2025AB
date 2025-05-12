using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseTollSubtractionCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button ComicIts;
    // Start is called before the first frame update
    void Start()
    {
        ComicIts.onClick.AddListener(() => 
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
