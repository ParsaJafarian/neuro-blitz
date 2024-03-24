using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject obj1;
    public string sceneName = "";
    public float timer = 3;
    public bool isActive = false;
    public TextMeshProUGUI textMeshPro;
    public SpriteRenderer spriteRenderer;
    public Camera MainCamera;
    public void Start() {
        textMeshPro.enabled = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        // Check if SpriteRenderer component is found
        if (spriteRenderer == null)
            Debug.LogError("SpriteRenderer component not found!");
    }
    private void OnMouseDown()
    {
        if(obj1.name == "TransmitterAlert" || obj1.name == "MyelinAlert")
        {
            ScoreManager.modifyScore(100);
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
        else
        {
            // Load the scene as a popup
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        Debug.Log("Alert Clicked");
        

    }
    public void setActivity(Boolean activity) {
        isActive = activity;
    }

    public void Update()
    {
        if (isActive && timer >= 0)
        {
            spriteRenderer.enabled = true;
            textMeshPro.enabled = true;
            timer -= Time.deltaTime;
            textMeshPro.text = timer.ToString();
        }
        else if (isActive) 
            SceneManager.LoadScene("MainMenu");
        else
        {
            spriteRenderer.enabled = false;
            textMeshPro.enabled = false;
            timer = 3;
        }

    }

}
