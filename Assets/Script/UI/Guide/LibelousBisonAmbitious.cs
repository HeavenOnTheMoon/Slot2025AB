using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �¼���͸
/// </summary>
public class LibelousBisonAmbitious : MonoBehaviour, ICanvasRaycastFilter
{
    private Image AshoreSlice;
    public void MadKettleSlice(Image target)
    {
        AshoreSlice = target;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (AshoreSlice == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(AshoreSlice.rectTransform, sp, eventCamera);
    }
}