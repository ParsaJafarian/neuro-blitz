using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static SceneLoader myelinLogic;
    public static SceneLoader mazeLogic;
    public static SceneLoader potLogic;
    public static SceneLoader transLogic;
    public static float timer;
    public SceneLoader[] arrayOfSceneLoaders = { myelinLogic, mazeLogic, potLogic, transLogic};
    System.Random random = new System.Random();


    void Start()
    {
        timer = 3;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (random != null && arrayOfSceneLoaders != null && arrayOfSceneLoaders.Length > 0)
            {
                int current = random.Next(0, arrayOfSceneLoaders.Length);
                arrayOfSceneLoaders[current].setActivity(true);
                timer = 60;
            }
            else
            {
                Debug.LogError("Random or arrayOfSceneLoaders is null or empty.");
            }
        }
    }
}
