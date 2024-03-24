using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
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
        {
            Debug.LogError("SpriteRenderer component not found!");
        }
    }
    private void OnMouseDown()
    {
        Debug.Log("Alert Clicked");
        // Load the scene as a popup
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

    }
    public void setActivity(Boolean activity) {
        isActive = activity;
    }

    public void Update()
    {
        if ((isActive == true) & (timer >= 0))
        {
            spriteRenderer.enabled = true;
            textMeshPro.enabled = true;
            timer -= Time.deltaTime;
            textMeshPro.text = timer.ToString();
        }
        else if (isActive == true) {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            spriteRenderer.enabled = false;
            textMeshPro.enabled = false;
            timer = 3;
        }

    }

}
