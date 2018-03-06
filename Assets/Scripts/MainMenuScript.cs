using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public string level1;
    public string level2;
    public string level3;
    public string level4;

    public Transform backgroundTransform;

	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        backgroundTransform.position = new Vector3(0, Mathf.Sin(Time.time * .1f) * 10);
	}

    public void loadLevel1()
    {
        SceneManager.LoadSceneAsync(level1);
    }

    public void loadLevel2()
    {
        SceneManager.LoadSceneAsync(level2);
    }

    public void loadLevel3()
    {
        SceneManager.LoadSceneAsync(level3);
    }

    public void loadLevel4()
    {
        SceneManager.LoadSceneAsync(level4);
    }
}
