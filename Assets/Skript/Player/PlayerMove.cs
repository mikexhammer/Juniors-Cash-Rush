using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Player Move")]
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private float leftRightSpeed = 4.0f;
    
    void Update()
    {
        transform.Translate( Time.deltaTime * moveSpeed * Vector3.forward, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Time.deltaTime * leftRightSpeed * Vector3.left, Space.World);
            }
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Time.deltaTime * leftRightSpeed * -1 * Vector3.left, Space.World);
            }
            
        }
       
    }
}
