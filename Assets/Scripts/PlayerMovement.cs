using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public BoxCollider2D myBody;

    // Start is called before the first frame update
    void Start()
    {
       myRigidBody = GetComponent<Rigidbody2D>();
       myBody = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
