using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update

 
    void Start()
    {
        button = GetComponent<Button>();

        // Add a listener for the button click event
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SceneManager.LoadScene("MainScene");
        ScoreManager.modifyScore(-ScoreManager.gameScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
