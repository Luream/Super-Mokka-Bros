using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {
    public GameObject menu;
    bool isPaused;
	// Use this for initialization
	void Start () {
        isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            setPause();
        }
	}

    public void setPause()
    {
        if (isPaused)
        {
            menu.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            menu.SetActive(true);
            Time.timeScale = 0;
        }
        isPaused = !isPaused;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
        Time.timeScale = 1;
    }
}
