using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName = "";
    public float timer = 60;
    public bool isActive = false;
    public TextMeshProUGUI textMeshPro;
    public SpriteRenderer spriteRenderer;

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
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);

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
            timer = 60;
        }

    }

}
