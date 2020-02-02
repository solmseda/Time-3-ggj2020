using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bulletRB;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB.velocity = this.transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.collider.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }

}
