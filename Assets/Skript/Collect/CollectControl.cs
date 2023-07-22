using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectControl : MonoBehaviour
{
    public static int goldCounter = 0;
    public GameObject goldText;

    private void Start()
    {
        goldCounter = 0;
    }

    void Update()
    {
        goldText.GetComponent<Text>().text = "" + goldCounter;
    }
}
