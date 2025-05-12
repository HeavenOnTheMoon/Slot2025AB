using Spine.Unity;
using UnityEngine;

public class SignArchAlong : MonoBehaviour
{
    private SkeletonGraphic Along;
[UnityEngine.Serialization.FormerlySerializedAs("OnceAnimName")]    public string ReapLinkNeon;
[UnityEngine.Serialization.FormerlySerializedAs("OnceAnimTime")]    public float ReapLinkThey;
[UnityEngine.Serialization.FormerlySerializedAs("LoopAnimName")]    public string JoltLinkNeon;

    private void OnEnable()
    {
        Along = GetComponent<SkeletonGraphic>();
        Along.startingLoop = false;
        Along.SetAnim(ReapLinkNeon, false);
        CancelInvoke(nameof(MadJoltLink));
        Invoke(nameof(MadJoltLink), ReapLinkThey);
    }
    void MadJoltLink()
    {
        Along.SetAnim(JoltLinkNeon, true);
        Along.startingLoop = true;
    }
}