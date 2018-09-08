using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.EventSystems;

public class LoadNextScene : MonoBehaviour
{
    public float sceneTime;
    public void Start()
    { 
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        Debug.Log("Moving from scene"+ SceneManager.GetActiveScene().name+"to next scene");
        // loads the scene next in the scenes in build
        yield return new WaitForSeconds(sceneTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(1);
    }
}
