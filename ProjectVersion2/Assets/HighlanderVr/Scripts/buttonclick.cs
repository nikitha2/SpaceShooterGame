using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonclick : MonoBehaviour
{
    public GameObject startUI, restartUI;
    public string loadScene;

    public void StartPuzzle()
    {
        // Disable the start UI.
        startUI.SetActive(false);
    }

    // Reset the puzzle sequence.
    public void ResetPuzzle()
    {
        // Disable the restart UI.
        restartUI.SetActive(false);
        SceneManager.LoadScene(loadScene);
    }
}

