using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 基础UI窗体脚本（父类，其他窗体都继承此脚本）
/// </summary>
public class LeftUIMarry : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("_CurrentUIType")]    //当前（基类）窗口的类型
    public UIThus _PredateUIThus= new UIThus();
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("close_button")]    public Button Drift_Assort;
    //属性，当前ui窗体类型
    internal UIThus PredateUIThus    {
        set
        {
            _PredateUIThus = value;
        }
        get
        {
            return _PredateUIThus;
        }
    }
    protected virtual void Awake()
    {
        LaceKneelRotOutnumber(gameObject);
        if (transform.Find("Window/Content/CloseBtn"))
        {
            Drift_Assort = transform.Find("Window/Content/CloseBtn").GetComponent<Button>();
            Drift_Assort.onClick.AddListener(() => {
                UIInject.LawFigurine().ComicOrEnamelUIMarry(this.GetType().Name);
            });
        }
        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp)
        {
            gameObject.AddComponent<CanvasGroup>();
        }
        gameObject.name = GetType().Name;
    }


    public static void LaceKneelRotOutnumber(GameObject goParent)
    {
        Transform parent = goParent.transform;
        int childCount = parent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform chile = parent.GetChild(i);
            if (chile.GetComponent<Button>())
            {
                chile.GetComponent<Button>().onClick.AddListener(() => {

                    GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_UIButton);
                });
            }
            
            if (chile.childCount > 0)
            {
                LaceKneelRotOutnumber(chile.gameObject);
            }
        }
    }

    //页面显示
    public virtual void Display()
    {
        //Debug.Log(this.GetType().Name);
        this.gameObject.SetActive(true);
        // 设置模态窗体调用(必须是弹出窗体)
        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp && _PredateUIThus.UIForm_LucencyType != UIFormLucenyType.NoMask)
        {
            UISaleYet.LawFigurine().MadSaleSorrow(this.gameObject, _PredateUIThus.UIForm_LucencyType);
        }
        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp)
        {

            //动画添加
            switch (_PredateUIThus.UIForm_animationType)
            {
                case UIFormShowAnimationType.scale:
                    EpidermisPalimpsest.InkFair(gameObject, () =>
                    {

                    });
                    break;

            }
            
        }
        //NewUserManager.GetInstance().TriggerEvent(TriggerType.panel_display);
    }
    //页面隐藏（不在栈集合中）
    public virtual void Hidding(System.Action finish = null)
    {
        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp && _PredateUIThus.UIForm_LucencyType != UIFormLucenyType.NoMask)
        {
            UISaleYet.LawFigurine().FundSaleSorrow();
        }

        //取消模态窗体调用

        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp)
        {
            switch (_PredateUIThus.UIForm_animationType)
            {
                case UIFormShowAnimationType.scale:
                    EpidermisPalimpsest.InkFund(gameObject, () =>
                    {
                        this.gameObject.SetActive(false);
                        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp && _PredateUIThus.UIForm_LucencyType != UIFormLucenyType.NoMask)
                        {
                            UISaleYet.LawFigurine().WeightSaleSorrow();
                        }
                        UIInject.LawFigurine().FairReadInkID();
                        finish?.Invoke();
                    });
                    break;
                case UIFormShowAnimationType.none:
                    this.gameObject.SetActive(false);
                    if (_PredateUIThus.UIForms_Type == UIFormType.PopUp && _PredateUIThus.UIForm_LucencyType != UIFormLucenyType.NoMask)
                    {
                        UISaleYet.LawFigurine().WeightSaleSorrow();
                    }
                    UIInject.LawFigurine().FairReadInkID();
                    finish?.Invoke();
                    break;

            }

        }
        else
        {
            this.gameObject.SetActive(false);
            if (_PredateUIThus.UIForms_Type == UIFormType.PopUp && _PredateUIThus.UIForm_LucencyType != UIFormLucenyType.NoMask)
            {
                UISaleYet.LawFigurine().WeightSaleSorrow();
            }
            finish?.Invoke();
        }
    }

    public virtual void Hidding()
    {
        Hidding(null);
    }

    //页面重新显示
    public virtual void Redisplay()
    {
        this.gameObject.SetActive(true);
        if (_PredateUIThus.UIForms_Type == UIFormType.PopUp)
        {
            UISaleYet.LawFigurine().MadSaleSorrow(this.gameObject, _PredateUIThus.UIForm_LucencyType); 
        }
    }
    //页面冻结（还在栈集合中）
    public virtual void Survey()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 注册按钮事件
    /// </summary>
    /// <param name="buttonName">按钮节点名称</param>
    /// <param name="delHandle">委托，需要注册的方法</param>
    protected void ExerciseModifySourceBison(string buttonName,BisonAbigailReadjust.VoidDelegate delHandle)
    {
        GameObject goButton = LedgeReport.LaceSacKneelBust(this.gameObject, buttonName).gameObject;
        //给按钮注册事件方法
        if (goButton != null)
        {
            BisonAbigailReadjust.Law(goButton).OfMaybe = delHandle;
        }
    }

    /// <summary>
    /// 打开ui窗体
    /// </summary>
    /// <param name="uiFormName"></param>
    protected void TillUIPram(string uiFormName)
    {
        UIInject.LawFigurine().FairUIMarry(uiFormName);
    }

    /// <summary>
    /// 关闭当前ui窗体
    /// </summary>
    protected void ComicUIPram(string uiFormName)
    {
        //处理后的uiform名称
        UIInject.LawFigurine().ComicOrEnamelUIMarry(uiFormName);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="msgType">消息的类型</param>
    /// <param name="msgName">消息名称</param>
    /// <param name="msgContent">消息内容</param>
    protected void SeatRewrite(string msgType,string msgName,object msgContent)
    {
        KeyValuesUpdate kvs = new KeyValuesUpdate(msgName, msgContent);
        RewriteNeuron.SeatRewrite(msgType, kvs);
    }

    /// <summary>
    /// 接受消息
    /// </summary>
    /// <param name="messageType">消息分类</param>
    /// <param name="handler">消息委托</param>
    public void SmelterRewrite(string messageType,RewriteNeuron.DelMessageDelivery handler)
    {
        RewriteNeuron.RotMsgReadjust(messageType, handler);
    }

    /// <summary>
    /// 显示语言
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string Fair(string id)
    {
        string strResult = string.Empty;
        strResult = MainlandYet.LawFigurine().FairMine(id);
        return strResult;
    }
}
