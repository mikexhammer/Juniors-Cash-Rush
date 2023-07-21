using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Please set the 'Directional Light' as sun")]
    [SerializeField] private GameObject sun;

    [SerializeField] private float rotateSpeed = 20; 
    // Update is called once per frame
    void Update()
    {
       sun.transform.Rotate(rotateSpeed * Time.deltaTime * -1 * Vector3.right);
    }
}
