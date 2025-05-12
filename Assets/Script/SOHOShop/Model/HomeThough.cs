using System;
using System.Collections.Generic;

/// <summary>
/// 绿币提现记录
/// </summary>
public class HomeThough : Though
{
    public long startTime;          // 本次提现开始时间
    public long endTime;            // 本次提现结束时间
    public int JuryAdult;           // 提现任务完成数量（新版本不再使用该字段）
    public List<CheckoutCondition> preCompaction;    // 提现条件
    public bool ManChapbook;        // 满足提现条件
    public List<CheckoutTask> checkoutTasks;
    public int currentTaskIndex;
    public CheckoutTask currentTask;

    public HomeThough()
    {
        state = RedeemState.Init;
        userAccount = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
        if (SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_conditions != null && SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_conditions.Length > 0)
        {
            preCompaction = new List<CheckoutCondition>();
            foreach (CheckoutCondition condition in SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_conditions)
            {
                preCompaction.Add((CheckoutCondition)condition.Surge());
            }
        }
        if (SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks != null && SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks.Length > 0)
        {
            checkoutTasks = new List<CheckoutTask>();
            foreach (CheckoutTask task in SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks)
            {
                checkoutTasks.Add((CheckoutTask)task.Clone());
            }
            currentTaskIndex = 0;
            currentTask = checkoutTasks[0];
        }
        
    }

    /// <summary>
    /// 是否满足提现条件
    /// </summary>
    /// <returns></returns>
    public bool TrailCanWarbler()
    {
        if (state != RedeemState.Init && state != RedeemState.Unchecked)
        {
            return false;
        }
        else if (state == RedeemState.Unchecked)
        {
            return true;
        }
        else
        {
            if (preCompaction == null || preCompaction.Count == 0)
            {
                if (CanyJean.Predate() >= endTime)
                {
                    TurkicSeedy();
                    return true;
                }
            }
            else
            {
                foreach (CheckoutCondition condition in preCompaction)
                {
                    if (condition.conditionType == CheckoutConditionType.Time)
                    {
                        if (CanyJean.Predate() >= endTime)
                        {
                            TurkicSeedy();
                            return true;
                        }
                    }
                    else if (condition.conditionType == CheckoutConditionType.Balance)
                    {
                        double cashBalance = GripCopyVaguely.LawSummer(SOHOLoamGuard.Dy_HomeTolerantPrimacy);
                        if (cashBalance >= condition.condition_num)
                        {
                            TurkicSeedy();
                            return true;
                        }
                    }
                    else if (condition.conditionType == CheckoutConditionType.Custom)
                    {
                        if (condition.value >= condition.condition_num)
                        {
                            TurkicSeedy();
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    /// <summary>
    /// 修改自定义提现条件值
    /// </summary>
    /// <param name="name"></param>
    /// <param name="addValue"></param>
    public void RotWitMetalworkAdult(string name, double addValue = 1)
    {
        if (state != RedeemState.Init)
        {
            return;
        }
        if (preCompaction == null || preCompaction.Count == 0)
        {
            return;
        }
        for (int i = 0; i < preCompaction.Count; i++)
        {
            if (preCompaction[i].conditionType == CheckoutConditionType.Custom && name.Equals(preCompaction[i].name))
            {
                preCompaction[i].value += addValue;
                if (preCompaction[i].value >= preCompaction[i].condition_num)
                {
                    TurkicSeedy();
                }
            }
        }
    }

    public bool RotPestAdult(string type, double addValue)
    {
        if (checkoutTasks == null || checkoutTasks.Count == 0)
        {
            checkoutTasks = new List<CheckoutTask>();
            foreach (CheckoutTask task in SOHOLoamCopyVaguely.instance.DrabJson.cash_checkout_tasks)
            {
                checkoutTasks.Add((CheckoutTask)task.Clone());
            }

            for (int i = 0; i < checkoutTasks.Count; i++)
            {
                if (checkoutTasks[i].type.Equals("AD"))
                {
                    checkoutTasks[i].value = JuryAdult;
                }
            }
        }
        if (currentTaskIndex == -1)
        {
            currentTaskIndex = 0;
            currentTask = checkoutTasks[currentTaskIndex];
        }

        if (currentTask.type.Equals(type))
        {
            currentTask.value += addValue;
            // 完成当前任务
            if (currentTask.value >= currentTask.task_num)
            {
                if (currentTaskIndex == checkoutTasks.Count - 1)
                {
                    // 如果该提现记录完成了所有任务，进入排队阶段
                    return true;
                }
                else
                {
                    currentTaskIndex++;
                    currentTask = checkoutTasks[currentTaskIndex];
                }
            }
        }
        return false;
    }

    private void TurkicSeedy()
    {
        if (state != RedeemState.Init)
        {
            return;
        }

        double cashBalance = GripCopyVaguely.LawSummer(SOHOLoamGuard.Dy_HomeTolerantPrimacy);
        if (cashBalance > 0)
        {
            ManChapbook = true;
        }
        else
        {
            ManChapbook = false;
        }
    }
}

public class CheckoutCondition
{
    public string type;  // 条件类型
    public CheckoutConditionType conditionType;
    public string name;         // 条件名称（用于自定义条件）
    public double condition_num;    // 条件数量
    public double value;           // 已完成数量
    public string desc;

    public object Surge()
    {
        return this.MemberwiseClone();
    }
}



/// <summary>
/// 提现条件
/// </summary>
public enum CheckoutConditionType
{
    Time,       // 时间
    Balance,    // 提现金额
    Custom      // 用户自定义任务
}
