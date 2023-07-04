using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectControl : MonoBehaviour
{
    public static int goldCounter = 0;
    public GameObject goldText;
    void Update()
    {
        goldText.GetComponent<Text>().text = "" + goldCounter;
    }
}
