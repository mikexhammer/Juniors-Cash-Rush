using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCount : MonoBehaviour
{

    [Header("Change Counting Speed")]
    [SerializeField][Tooltip("Change Speed so it fits to the speed of the player")] public float distanceSpeed = 0.25f;
    public GameObject distanceText; 
    private int distanceCounter;
    public static bool isRunning;
    
    void Update()
    {
        if (!isRunning)
        {
            isRunning = true;
            StartCoroutine(DistanceCounter());
        }
    }
    
    IEnumerator DistanceCounter()
    {
        yield return new WaitForSeconds(distanceSpeed);
        distanceCounter += 1;
        distanceText.GetComponent<UnityEngine.UI.Text>().text = "" + distanceCounter;
        isRunning = false;
    }
}
