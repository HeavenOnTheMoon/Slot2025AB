/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISaleYet : MonoBehaviour
{
    private static UISaleYet _Figurine= null;
    //ui根节点对象
    private GameObject _OxGeniusLark= null;
    //ui脚本节点对象
    private Transform _TraUIUnaidedBust= null;
    //顶层面板
    private GameObject _OxToCoach;
    //遮罩面板
    private GameObject _OxSaleCoach;
    //ui摄像机
    private Camera _UIFollow;
    //ui摄像机原始的层深
    private float _MusicianUIFollowSolar;
    //获取实例
    public static UISaleYet LawFigurine()
    {
        if (_Figurine == null)
        {
            _Figurine = new GameObject("_UIMaskMgr").AddComponent<UISaleYet>();
        }
        return _Figurine;
    }
    private void Awake()
    {
        _OxGeniusLark = GameObject.FindGameObjectWithTag(SysAdjoin.SYS_TAG_CANVAS);
        _TraUIUnaidedBust = LedgeReport.LaceSacKneelBust(_OxGeniusLark, SysAdjoin.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        LedgeReport.RotKneelBustMyObsessBust(_TraUIUnaidedBust, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _OxToCoach = _OxGeniusLark;
        _OxSaleCoach = LedgeReport.LaceSacKneelBust(_OxGeniusLark, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UIFollow = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UIFollow != null)
        {
            //得到ui相机原始的层深
            _MusicianUIFollowSolar = _UIFollow.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void MadSaleSorrow(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _OxToCoach.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _OxSaleCoach.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _OxSaleCoach.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _OxSaleCoach.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _OxSaleCoach.GetComponent<Image>().color = newColor2;
                RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_SorrowTill);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _OxSaleCoach.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _OxSaleCoach.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_OxSaleCoach.activeInHierarchy)
                {
                    _OxSaleCoach.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _OxSaleCoach.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UIFollow != null)
        {
            _UIFollow.depth = _UIFollow.depth + 100;
        }
    }
    public void FundSaleSorrow()
    {
        if (UIInject.LawFigurine().ScatUIMarry.Count > 0 || UIInject.LawFigurine().LawPredatePramGlobe().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_OxSaleCoach.GetComponent<Image>().color.r, _OxSaleCoach.GetComponent<Image>().color.g, _OxSaleCoach.GetComponent<Image>().color.b,0);
        _OxSaleCoach.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void WeightSaleSorrow()
    {
        if (UIInject.LawFigurine().ScatUIMarry.Count > 0 || UIInject.LawFigurine().LawPredatePramGlobe().Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _OxToCoach.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_OxSaleCoach.activeInHierarchy)
        {
            _OxSaleCoach.SetActive(false);
            RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_SorrowComic);
        }
        //恢复当前ui摄像机的层深
        if (_UIFollow != null)
        {
            _UIFollow.depth = _MusicianUIFollowSolar;
        }
    }
}
