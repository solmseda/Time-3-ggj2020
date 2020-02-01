using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Transform firePoint;
    public GameObject bullet;

    private Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(speed, playerRB.velocity.y);
    }

    public void Jump()
    {
        Debug.Log("Jump!!!");
        playerRB.velocity = new Vector2(playerRB.velocity.x,jumpForce);
    }

    public void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
