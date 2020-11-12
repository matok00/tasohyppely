using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public BoxCollider2D myBody;

    public float horizontalMovement = 0f;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
       myRigidBody = GetComponent<Rigidbody2D>();
       myBody = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        float flipX = Input.GetAxisRaw("Horizontal");

        if (flipX != 0)
        {
          FlipPlayer(flipX);
        }
    }

    public void FlipPlayer(float x)
    {
         transform.localScale = new Vector2(x, transform.localScale.y); 
    }

    private void FixedUpdate()
    {
      myRigidBody.velocity = new Vector2(horizontalMovement * moveSpeed, myRigidBody.velocity.y);
    }
}
