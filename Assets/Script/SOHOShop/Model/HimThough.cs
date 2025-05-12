using System.Collections.Generic;
using UnityEngine;

public class HimThough : Though
{
    public string type;    // gold/amazon
    public int num;        // 提现所需金币 
    public long startTime;          // 本次提现开始时间
    public long endTime;            // 本次提现结束时间
    public List<CheckoutTask> checkoutTasks;
    public int currentTaskIndex;
    public CheckoutTask currentTask;
    
    public HimThough()
    {
        state = RedeemState.Init;
        /*if (SOHOLoamCopyVaguely.instance.shopJson.cash_checkout_tasks != null && SOHOLoamCopyVaguely.instance.shopJson.cash_checkout_tasks.Length > 0)
        {
            checkoutTasks = new List<CheckoutTask>();
            foreach (CheckoutTask task in SOHOLoamCopyVaguely.instance.shopJson.cash_checkout_tasks)
            {
                checkoutTasks.Add((CheckoutTask)task.Clone());
            }
            currentTaskIndex = 0;
            currentTask = checkoutTasks[0];
        }*/
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
        }
        
        if (currentTaskIndex == -1)
        {
            currentTaskIndex = 0;
            currentTask = checkoutTasks[currentTaskIndex];
        }
        
        if (currentTask.type.Equals(type))
        {
            if (type == "Time")
            {
                currentTaskIndex++;
                currentTask = checkoutTasks[currentTaskIndex];
            }
            else
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
                        if (currentTask.type == "Time")
                        {
                            startTime = CanyJean.Predate();
                            endTime = startTime + (int)currentTask.task_num;
                        }
                    }
                }
            }
        }
        return false;
    }
    
}
