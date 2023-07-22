using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class StumbleCollisionDetection: MonoBehaviour
{
    [Header("Set Player, FallDown, CrashSound and MainCamera")]
    public GameObject player;
    public GameObject stumbleAnimation;
    public GameObject crashSound;
    public GameObject mainCamera; 
    public GameObject levelControl; 

    private void OnTriggerEnter(Collider other)
    {
        stumbleAnimation.GetComponent<Animator>().Play("Stumble Backwards");
        // In case the player touches an obsticle while is jumping, bring him back to the ground
        while (player.transform.position.y > 1.75f)
        {
            player.transform.Translate(Time.deltaTime * -0.1f * Vector3.up, Space.World);
        }
        // Cut off the PlayerMovement script on collision with an obstacle
        player.GetComponent<PlayerMove>().enabled = false;
        crashSound.GetComponent<AudioSource>().Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<DistanceCount>().enabled = false;

        DistanceCount.isRunning = false;
        // Wait for 2 seconds before loading the GameOver scene
        StartCoroutine(LoadGameOver());
    }
    
    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}