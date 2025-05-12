using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>  </summary>
public class LittleSlot : MonoBehaviour
{
    public Click_GamePanel _Click_GamePanel;
    public GameObject SlotMachine;
    public Sprite[] SlotSprites;
    public Transform RealItemParent;
    private List<List<Transform>> RealItems;
    int[] RealLoopCount = new int[3];
    public Transform FakeItemsParent;
    List<List<Transform>> FakeItems;
    int[] FakeLoopCount = new int[3];
    int FakeLoopMax = 15;
    int ItemHigh = 200;
    int Top = 400;
    int Bottom = -400;
    bool IsSloting;
    bool IsSlotWin;
    int WinIndex;
    public Text RewardText;
    string[] RewardTexts = new string[] { "Score +50", "Score +100", "Score +150", "Score +200", "Coin +50" };


    #region 老虎机
    void Init()
    {
        RealItems = new List<List<Transform>>();
        for (int i = 0; i < 3; i++)
        {
            RealItems.Add(new List<Transform>());
            for (int j = 0; j < 1; j++)
            {
                Transform Item = RealItemParent.GetChild(i * 1 + j);
                Item.gameObject.SetActive(false);
                Item.name = $"第{i + 1}列  第{j + 1}行";
                RealItems[i].Add(Item);
            }
        }
        FakeItems = new List<List<Transform>>();
        for (int i = 0; i < 3; i++)
        {
            FakeItems.Add(new List<Transform>());
            for (int j = 0; j < 5; j++)
            {
                Transform Item = FakeItemsParent.GetChild(i * 5 + j);
                int Index = UnityEngine.Random.Range(0, SlotSprites.Length);
                SetSlotIcon(Item, Index);
                Item.name = $"第{i + 1}列  第{j + 1}行";
                FakeItems[i].Add(Item);
            }
        }
    }

    public void Slot()
    {
        if (RealItems == null || RealItems.Count == 0)
            Init();

        IsSloting = true;
        IsSlotWin = true;//Random.value < .7f;
        int[] RealItemIndex = new int[3];
        if (IsSlotWin)
        {
            WinIndex = GetWinIndexByWeight();
            print("老虎机中奖：" + WinIndex);
            for (int i = 0; i < 3; i++)
                RealItemIndex[i] = WinIndex;
        }
        else
        {
            int[] temp = new int[SlotSprites.Length];
            for (int i = 0; i < SlotSprites.Length; i++)
                temp[i] = i;
            for (int i = 0; i < 3; i++)
            {
                int tempIndex = UnityEngine.Random.Range(0, SlotSprites.Length - i);
                int tempValue = temp[tempIndex];
                temp[tempIndex] = temp[SlotSprites.Length - i];
                temp[SlotSprites.Length - i] = tempValue;
            }
            for (int i = 0; i < 3; i++)
                RealItemIndex[i] = temp[i];
        }
        for (int i = 0; i < 3; i++)
        {
            Transform Item = RealItems[i][0];
            SetSlotIcon(Item, RealItemIndex[i]);
            Item.gameObject.SetActive(false);
            Item.transform.localPosition = new Vector2(Item.transform.localPosition.x, Item.transform.localPosition.y + ItemHigh);
        }

        for (int i = 0; i < 3; i++)
        {
            RealLoopCount[i] = 0;
            FakeLoopCount[i] = 0;
            for (int j = 0; j < 5; j++)
                FakeItems[i][j].Find("Icon").gameObject.SetActive(true);
            int Index = i;
            _Click_GamePanel.Delay(Index * .4f, () =>
            {
                FakeColScrollAnim(Index, "开始");
                //MusicMgr.GetInstance().PlayEffect(MusicType.UIMusic.Sound_SlotsRolling);
            });
        }
    }
    int GetWinIndexByWeight()
    {
        // 0:分数+50  1:分数+100  2:分数+150  3:分数+200  4:金币+50
        int[] WinIndex = new int[] { 0, 1, 2, 3, 4 };
        int[] Weights = new int[] { 100, 80, 50, 20, 50 };
        int Sum = 0;
        for (int i = 0; i < WinIndex.Length; i++)
            Sum += Weights[i];
        int RandomNum = UnityEngine.Random.Range(0, Sum);
        for (int i = 0; i < WinIndex.Length; i++)
        {
            RandomNum -= Weights[i];
            if (RandomNum < 0)
                return WinIndex[i];
        }
        return 0;
    }

    void SetSlotIcon(Transform Item, int Index)
    {
        Item.Find("Icon").GetComponent<Image>().sprite = SlotSprites[Index];
        Item.Find("Icon").gameObject.SetActive(true);
    }

    void RealColScrollAnim(int Index)
    {
        float AnimTime = 0.2f;
        Ease AnimEase = Ease.OutBack;
        for (int i = 0; i < 1; i++)
        {
            Transform Item = RealItems[Index][i];
            Item.gameObject.SetActive(true);
            Item.transform.DOLocalMoveY(Item.transform.localPosition.y - ItemHigh, AnimTime).SetEase(AnimEase).OnUpdate(() =>
            {
                for (int j = 0; j < 5; j++)
                {
                    Transform FakeItem = FakeItems[Index][j];
                    if (Mathf.Abs(Item.transform.position.y - FakeItem.transform.position.y) < .5f)
                        FakeItem.Find("Icon").gameObject.SetActive(false);
                }
            });
        }
        _Click_GamePanel.Delay(AnimTime, () =>
        {
            // if (Index == 0)
            //     MusicMgr.GetInstance().PlayEffect(MusicType.UIMusic.Sound_High_Rate_3Slot);
            // else if (Index == 1)
            //     MusicMgr.GetInstance().PlayEffect(MusicType.UIMusic.Sound_High_Rate_4Slot);
            // else if (Index == 2)
            //     MusicMgr.GetInstance().PlayEffect(MusicType.UIMusic.Sound_High_Rate_5Slot);
            if (Index == 2)
                SlotFinish();
        });
    }
    void FakeColScrollAnim(int Index, string AnimType)
    {
        float AnimTime = 0;
        Ease AnimEase = Ease.Linear;
        if (AnimType == "开始")
        {
            AnimTime = 0.2f;
            AnimEase = Ease.InSine;
        }
        else if (AnimType == "持续")
        {
            AnimTime = 0.05f;
            AnimEase = Ease.Linear;
        }
        else if (AnimType == "结束")
        {
            AnimTime = 0.2f;
            AnimEase = Ease.OutBack;
        }
        for (int i = 0; i < 5; i++)
        {
            Transform Item = FakeItems[Index][i];
            Item.transform.DOLocalMoveY(Item.transform.localPosition.y - ItemHigh, AnimTime).SetEase(AnimEase).OnComplete(() =>
            {
                if (Index % 5 == 0)
                    A_AudioManager.Instance.PlaySound("Roll", .6f);
            });
        }
        _Click_GamePanel.Delay(AnimTime, () =>
        {
            for (int i = 0; i < 5; i++)
            {
                Transform Item = FakeItems[Index][i];
                if (Item.transform.localPosition.y < Bottom)
                {
                    Item.transform.localPosition = new Vector2(Item.transform.localPosition.x, Top);
                    SetSlotIcon(Item, UnityEngine.Random.Range(0, SlotSprites.Length));
                    RewardText.text = RewardTexts[Random.Range(0, RewardTexts.Length)];
                    break;
                }
            }

            if (AnimType == "开始")
                FakeColScrollAnim(Index, "持续");
            else if (AnimType == "持续")
            {
                FakeLoopCount[Index]++;
                if (FakeLoopCount[Index] < FakeLoopMax)
                    FakeColScrollAnim(Index, "持续");
                else
                    FakeColScrollAnim(Index, "结束");

                if (FakeLoopCount[Index] == FakeLoopMax)
                    RealColScrollAnim(Index);
            }
        });
    }

    void SlotFinish()
    {
        IsSloting = false;
        RewardText.text = RewardTexts[WinIndex];
        A_AudioManager.Instance.PlaySound("RollEnd");
        _Click_GamePanel.Delay(1.5f, () =>
        {
            transform.DOLocalMoveX(1500, 0.3f).OnComplete(() =>
            {
                gameObject.SetActive(false);

                if (WinIndex == 0)
                    _Click_GamePanel.Score += 50;
                else if (WinIndex == 1)
                    _Click_GamePanel.Score += 100;
                else if (WinIndex == 2)
                    _Click_GamePanel.Score += 150;
                else if (WinIndex == 3)
                    _Click_GamePanel.Score += 200;
                else if (WinIndex == 4)
                    _Click_GamePanel.Money += 50;
                _Click_GamePanel.SetLevelTarget();
            });
        });
    }
    #endregion

}
