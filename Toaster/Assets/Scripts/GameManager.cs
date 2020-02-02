using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Skills[] skills;
    public PlayerController playerController;

    public Image qSkill;
    public Image wSkill;
    public Image eSkill;
    public Image rSkill;

    private int index;
    private Sprite newSkill;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Q)) {
            CastSkill (qSkill);

            GenerateNewSkill (qSkill);
        }

        if (Input.GetKeyDown (KeyCode.W)) {
            CastSkill (wSkill);

            GenerateNewSkill (wSkill);
        }

        if (Input.GetKeyDown (KeyCode.E)) {
            CastSkill (eSkill);

            GenerateNewSkill (eSkill);
        }

        if (Input.GetKeyDown (KeyCode.R)) {
            CastSkill (rSkill);

            GenerateNewSkill (rSkill);
        }
    }

    private void CastSkill (Image image) {
        if (image.name == "Jump") {
            playerController.Jump ();
        }
        if (image.name == "Slow_time") {
            playerController.SlowPlayer ();
        }
        if (image.name == "Shock") {
            playerController.Shoot ();
        }
        // if (image.name == "Jump") {
        //     playerController.Jump ();
        // }
        // if (image.name == "Jump") {
        //     playerController.Jump ();
        // }
    }

    private void GenerateNewSkill (Image image) {
        index = Random.Range (0, skills.Length);
        Debug.Log (index);
        newSkill = skills[index].sprite;
        image.sprite = newSkill;
        image.name = newSkill.name;
    }
}