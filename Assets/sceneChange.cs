﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChange : MonoBehaviour {

    public void changeScene(string sceneToChangeTo)
    {
        // currentScene = sceneToChangeTo;
        SceneManager.LoadScene(sceneToChangeTo);
    }

}
