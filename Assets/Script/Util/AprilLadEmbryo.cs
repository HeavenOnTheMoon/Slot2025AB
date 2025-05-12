using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class AprilLadEmbryo : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("OvoImage")]    public GameObject BegSlice;
[UnityEngine.Serialization.FormerlySerializedAs("seq1")]    public Sequence Don1;
[UnityEngine.Serialization.FormerlySerializedAs("seq2")]    public Sequence Don2;
[UnityEngine.Serialization.FormerlySerializedAs("RewardSprites")]    public List<Sprite> MeadowConsult;
    int type;
[UnityEngine.Serialization.FormerlySerializedAs("Btn")]    public Button Its;


    public void flyWatch()
    {
        transform.DOPause();
        Don1.Pause();
        Don2.Pause();
    }
    public void BoyRarity()
    {
        transform.DOPlay();
        Don1.Play();
        Don2.Play();
    }
    public void AssortGreedy()
    {
        GripCopyVaguely.MadExcess(CLazily.Dy_ObligeMeadow, "AprilLadEmbryo");
        BegSlice.SetActive(false);
        StartCoroutine(BiasTopicMeadowCoach());
    }



    IEnumerator BiasTopicMeadowCoach()
    {
        yield return new WaitForSeconds(0.4f);
        transform.DOKill();
        GetComponent<RectTransform>().DOKill();
        Destroy(gameObject);
    }

    public void LadPeakGreedy()
    {
        Don1 = DOTween.Sequence();
        Don2 = DOTween.Sequence();
        int leftOrRight = Random.Range(0, 2);
        if (leftOrRight == 0)
        {
            transform.localPosition = new Vector3(-450f, 0, 0);
            Don1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            Don1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            Don1.SetLoops(-1);
            Don1.Play();

            Don2.Append(transform.DOScale(1.1f, 0.5f).SetEase(Ease.Linear));
            Don2.Append(transform.DOScale(1f, 0.5f).SetEase(Ease.Linear));
            Don2.SetLoops(-1);
            Don2.Play();
            transform.DOLocalMoveX(450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                Don1.Kill();
                Don2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
        else
        {
            transform.localPosition = new Vector3(450, 0, 0);
            Don1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            Don1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            Don1.SetLoops(-1);
            Don1.Play();

            Don2.Append(transform.DOScale(1.1f, 0.5f).SetEase(Ease.Linear));
            Don2.Append(transform.DOScale(1f, 0.5f).SetEase(Ease.Linear));
            Don2.SetLoops(-1);
            Don2.Play();
            transform.DOLocalMoveX(-450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                Don1.Kill();
                Don2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
    }

    void Start()
    {
        Its.onClick.AddListener(AssortGreedy);
        LadPeakGreedy();
    }
    public void LadWool()
    {
        /*GripCopyVaguely.SetInt(CLazily.sv_SecondaryRewardType, 1);
        
        type = ItemManager.Instance.GetSecondaryReward();*/
        GripCopyVaguely.MadAid("SecondaryReward", type);
        for (int i = 0; i < MeadowConsult.Count; i++)
        {
            BegSlice.GetComponent<Image>().SetNativeSize();
        }
    }
}