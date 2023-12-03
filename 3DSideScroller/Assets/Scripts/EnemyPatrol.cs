using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Enemy Move Controls")]
    public float speed;
    public float rayDistance;
    private bool isMovingRight = true;
    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool isGrounded()
        {
        //print("Grounded");
		return Physics.Raycast(transform.position + transform.up * .75f, -Vector3.up, rayDistance);
        }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance);
        
        if(!isGrounded())
        {
            if(isMovingRight == true)
            {
                //print("ejafnbhjabfehj");
                transform.eulerAngles = new Vector3(0, 90, 0);
                isMovingRight = false;
            }
            else 
            {
                transform.eulerAngles = new Vector3(0,-90,0);
                isMovingRight = true;
            }
        }
    }
}
