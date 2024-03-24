using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public TextMeshPro textHere;
    public static int gameScore;

    public static void modifyScore(int a) {
        gameScore += a;
    }
    void Start()
    {
        // Ensure it doesn't get destroyed when loading new scenes
        textHere.GetComponent<TMP_Text>().SetText(0.0.ToString());
        DontDestroyOnLoad(textHere);
    }

    // Update is called once per frame
    void Update()
    {
        textHere.GetComponent<TMP_Text>().SetText(gameScore.ToString());
    }
}
