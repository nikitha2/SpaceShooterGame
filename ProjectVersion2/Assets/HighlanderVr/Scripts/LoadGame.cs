using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

    public void start()
    {
        LoadGameScene();
    }
        
    public void LoadGameScene () {
       // yield return new WaitForSeconds(sceneTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
