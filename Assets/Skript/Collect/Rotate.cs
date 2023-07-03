using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
 
    [SerializeField] private float rotateSpeed = 1;
    
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
