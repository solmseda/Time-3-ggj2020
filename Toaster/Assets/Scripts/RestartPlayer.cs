using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPlayer : MonoBehaviour
{

    public PlayerController playerController;

    private Vector3 playerStartPoint;

    public float deathTime;

    // Start is called before the first frame update
    void Start()
    {
        playerStartPoint = playerController.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" && collision.gameObject.tag == "Enemy" && playerController.isShieldOn == false)
        {

            RestartGame();
        }
    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(deathTime);
        playerController.transform.position = playerStartPoint;
    }
}
