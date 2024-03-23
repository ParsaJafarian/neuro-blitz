using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName = "";
    public float timer = 45;
    public bool isActive = false;
    private void OnMouseDown()
    {
        Debug.Log("Alert Clicked");
        // Load the scene as a popup
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void Update()
    {
        if (isActive == true) 
            timer -= Time.deltaTime;
    }

}
