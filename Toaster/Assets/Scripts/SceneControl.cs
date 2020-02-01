﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public bool gameIsPaused;
    
    // Start is called before the first frame update
    void Start()
    {
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!gameIsPaused){
                Debug.Log("O jogo foi pausado.");
                gameIsPaused = true;
                Pause();
            }
            else{
                Debug.Log("O jogo foi despausado.");
                gameIsPaused = false;   
                Resume();
            }
        }
    }

    public void Pause(){
        Time.timeScale = 0f;
    }

    public void Resume(){
        Time.timeScale = 1f;
    }

    public void QuitGame(){
        Application.Quit();
    }

}
