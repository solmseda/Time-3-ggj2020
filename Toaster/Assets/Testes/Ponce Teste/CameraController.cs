using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 lastPlayerPos;
    private float distanceToMove;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = player.transform.position.x - lastPlayerPos.x;

        this.transform.position = new Vector3(this.transform.position.x + distanceToMove, this.transform.position.y, this.transform.position.z);

        lastPlayerPos = player.transform.position;

    }
}
