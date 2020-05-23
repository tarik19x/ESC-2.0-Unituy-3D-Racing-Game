﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay=1f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game OVer");
            gameHasEnded = true;
            Invoke("Restart",restartDelay);
            
        }
    }

    void Restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
