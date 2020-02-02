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
    

    private int index;
    private Sprite newSkill;

    // Start is called before the first frame update
    void Start () {
        //for (int i = 0; i < skills.Length; i++) {
        //    index = Random.Range (0, skills.Length);
        //    Debug.Log (index);
        ////    // qSkill.sprite = skills[index].sprite;
        ////    // qSkill.name = skills[index].name;

        ////    // wSkill.sprite = skills[index].sprite;
        ////    // wSkill.name = skills[index].name;

        ////    // eSkill.sprite = skills[index].sprite;
        ////    // eSkill.name = skills[index].name;

        ////    // rSkill.sprite = skills[index].sprite;
        ////    // rSkill.name = skills[index].name;
        ////}
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
        if (image.name == "2X_Shock") {
            playerController.DoubleShot ();
        }
        if (image.name == "Ghost") {
            playerController.GhostSkill ();
        }
    }

    private void GenerateNewSkill (Image image) {
        index = Random.Range (0, skills.Length);
        Debug.Log (index);
        newSkill = skills[index].sprite;
        image.sprite = newSkill;
        image.name = newSkill.name;

    }

    private void DeleteSkill (Image image) {
        if (Input.GetButtonDown ("Fire2")) {
            index = Random.Range (0, skills.Length);
            Debug.Log (index);
            newSkill = skills[index].sprite;
            image.sprite = newSkill;
            image.name = newSkill.name;
        }
    }
}