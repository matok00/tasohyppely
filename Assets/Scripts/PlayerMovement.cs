using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public BoxCollider2D myBody;
    public CircleCollider2D myFeet;

    private float horizontalMovement = 0f;
    private float moveSpeed = 5f;
    private float jumpForce = 7f;


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

        if (Input.GetButtonDown("Jump") && myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
          myRigidBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

        if (transform.position.y < -30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
