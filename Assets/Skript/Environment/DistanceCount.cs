using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DistanceCount : MonoBehaviour
{

    [FormerlySerializedAs("distanceSpeed")]
    [Header("Change Counting Speed")]
    [SerializeField][Tooltip("Change Speed so it fits to the speed of the player")] public float stepDistance = 0.25f;
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
        yield return new WaitForSeconds(stepDistance);
        distanceCounter += 1;
        distanceText.GetComponent<UnityEngine.UI.Text>().text = "" + distanceCounter;
        isRunning = false;
    }
}
