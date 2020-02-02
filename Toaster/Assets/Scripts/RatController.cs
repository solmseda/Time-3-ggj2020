using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatController : MonoBehaviour
{

    public GameObject rat;
    public float speed;

    private Rigidbody2D ratRb;
    private float changeDirection = -1;
    private float originalPosition;
    private float atualPosition;




    // Start is called before the first frame update
    void Start()
    {
        ratRb = this.GetComponent<Rigidbody2D>();
        originalPosition = this.transform.position.x;
        ratRb.velocity = new Vector2(speed, ratRb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

        atualPosition = this.transform.position.x;
        

        if (changeDirection > 0)
        {
            ratRb.velocity = new Vector2(speed * changeDirection, ratRb.velocity.y);
            this.transform.eulerAngles = new Vector2(0, 180);
        }
            
        else if (changeDirection < 0)
        {
            ratRb.velocity = new Vector2(speed * changeDirection, ratRb.velocity.y);
            this.transform.eulerAngles = new Vector2(0, 0);
        }
            
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("EnemyTurn"))
        {
            changeDirection = changeDirection * -1f;
        }
    }
}
