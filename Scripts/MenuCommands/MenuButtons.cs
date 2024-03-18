using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void PlayGame()
    {
        Debug.Log("Load scene 1");
        if (StateNameController.GridWidth == 0 || StateNameController.GridHeight == 0)
        {
            StateNameController.GridWidth = 4;
            StateNameController.GridHeight = 4;
        }
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Exit game");
        Application.Quit();
    }
}
