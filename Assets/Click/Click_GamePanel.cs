using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Spine.Unity;
using System.Linq.Expressions;

public enum ClickItemType { A, B, C, D, E, F }

/// <summary>  </summary>
public class Click_GamePanel : MonoBehaviour
{
    int Level;
    public Text LevelText;
    int Energy;
    public Text EnergyText;
    [HideInInspector] public int Money;
    public Text MoneyText;
    int Step;
    public Text StepText;
    [HideInInspector] public int Score;
    public Text ScoreText;
    int TargetScore;
    public Button StartBtn;
    public Transform TipTransform;
    public Text TipText;
    public GameObject BlockMask;
    public Transform ItemParent;
    public Click_Item ItemPrefab;
    public Sprite[] ItemSprites;
    public ParticleSystem CollectEffectPrefab;
    public Color[] CollectEffectColors;
    Click_Item[,] Items = new Click_Item[6, 6];
    Vector2[,] ItemPos = new Vector2[6, 6];
    bool[,] Checked = new bool[6, 6]; // 用来记录哪些item已经被访问过

    int MinerSpeedLevel = 0; // 矿工速度等级
    float MinerSpeed = 8f; // 矿工速度
    public SkeletonGraphic MinerSpine;
    int MineChestLevel = 0; // 仓库宝箱等级
    int MineChestMoney = 0; // 仓库宝箱金额
    public Text MineChestMoneyText;
    int MineBornLevel = 0; // 矿产出等级
    public Text MineBornMoneyTip;
    public Button MineChestBtn;
    int Exp;
    public Text ExpText;
    public Button LevelUpBtn;
    public Transform LevelUpPanel;
    public Button[] LevelUpBtns;
    public Text[] LevelUpTexts;
    public Text[] LevelUpPriceTexts;
    public ParticleSystem GetCoinEffect;
    public ParticleSystem DigEffect;

    public GameObject FinishPanel;
    public GameObject RevivePanel;
    public GameObject WinPanel;
    public Button ReviveBtn_Ad;
    public Button ReviveBtn_Money;
    public Button RestartBtn;
    public Text Win_LevelText;
    public Text Win_ScoreText;
    int ReviveTimer;
    public Text ReviveTimerText;

    public GameObject BuyEnergyPanel;
    public Button BuyEnergyBtn;
    public LittleSlot _LittleSlot;


    void Start()
    {
        Application.targetFrameRate = 60;
        TipTransform.localScale = new Vector2(1, 0);
        StartBtn.onClick.AddListener(() =>
        {
            if (Energy > 0)
            {
                Energy--;
                if (!PlayerPrefs.HasKey("AddEneryTime"))
                    PlayerPrefs.SetString("AddEneryTime", (System.DateTimeOffset.Now.ToUnixTimeSeconds() + 600).ToString());
                UpdateEnergy();
                StartBtn.gameObject.SetActive(false);
                SetLevelTarget();
                Delay(1.5f, () => { ResetGrid(); });
            }
            else
                BuyEnergyPanel.SetActive(true);
        });
        BuyEnergyBtn.onClick.AddListener(() =>
        {
            A_ADManager.Instance.playRewardVideo((ok) =>
            {
                if (ok)
                {
                    BuyEnergyPanel.SetActive(false);
                    Energy += 5;
                    UpdateEnergy();
                }
            });
        });

        Energy = PlayerPrefs.GetInt("Energy", 5);
        UpdateEnergy();
        Money = PlayerPrefs.GetInt("Money", 0);
        UpdateMoney();
        Level = 1;
        UpdateLevel();
        for (int i = 0; i < ItemParent.childCount; i++)
            ItemParent.GetChild(i).localScale = Vector2.zero;
        InvokeRepeating(nameof(EnergyTimeCount), 1, 1);

        LevelUpPanel.gameObject.SetActive(true);
        LevelUpPanel.localScale = Vector2.zero;
        LevelUpBtn.onClick.AddListener(() =>
        {
            LevelUpPanel.DOKill();
            if (LevelUpPanel.localScale.x == 0)
                LevelUpPanel.DOScale(Vector2.one, .3f).SetEase(Ease.OutBack);
            else
                LevelUpPanel.DOScale(Vector2.zero, .3f).SetEase(Ease.InBack);
        });
        Exp = PlayerPrefs.GetInt("Exp", 0);
        UpdateExp();

        MinerSpeedLevel = PlayerPrefs.GetInt("MinerSpeedLevel", 0);
        MineChestLevel = PlayerPrefs.GetInt("MineChestLevel", 0);
        MineBornLevel = PlayerPrefs.GetInt("MineBornLevel", 0);
        UpdateLevelUpPanel();
        for (int i = 0; i < 3; i++)
        {
            int Index = i;
            LevelUpBtns[Index].onClick.AddListener(() => { LevelUp(Index); });
        }
        MineChestMoney = PlayerPrefs.GetInt("MineChestMoney", 0);
        UpdateMineChestMoney();
        MineChestBtn.onClick.AddListener(() => GetMineChestMoney());
        MineBornMoneyTip.transform.localScale = Vector2.zero;
        MinerAnim();

        FinishPanel.SetActive(false);
        RestartBtn.onClick.AddListener(() => { OnRestartBtn(); });
        ReviveBtn_Ad.onClick.AddListener(() => { OnReviveBtn_Ad(); });
        ReviveBtn_Money.onClick.AddListener(() => { OnReviveBtn_Money(); });

    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (!pauseStatus)
        {
            if (PlayerPrefs.HasKey("LastTime"))
            {
                int OfflineTime = (int)(System.DateTimeOffset.Now.ToUnixTimeSeconds() - long.Parse(PlayerPrefs.GetString("LastTime")));
                int AddEnergy = (int)(OfflineTime / 600);
                Energy = PlayerPrefs.GetInt("Energy", 5);
                Energy += AddEnergy;
                if (Energy > 5)
                {
                    Energy = 5;
                    PlayerPrefs.DeleteKey("AddEneryTime");
                }
                if (Energy > 0)
                    UpdateEnergy();
            }
        }
    }

    void EnergyTimeCount()
    {
        PlayerPrefs.SetString("LastTime", System.DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
        if (Energy < 5)
        {
            long AddEneryTime = 0;
            if (PlayerPrefs.HasKey("AddEneryTime"))
                AddEneryTime = long.Parse(PlayerPrefs.GetString("AddEneryTime"));
            else
            {
                AddEneryTime = System.DateTimeOffset.Now.ToUnixTimeSeconds() + 600;
                PlayerPrefs.SetString("AddEneryTime", AddEneryTime.ToString());
            }
            if (AddEneryTime < System.DateTimeOffset.Now.ToUnixTimeSeconds())
            {
                Energy++;
                UpdateEnergy();
                PlayerPrefs.DeleteKey("AddEneryTime");
            }
        }
        UpdateEnergy();
    }

    public void SetLevelTarget()
    {
        Step = 5;
        if (Level == 1)
            TargetScore = 100;
        else if (Level == 2)
            TargetScore = 250;
        else if (Level == 3)
            TargetScore = 500;
        else if (Level == 4)
            TargetScore = 800;
        else if (Level == 5)
            TargetScore = 1200;
        else if (Level == 6)
            TargetScore = 1600;
        else if (Level == 7)
            TargetScore = 2000;
        else if (Level == 8)
            TargetScore += 500;

        UpdateStep();
        UpdateScore();
        UpdateMoney();

        TipText.text = string.Format("Level {0}\nGet <color=yellow>{1}</color> score\nwithin <color=yellow>{2}</color> steps", Level, TargetScore, Step);
        TipTransform.DOScale(Vector2.one, .3f).SetEase(Ease.OutBack);
        Delay(1.5f, () => { TipTransform.DOScale(new Vector2(1, 0), .3f).SetEase(Ease.InBack); });
    }

    void ResetGrid()
    {
        GridLayoutGroup grid = ItemParent.GetComponent<GridLayoutGroup>();
        int ItemIndex = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                //初始化棋子
                Items[i, j] = ItemParent.GetChild(ItemIndex).GetComponent<Click_Item>();
                Items[i, j].Init(i, j, (ClickItemType)Random.Range(0, ItemSprites.Length), this);
                Items[i, j].gameObject.SetActive(true);
                //初始化位置 
                ItemPos[i, j] = new Vector2(-400f + j * (grid.cellSize.x + grid.spacing.x), 400f - i * (grid.cellSize.y + grid.spacing.y));
                Items[i, j].transform.localPosition = ItemPos[i, j];
                //动画
                Items[i, j].transform.DOKill();
                Items[i, j].transform.localScale = Vector2.zero;
                Items[i, j].transform.DOScale(Vector2.one, .3f).SetDelay(Random.Range(0.2f, 1f)).SetEase(Ease.OutBack);
                ItemIndex++;
            }
        }
    }

    public void Choose(Click_Item item)
    {
        if (Step <= 0)
            return;

        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 6; j++)
                Checked[i, j] = false;
        // 找出所有同类型相邻的item
        List<Click_Item> matchedItems = new List<Click_Item>();
        CheckSameType(item.X, item.Y, item.Type, matchedItems);
        if (matchedItems.Count >= 2)
        {
            BlockMask.SetActive(true);
            foreach (var matchedItem in matchedItems)
            {
                ParticleSystem Effect = Instantiate(CollectEffectPrefab, matchedItem.transform.position, Quaternion.identity);
                var mainModule = Effect.main; // 获取粒子系统的主要模块
                mainModule.startColor = CollectEffectColors[(int)matchedItem.Type]; // 设置随机颜色
                if (matchedItems.Count >= 12)
                    Effect.transform.localScale = Vector3.one * .6f;
                else if (matchedItems.Count >= 9)
                    Effect.transform.localScale = Vector3.one * .5f;
                else if (matchedItems.Count >= 6)
                    Effect.transform.localScale = Vector3.one * .4f;
                else
                    Effect.transform.localScale = Vector3.one * .3f;

                matchedItem.transform.DOScale(Vector2.zero, .4f);
                matchedItem.transform.DORotate(new Vector3(0, 0, 90), .1f).SetEase(Ease.Linear).SetLoops(4, LoopType.Incremental).OnComplete(() =>
                {
                    Items[matchedItem.X, matchedItem.Y] = null;
                    Destroy(matchedItem.gameObject);
                    Destroy(Effect.gameObject, 1);
                });
            }
            Delay(.6f, () => { FillItems(); });
            Delay(1, () =>
            {
                BlockMask.SetActive(false);
                FinishCheck();
            });

            Step--;
            UpdateStep();
            int AddScore = matchedItems.Count;
            float volume = .4f;
            if (matchedItems.Count >= 12)
            {
                AddScore *= 5;
                volume = 1;
            }
            else if (matchedItems.Count >= 9)
            {
                AddScore *= 3;
                volume = .8f;
            }
            else if (matchedItems.Count >= 6)
            {
                AddScore *= 2;
                volume = .6f;
            }
            A_AudioManager.Instance.PlaySound("Collect", volume);
            Score += AddScore;
            UpdateScore();
            Exp += AddScore;
            UpdateExp();
        }
    }

    private void CheckSameType(int x, int y, ClickItemType type, List<Click_Item> matchedItems)
    {
        // 检查边界条件和是否已经访问过
        if (x < 0 || x >= 6 || y < 0 || y >= 6 || Checked[x, y] || Items[x, y].Type != type) return;
        // 标记当前item为已访问
        Checked[x, y] = true;
        matchedItems.Add(Items[x, y]);
        // 递归检查上下左右四个方向的item
        CheckSameType(x - 1, y, type, matchedItems); // 上
        CheckSameType(x + 1, y, type, matchedItems); // 下
        CheckSameType(x, y - 1, type, matchedItems); // 左
        CheckSameType(x, y + 1, type, matchedItems); // 右
    }

    void FillItems() //填充item 
    {
        for (int Y = 0; Y < Items.GetLength(1); Y++)
        {
            for (int X = Items.GetLength(0) - 1; X >= 0; X--)   // 从底部开始检查每一列
            {
                // 如果当前位置为空，表示该棋子已经被消除
                if (Items[X, Y] == null)
                {
                    for (int AboveX = X - 1; AboveX >= 0; AboveX--)
                    {
                        // 如果上方有棋子 下移棋子
                        if (Items[AboveX, Y] != null)
                        {
                            Items[X, Y] = Items[AboveX, Y];
                            Items[X, Y].transform.DOLocalMove(ItemPos[X, Y], .3f).SetEase(Ease.OutBack);
                            Items[AboveX, Y] = null; // 上方位置清空
                            break; //检查下一个空位
                        }
                    }

                    // 填充新棋子
                    if (Items[X, Y] == null)
                    {
                        Items[X, Y] = Instantiate(ItemPrefab);
                        Items[X, Y].transform.SetParent(ItemParent);
                        Items[X, Y].transform.localScale = Vector3.one;
                        Items[X, Y].transform.localPosition = new Vector2(Random.value < .5f ? 600 : -600, 600);
                        Vector2 Pos = ItemPos[X, Y];
                        Items[X, Y].transform.DOLocalMoveX(Pos.x, .3f);
                        Items[X, Y].transform.DOLocalMoveY(Pos.y, .3f).SetEase(Ease.OutBack).SetDelay(.3f);
                        Items[X, Y].Init(X, Y, (ClickItemType)Random.Range(0, ItemSprites.Length), this);

                    }
                }
            }
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (Items[i, j] != null)
                {
                    Items[i, j].ResetXY(i, j);
                }
            }
        }
    }

    void FinishCheck()
    {
        if (Step <= 0)
        {
            if (Score >= TargetScore) // 胜利
            {
                Level++;
                UpdateLevel();
                //SetLevelTarget();
                _LittleSlot.gameObject.SetActive(true);
                _LittleSlot.transform.localPosition = new Vector2(-1500, 0);
                _LittleSlot.transform.DOLocalMoveX(0, .3f).SetDelay(.5f);
                Delay(2, () => { _LittleSlot.Slot(); });
                A_AudioManager.Instance.PlaySound("Win");
            }
            else // 失败
            {
                FinishPanel.SetActive(true);
                WinPanel.SetActive(false);
                RevivePanel.SetActive(true);
                ReviveTimer = 11;
                InvokeRepeating(nameof(ReviveTimerCount), 0, 1);
                A_AudioManager.Instance.PlaySound("Lose");
            }
        }
    }
    void ReviveTimerCount()
    {
        if (ReviveTimer > 0)
        {
            ReviveTimer--;
            ReviveTimerText.text = "Revive countdown : " + ReviveTimer;
        }
        else
        {
            CancelInvoke(nameof(ReviveTimerCount));
            RevivePanel.SetActive(false);
            WinPanel.SetActive(true);
            Win_LevelText.text = "Level " + Level;
            Win_ScoreText.text = "Score " + Score;
        }
    }
    void OnReviveBtn_Ad()
    {
        A_ADManager.Instance.playRewardVideo((ok) =>
        {
            if (ok)
            {
                CancelInvoke(nameof(ReviveTimerCount));
                Step += 5;
                UpdateStep();
                FinishPanel.SetActive(false);
            }
        });
    }
    void OnReviveBtn_Money()
    {
        if (Money >= 200)
        {
            Money -= 200;
            UpdateMoney();
            Step += 5;
            UpdateStep();
            FinishPanel.SetActive(false);
        }
    }
    void OnRestartBtn()
    {
        FinishPanel.SetActive(false);
        Level = 1;
        UpdateLevel();
        Score = 0;
        TargetScore = 0;
        UpdateScore();
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 6; j++)
                Items[i, j].gameObject.SetActive(false);
        StartBtn.gameObject.SetActive(true);
    }

    void UpdateLevel()
    {
        TextAnim(LevelText, "LEVEL " + Level);
    }
    void UpdateEnergy()
    {
        if (Energy >= 5)
            EnergyText.text = Energy.ToString();
        else
        {
            if (PlayerPrefs.HasKey("AddEneryTime"))
            {
                long AddEneryTime = 0;
                AddEneryTime = long.Parse(PlayerPrefs.GetString("AddEneryTime"));
                long NowTime = System.DateTimeOffset.Now.ToUnixTimeSeconds();
                string MinStr = ((AddEneryTime - NowTime) / 60).ToString("D2");
                string SecStr = ((AddEneryTime - NowTime) % 60).ToString("D2");
                EnergyText.text = Energy + "\n<size=20>(" + MinStr + ":" + SecStr + ")</size>";
            }
            else
                EnergyText.text = Energy + "\n<size=20>(00:00)</size>";
        }
        PlayerPrefs.SetInt("Energy", Energy);
    }
    void UpdateMoney()
    {
        TextAnim(MoneyText, Money.ToString());
        PlayerPrefs.SetInt("Money", Money);
    }
    void UpdateStep()
    {
        TextAnim(StepText, Step.ToString());
    }
    void UpdateScore()
    {
        TextAnim(ScoreText, string.Format("Score:{0}/{1}", Score, TargetScore));
    }
    void UpdateExp()
    {
        PlayerPrefs.SetInt("Exp", Exp);
        TextAnim(ExpText, "EXP:" + Exp.ToString());
    }
    void UpdateMineChestMoney()
    {
        TextAnim(MineChestMoneyText, MineChestMoney + "/" + GetMineChestMoney_Max());
        PlayerPrefs.SetInt("MineChestMoney", MineChestMoney);
        MineChestBtn.transform.DOKill();
        MineChestBtn.transform.localScale = Vector2.one;
        if (MineChestMoney >= GetMineChestMoney_Max())
        {
            MineChestMoneyText.text = "FULL";
            MineChestBtn.transform.DOScale(Vector2.one * 1.2f, .3f).SetLoops(-1, LoopType.Yoyo);
        }
    }

    void MinerAnim()
    {
        MinerSpine.transform.DOKill();
        if (MinerSpine.transform.eulerAngles.y != 0)
            MinerSpine.transform.DOLocalRotate(new Vector3(0, 0, 0), .2f).SetEase(Ease.Linear);
        MinerSpine.timeScale = 1;
        if (MineChestMoney >= GetMineChestMoney_Max())
        {
            MinerSpine.SetAnim("daiji", true);
            return;
        }
        //MinerSpeedLevel=5;
        float AnimTime = 8f * (1 - MinerSpeedLevel * 0.1f);
        float MoveTime = AnimTime * .2f;
        float DigTime = AnimTime * .6f;
        MinerSpine.timeScale = 1 + MinerSpeedLevel * 0.1f;
        MinerSpine.SetAnim("zou", true);
        MinerSpine.transform.DOLocalMoveX(150, MoveTime).SetEase(Ease.Linear).OnComplete(() =>
        {
            MinerSpine.SetAnim("paodongxi", true);
            MinerSpine.transform.DOLocalMoveX(-300, MoveTime).SetEase(Ease.Linear).SetDelay(DigTime).OnStart(() =>
            {
                MinerSpine.transform.DOLocalRotate(new Vector3(0, 180, 0), .2f).SetEase(Ease.Linear);
                MinerSpine.SetAnim("zou", true);
            }).OnComplete(() =>
            {
                MineBornMoney();
                MinerAnim();
            });
        });
    }
    void MineBornMoney()
    {
        int Born = (MineBornLevel + 1); // 矿产出金额
        MineChestMoney += Born;
        if (MineChestMoney > GetMineChestMoney_Max())
            MineChestMoney = GetMineChestMoney_Max();
        UpdateMineChestMoney();

        MineBornMoneyTip.text = "+ " + Born;
        MineBornMoneyTip.transform.DOKill();
        MineBornMoneyTip.transform.localScale = Vector2.zero;
        MineBornMoneyTip.transform.DOScale(Vector2.one, .3f).SetEase(Ease.OutBack);
        MineBornMoneyTip.transform.localPosition = Vector2.zero;
        MineBornMoneyTip.transform.DOLocalMoveY(200, .4f).SetEase(Ease.OutBack);
        MineBornMoneyTip.transform.DOScale(Vector2.zero, .2f).SetDelay(2);
    }
    int GetMineChestMoney_Max()
    {
        int MineChestMoney_Max = 0; // 仓库宝箱最大金额
        if (MineChestLevel == 0)
            MineChestMoney_Max = 50;
        else if (MineChestLevel == 1)
            MineChestMoney_Max = 100;
        else if (MineChestLevel == 2)
            MineChestMoney_Max = 200;
        else if (MineChestLevel == 3)
            MineChestMoney_Max = 300;
        else if (MineChestLevel == 4)
            MineChestMoney_Max = 500;
        return MineChestMoney_Max;
    }
    void GetMineChestMoney()
    {
        if (MineChestMoney <= 0)
            return;

        GetCoinEffect.Play();
        Money += MineChestMoney;
        MineChestMoney = 0;
        Delay(1, () => { UpdateMoney(); });
        UpdateMineChestMoney();
        if (MinerSpine.PlayingAnimName() == "daiji")
            MinerAnim();
    }

    void UpdateLevelUpPanel()
    {
        LevelUpTexts[0].text = "Miner Speed\nLV." + MinerSpeedLevel;
        LevelUpTexts[1].text = "Chect Max\nLV." + MineChestLevel;
        LevelUpTexts[2].text = "Output\nLV." + MineBornLevel;
        LevelUpPriceTexts[0].text = MinerSpeedLevel >= 5 ? "MAX" : GetLevelPrive(MinerSpeedLevel).ToString();
        LevelUpPriceTexts[1].text = MineChestLevel >= 5 ? "MAX" : GetLevelPrive(MineChestLevel).ToString();
        LevelUpPriceTexts[2].text = MineBornLevel >= 5 ? "MAX" : GetLevelPrive(MineBornLevel).ToString();
    }
    int GetLevelPrive(int Level)
    {
        if (Level == 0)
            return 100;
        else if (Level == 1)
            return 500;
        else if (Level == 2)
            return 1000;
        else if (Level == 3)
            return 5000;
        else if (Level == 4)
            return 10000;
        return 0;
    }
    void LevelUp(int index)
    {
        int level = 0;
        if (index == 0)
            level = MinerSpeedLevel;
        else if (index == 1)
            level = MineChestLevel;
        else if (index == 2)
            level = MineBornLevel;
        if (level >= 5)
            return;
        int Price = GetLevelPrive(level);
        if (Exp >= Price)
        {
            Exp -= Price;
            UpdateExp();
            if (index == 0)
            {
                MinerSpeedLevel++;
                PlayerPrefs.SetInt("MinerSpeedLevel", MinerSpeedLevel);
            }
            else if (index == 1)
            {
                MineChestLevel++;
                PlayerPrefs.SetInt("MineChestLevel", MineChestLevel);
            }
            else if (index == 2)
            {
                MineBornLevel++;
                PlayerPrefs.SetInt("MineBornLevel", MineBornLevel);
            }
            UpdateLevelUpPanel();
        }
        else
        {
            ExpText.transform.DOKill();
            float PosX = ExpText.transform.localPosition.x;
            ExpText.transform.localPosition = new Vector2(PosX, ExpText.transform.localPosition.y);
            ExpText.transform.DOLocalMoveX(PosX - 30, .1f).SetEase(Ease.InOutBack);
            ExpText.transform.DOLocalMoveX(PosX + 50, .2f).SetDelay(.1f).SetEase(Ease.InOutBack);
            ExpText.transform.DOLocalMoveX(PosX, .1f).SetDelay(.3f).SetEase(Ease.InOutBack);
            ExpText.DOKill();
            ExpText.color = Color.white;
            ExpText.DOColor(Color.red, .1f);
            ExpText.DOColor(Color.white, .1f).SetDelay(.3f);
        }
    }

    public Coroutine Delay(float delay, System.Action action)
    {
        return StartCoroutine(DelayIE(delay, action));
    }
    IEnumerator DelayIE(float delay, System.Action action)
    {
        yield return new WaitForSeconds(delay);
        action?.Invoke();
    }

    void TextAnim(Text _Text, string Info) //文字跳动动画
    {
        _Text.transform.DOKill();
        _Text.transform.localScale = Vector2.one;
        _Text.transform.DOScale(Vector2.one * 1.2f, .2f).OnComplete(() =>
        {
            _Text.text = Info;
            _Text.transform.DOScale(Vector2.one, .2f);
        });
    }
}
