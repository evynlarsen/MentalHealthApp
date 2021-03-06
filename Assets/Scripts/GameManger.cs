﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

    private static bool GameManagerExists;
    private bool paused = false;
    private void Start()
    {
        if (!GameManagerExists)
        {
            GameManagerExists = true;
            DontDestroyOnLoad(this.gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void changeScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void PauseUnPause()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            GameObject [] Controllers = GameObject.FindGameObjectsWithTag("GameController");
            foreach(GameObject Controller in Controllers )
            {
                Controller.GetComponent<Button>().enabled = false;
            }
            GameObject Audio = GameObject.FindGameObjectWithTag("AudioSource");
            Audio.GetComponent<AudioSource>().Pause();
            paused = true;
        }
        else
        {
            Time.timeScale = 1;
            GameObject[] Controllers = GameObject.FindGameObjectsWithTag("GameController");
            foreach (GameObject Controller in Controllers)
            {
                Controller.GetComponent<Button>().enabled = true;
            }
            GameObject Audio = GameObject.FindGameObjectWithTag("AudioSource");
            Audio.GetComponent<AudioSource>().Play();
            paused = false;
        }
    }
   

    public void Quit()
    {
        Application.Quit();
    }
    
}
