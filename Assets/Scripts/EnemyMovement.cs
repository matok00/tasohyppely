using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeed = 2f;
    public Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight())
        {
            myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, myRigidBody.velocity.y);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-1 * transform.localScale.x, transform.localScale.y);
    }
    public bool isFacingRight()
    {
        return transform.localScale.x > 0;
    }
}
