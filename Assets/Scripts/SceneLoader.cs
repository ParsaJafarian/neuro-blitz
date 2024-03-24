using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName = "";
    public float timer = 45;
    public bool isActive = false;
    public TextMeshProUGUI textMeshPro;
    public SpriteRenderer spriteRenderer;
    public Vector3 scaleChange = new Vector3(10f, 10f, 0);

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
        if (isActive == true)
        {
            spriteRenderer.enabled = true;
            textMeshPro.enabled = true;
            timer -= Time.deltaTime;
            textMeshPro.text = timer.ToString();
            spriteRenderer.transform.localScale += scaleChange;
            if (spriteRenderer.transform.localScale.y < 100f || spriteRenderer.transform.localScale.y > 100f)
            {
                scaleChange = -scaleChange;
            }

        }

    }

}
