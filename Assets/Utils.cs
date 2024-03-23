using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    // Linear interpolation method
    public static float lerp(float A, float B, float t)
    {
        return A + (B - A) * t;
    }
}
