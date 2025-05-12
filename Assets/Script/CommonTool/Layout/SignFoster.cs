using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class SignFoster : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Kettle_Thus;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Foster_Thus;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Run_They;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Foster_Little;
    private void Awake()
    {
        if (Run_They == RunTime.Awake)
        {
            BypassGreedy();
        }
    }
    private void Start()
    {
        if (Run_They == RunTime.Start)
        {
            BypassGreedy();
        }
    }

    public void BypassGreedy()
    {
        if (Foster_Thus == LayoutType.Sprite_First_Weight)
        {
            if (Kettle_Thus == TargetType.UGUI)
            {

                float scale = Screen.width / Foster_Little;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Foster_Thus == LayoutType.Screen_First_Weight)
        {
            if (Kettle_Thus == TargetType.Scene)
            {
                float scale = LawCondorCopy.LawFigurine().JobFollowWedge() / Foster_Little;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Foster_Thus == LayoutType.Bottom)
        {
            if (Kettle_Thus == TargetType.Scene)
            {
                float screen_bottom_y = LawCondorCopy.LawFigurine().JobFollowCobalt() / -2;
                screen_bottom_y += (Foster_Little + (LawCondorCopy.LawFigurine().JobDuringTomb(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
