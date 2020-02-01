﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public bool gameIsPaused;
    public GameObject PauseMenuUI;
    public GameObject GameOverUI;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        PauseMenuUI.SetActive(false);
        GameOverUI.SetActive(false);
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!gameIsPaused){
                PauseMenuUI.SetActive(true);
                Debug.Log("O jogo foi pausado.");
                gameIsPaused = true;
                Pause();
            }
            else{
                PauseMenuUI.SetActive(false);
                Debug.Log("O jogo foi despausado.");
                gameIsPaused = false;
                Resume();
            }
        }

        if (player.isDead)
        {
            GameOver();
        }
    }

    public void Pause(){
        Time.timeScale = 0f;
    }

    public void Resume(){
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
    }

    public void QuitGame(){
        Application.Quit();
    }

}

