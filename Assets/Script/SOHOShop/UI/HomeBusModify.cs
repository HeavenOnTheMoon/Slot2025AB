using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeBusModify : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("RedeemCountdownText")]    public Text ThoughAuthorityMine;

    private long DualTolerantAuthority;
    private Coroutine NecessityAccording;

    // Start is called before the first frame update
    void Start()
    {
        BiasHomeTolerantLoamAuthority();

        // 刷新现金提现倒计时
        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenAuthority, (messageData) => {
            BiasHomeTolerantLoamAuthority();
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_FairHomeLoamLung, (messageData) => {
            BiasLung();
        });
    }

    public void BiasLung()
    {
        bool showHand = SOHOLoamVaguely.instance.HayManifestHomeTolerant();
        if (showHand)
        {
            transform.Find("Hand").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("Hand").gameObject.SetActive(false);
        }
    }


    // 显示倒计时
    public void BiasHomeTolerantLoamAuthority()
    {
        if (RetoolJean.MyEnsue())
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            DualTolerantAuthority = SOHOLoamVaguely.instance.LawHomeTolerantWhaleWide();
            if (DualTolerantAuthority > 0)
            {
                ThoughAuthorityMine.transform.parent.gameObject.SetActive(true);
                if (NecessityAccording != null)
                {
                    StopCoroutine(NecessityAccording);
                }
                NecessityAccording = StartCoroutine(DualAuthority());
            }
            else
            {
                ThoughAuthorityMine.transform.parent.gameObject.SetActive(false);
            }
        }
    }

    private IEnumerator DualAuthority()
    {
        while (DualTolerantAuthority >= 0)
        {
            DualTolerantAuthority--;
            ThoughAuthorityMine.text = CanyJean.ParadoxSquirt(DualTolerantAuthority);
            yield return new WaitForSeconds(1);
        }
        // 重新获取倒计
        SOHOLoamVaguely.instance.HomeTolerantShrineAuthority();
        yield return new WaitForSeconds(1);
        BiasHomeTolerantLoamAuthority();
    }
}
