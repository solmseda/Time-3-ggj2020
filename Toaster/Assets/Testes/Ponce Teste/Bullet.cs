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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(this.gameObject);
    }

}
