using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AprilLifewayCoach : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image ActionSlice;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    public Text SelflessMine;
    AsyncOperation SlateHold;


    void Start()
    {
        ActionSlice.fillAmount = 0;
        SelflessMine.text = "0%";
    }

    // Update is called once per frame
    void Update()
    {
        if (ActionSlice.fillAmount <= 0.8f || SpyLimeYet.instance.Award)
        {
            ActionSlice.fillAmount += Time.deltaTime / 3f;
            SelflessMine.text = (int)(ActionSlice.fillAmount * 100) + "%";
            if (SpyLimeYet.instance.Award && RetoolJean.MyEnsue() && SlateHold == null)
            {
                SlateHold = SceneManager.LoadSceneAsync(1);
                SlateHold.allowSceneActivation = false;
            }
            if (ActionSlice.fillAmount >= 1)
            {
                Destroy(transform.parent.gameObject);
                if (RetoolJean.MyEnsue())
                    SlateHold.allowSceneActivation = true;
                else
                    AprilWarmVaguely.instance.LeapWool();
            }
        }
    }
}