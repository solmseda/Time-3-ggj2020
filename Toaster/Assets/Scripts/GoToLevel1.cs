using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GotoLevel1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("Level1");
        }
        
    }

    public IEnumerator GotoLevel1()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("Level1");

    }
}
