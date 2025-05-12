using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheyObserve : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("time")]    public float Luck= 1;
    void Start()
    {
        Invoke(nameof(Observe), Luck);
    }
    void Observe()
    {
        Destroy(gameObject);
    }

}
