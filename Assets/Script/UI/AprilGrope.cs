using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AprilGrope : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text GropeMine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        GropeMine.text = GropeVaguely.LawFigurine().Lime;
        StartCoroutine(nameof(CostComicGrope));
    }

    private IEnumerator CostComicGrope()
    {
        yield return new WaitForSeconds(2);
        ComicUIPram(GetType().Name);
    }

}

