using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector3(1f, playerRB.velocity.y, playerRB.velocity.z) * speed;
    }
}
