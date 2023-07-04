using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Player Object")]
    [SerializeField] private GameObject player;
    [Header("Player Move")]
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private float leftRightSpeed = 4.0f;
    [Header("Jump height and time")]
    [SerializeField] private float jumpHeigt = 5.0f;
    [SerializeField] [Tooltip("This will the airtime")] private float jumpTime = 1f;
    private bool isGrounded = true;
    private bool isFalling = false;
    
    
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
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            player.GetComponent<Animator>().Play("Jump");
            StartCoroutine(Jumping());
        }
        
        if (!isGrounded)
        {
            if (!isFalling)
            {
                transform.Translate(Time.deltaTime * jumpHeigt * Vector3.up, Space.World);
            }
            else
            {
                transform.Translate(Time.deltaTime * -jumpHeigt * Vector3.up, Space.World);
            }
        }
    }

    IEnumerator Jumping()
    {
        yield return new WaitForSeconds(jumpTime/2);
        isFalling = true;
        yield return new WaitForSeconds(jumpTime/2);
        isGrounded = true;
        isFalling = false;
    }
}
