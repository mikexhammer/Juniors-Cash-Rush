using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CollisionDetection : MonoBehaviour
{
    [Header("Set Player, FallDown, CrashSound and MainCamera")]
    public GameObject player;
    public GameObject fallDown;
    public GameObject crashSound;
    public GameObject mainCamera; 
    public GameObject levelControl; 

    private void OnTriggerEnter(Collider other)
    {
        // Cut off the PlayerMovement script on collision with an obstacle
        fallDown.GetComponent<Animator>().Play("Stumble Backwards");
        while (player.transform.position.y > 1.25f)
        {
            player.transform.Translate(Time.deltaTime * -0.1f * Vector3.up, Space.World);
        }
        player.GetComponent<PlayerMove>().enabled = false;
        crashSound.GetComponent<AudioSource>().Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<DistanceCount>().enabled = false;

        DistanceCount.isRunning = false;
    }
}