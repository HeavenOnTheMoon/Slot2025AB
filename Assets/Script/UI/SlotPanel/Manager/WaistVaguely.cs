using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaistVaguely : MonoBehaviour
{
    public static WaistVaguely Instance;
[UnityEngine.Serialization.FormerlySerializedAs("SlotSpriteArray")]    public Sprite[] FortDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("NumberSpriteArray")]
    public Sprite[] LittleDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("SlotLuckyCardSpriteArray")]
    public Sprite[] FortVenomHaleDuringGrope;
[UnityEngine.Serialization.FormerlySerializedAs("SlotMiniGameSpriteArray")]
    public Sprite[] FortWineFistDuringGrope;
    private void Awake()
    {
        Instance = this;
    }

    public Sprite LawSinkDuring(int index)
    {
        if (index < FortDuringGrope.Length)
        {
            return FortDuringGrope[index];
        }
        return FortDuringGrope[0];
    }
}
