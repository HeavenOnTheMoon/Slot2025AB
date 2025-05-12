using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>  </summary>
public class Click_Item : MonoBehaviour, IPointerDownHandler
{
    public Image ItemIcon;
    [HideInInspector] public int X;
    [HideInInspector] public int Y;
    [HideInInspector] public ClickItemType Type;
    Click_GamePanel _GamePanel;

    public void Init(int X, int Y, ClickItemType Type, Click_GamePanel _GamePanel)
    {
        this.X = X;
        this.Y = Y;
        this.Type = Type;
        transform.name = $"[{X} , {Y}]";
        this._GamePanel = _GamePanel;
        ItemIcon.sprite = _GamePanel.ItemSprites[(int)Type];
    }

    public void ResetXY(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _GamePanel.Choose(this);
    }
}
