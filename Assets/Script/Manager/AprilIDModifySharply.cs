using System;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 脚本位置：UGUI按钮组件身上
/// 脚本功能：实现按钮长按状态的判断
/// </summary>
 
// 继承：按下，抬起和离开的三个接口
public class AprilIDModifySharply :MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerExitHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("SpinBtn")]    public Button HerdIts;
[UnityEngine.Serialization.FormerlySerializedAs("image")]    public Image Cruel;
[UnityEngine.Serialization.FormerlySerializedAs("EffectObj")]
    public GameObject AdventBis;
    
    // 延迟时间
    private float Photo= 1.5f;

    private float AuroraThey= 0.5f;
 
    // 按钮是否是按下状态
    private bool BeWide= false;

    private bool BeAdventFair= false;
 
    // 按钮最后一次是被按住状态时候的时间
    private float KillMyWideThey;

    private void Start()
    {
        Cruel.alphaHitTestMinimumThreshold = 0.1f;
    }


    void Update ()
    {
        // 如果按钮是被按下状态
        if (BeWide && !GripCopyVaguely.LawLeft(CLazily.Dy_HerdSeedy)) {
            // 当前时间 -  按钮最后一次被按下的时间 > 延迟时间0.2秒
            if (Time.time - KillMyWideThey > Photo) 
            {
                // 触发长按方法
                //Debug.LogError("长按");
                GripCopyVaguely.MadLeft(CLazily.Dy_HerdSeedy, true);
                //PageBisonEmbryo.GetInstance().SendEvent("1014", GripCopyVaguely.GetInt(CLazily.sv_AllSpinCount).ToString());
                BeWide = false;
                RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_HerdItsSeedy, new RewriteCopy(true));
                // 记录按钮最后一次被按下的时间
                KillMyWideThey = Time.time;
                AdventBis.SetActive(false);
            }

            if (BeAdventFair && Time.time - KillMyWideThey > AuroraThey)
            {
                AdventBis.SetActive(true);
                BeAdventFair = false;
            }
            
        } 
    }
 
    // 当按钮被按下后系统自动调用此方法
    public void OnPointerDown (PointerEventData eventData)
    {
        if (HerdIts.enabled && !GripCopyVaguely.LawLeft(CLazily.Dy_HerdSeedy))
        {
            //Debug.LogError("mousePosition == " + Input.mousePosition + "        EffectObj Position == " + EffectObj.transform.position + "     == " + EffectObj.transform.localPosition);
            //EffectObj.transform.localPosition = Input.mousePosition;
            //Debug.LogError("OnPointerDown");
            BeWide = true;
            BeAdventFair = true;
            KillMyWideThey = Time.time;
        }
    }
 
    // 当按钮抬起的时候自动调用此方法
    public void OnPointerUp (PointerEventData eventData)
    {
        if (HerdIts.enabled && !GripCopyVaguely.LawLeft(CLazily.Dy_HerdSeedy))
        {
            //Debug.LogError("OnPointerUp");
            BeWide = false;
            BeAdventFair = false;
            AdventBis.SetActive(false);
        }
    }
 
    // 当鼠标从按钮上离开的时候自动调用此方法
    public void OnPointerExit (PointerEventData eventData)
    {
        if (HerdIts.enabled && !GripCopyVaguely.LawLeft(CLazily.Dy_HerdSeedy))
        {
            //Debug.LogError("OnPointerExit");
            BeWide = false;
            BeAdventFair = false;
            AdventBis.SetActive(false);
        }
    }
}