using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpressionlessCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]    public Button Modify_Comic;
    protected override void Awake()
    {
        base.Awake();
        Modify_Comic.onClick.AddListener(()=> {
            ComicUIPram(nameof(ExpressionlessCoach));
        });
    }
}
