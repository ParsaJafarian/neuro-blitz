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
    public SceneLoader[] arrayOfSceneLoaders = { myelinLogic, mazeLogic, potLogic, transLogic };


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
            if (arrayOfSceneLoaders != null && arrayOfSceneLoaders.Length > 0)
            {
                int current = UnityEngine.Random.Range(0, arrayOfSceneLoaders.Length);
                arrayOfSceneLoaders[current].SetActivity(true);
                timer = 3;
            }
            else
            {
                Debug.LogError("Random or arrayOfSceneLoaders is null or empty.");
            }
        }
    }
}
