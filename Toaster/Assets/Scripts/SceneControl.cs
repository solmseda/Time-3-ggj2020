using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public bool gameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject GameOverUI;
    public GameObject HandUI;
    public PlayerController player;
    public GameObject Player;
    public
    
    // Start is called before the first frame update
    void Start()
    {
        PauseMenuUI.SetActive(false);
        GameOverUI.SetActive(false);
        HandUI.SetActive(true);
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!gameIsPaused){
                PauseMenuUI.SetActive(true);
                HandUI.SetActive(false);
                Debug.Log("O jogo foi pausado.");
                gameIsPaused = true;
                Pause();
            }
            else{
                PauseMenuUI.SetActive(false);
                HandUI.SetActive(true);
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
        HandUI.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

}

