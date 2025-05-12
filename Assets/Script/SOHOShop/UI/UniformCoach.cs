using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniformCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button ComicIts;
[UnityEngine.Serialization.FormerlySerializedAs("ConfirmBtn")]    public Button IndianaIts;
[UnityEngine.Serialization.FormerlySerializedAs("LaterBtn")]    public Button BrickIts;
[UnityEngine.Serialization.FormerlySerializedAs("NameText")]    public InputField NeonMine;
[UnityEngine.Serialization.FormerlySerializedAs("AddressText")]    public InputField UniformMine;
[UnityEngine.Serialization.FormerlySerializedAs("TelText")]    public InputField RoeMine;

    // Start is called before the first frame update
    void Start()
    {
        ComicIts.onClick.AddListener(() => {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });
        BrickIts.onClick.AddListener(() => {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });

        IndianaIts.onClick.AddListener(() =>
        {
            SOHOLoamCopyVaguely.instance.GripGannetAtomization(NeonMine.text, UniformMine.text, RoeMine.text);
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });
    }

    public override void Display()
    {
        base.Display();

        NeonMine.text = SOHOLoamCopyVaguely.instance.GannetNeon;
        UniformMine.text = SOHOLoamCopyVaguely.instance.GannetUniform;
        RoeMine.text = SOHOLoamCopyVaguely.instance.GannetRoe;
    }

}
