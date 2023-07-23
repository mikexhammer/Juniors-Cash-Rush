using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    [Header("Level Boundary")]
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    private float internalLeft;
    private float internalRight;

    void Start()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
