﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        int currentSceneIndex = 0;
        SceneManager.LoadScene(currentSceneIndex);
    }

    /*public void QuitGame()
    {
        Application.Quit();
    }
    */

}

