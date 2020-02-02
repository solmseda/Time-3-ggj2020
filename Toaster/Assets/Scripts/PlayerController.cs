using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Transform firePoint;
    public GameObject bullet;
    public bool isDead = false;
    
    private float startSpeed;
    
    public float slowTime = 3f;
    //public float ghostTime = 2f;
    public float timeBetweenShoots = 0.5f;
    public float jumpTime;
    private float jumpTimerCounter;
    public float deathTime;

    public bool isShieldOn = false;

    private Animator anim;

    public float shieldTime;

    private Vector3 playerStartPoint;


    private Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody2D>();
        startSpeed = speed;
        jumpTimerCounter = jumpTime;
        anim = gameObject.GetComponent<Animator>();
        playerStartPoint = this.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(speed, playerRB.velocity.y);
    }

    public void Jump()
    {
        Debug.Log("Jump!!!");
        if(jumpTimerCounter > 0)
        {
            anim.Play("PuloPlayer");
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
            
            jumpTimerCounter -= Time.deltaTime;
        }
        
    }

    public void Shoot()
    {
        anim.Play("Atirando");
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    //public void GhostSkill()
    //{
    //    GetComponent<Rigidbody2D>().gravityScale = 0f;
    //    GetComponent<BoxCollider2D>().isTrigger = true;
    //    StartCoroutine(RemoveGhostSkill());


    //}

    public void DoubleShot()
    {
        anim.Play("Atirando");
        StartCoroutine(ShootBullet());
    }


    public void SlowPlayer()
    {
        StartCoroutine(SlowGameSpeed());
    }

    public void Shield()
    {
        isShieldOn = true;
        StartCoroutine(RemoveShield());
    }

    //IEnumerator RemoveGhostSkill()
    //{
    //    yield return new WaitForSeconds(ghostTime);
    //    GetComponent<Rigidbody2D>().gravityScale = 3f;
    //    GetComponent<BoxCollider2D>().isTrigger = false;
    //}

    IEnumerator ShootBullet()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(timeBetweenShoots);
        Instantiate(bullet, firePoint.position, firePoint.rotation);

    }

    IEnumerator SlowGameSpeed()
    {
        speed = 0.5f;
        yield return new WaitForSeconds(slowTime);
        speed = startSpeed;
    }

    IEnumerator RemoveShield()
    {
        yield return new WaitForSeconds(shieldTime);
        isShieldOn = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isShieldOn)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                Destroy(collision.collider.gameObject);
            }else if (collision.collider.CompareTag("Obstacle"))
            {
                isDead = true;
                RestartGame();
            }
        }
        else
        {
            if (collision.collider.CompareTag("Obstacle") || collision.collider.CompareTag("Cooker"))
            {
                isDead = true;
                RestartGame();
            }
        }
        
    }
    private void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(deathTime);
        this.transform.position = playerStartPoint;
    }

}
