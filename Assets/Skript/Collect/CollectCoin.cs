using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectControl.goldCounter += 1;
        this.gameObject.SetActive(false);
    }
}
