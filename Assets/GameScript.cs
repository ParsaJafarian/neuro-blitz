using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public int potassiumNumber;
    public int sodiumNumber;
    public GameObject potassium;
    public GameObject sodium;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < potassiumNumber; i++)
        {
            GameObject currentPotassium = Instantiate(potassium);
            currentPotassium.transform.position = new Vector3(currentPotassium.transform.position.x + Random.Range(0.5f,1)*i*4.75f, currentPotassium.transform.position.y + Random.Range(0f, 1.15f), 0);
        }
        for (int i = 0; i < sodiumNumber; i++)
        {
            GameObject currentSodium = Instantiate(sodium);
            currentSodium.transform.position = new Vector3(currentSodium.transform.position.x + Random.Range(0.5f, 1) * i * 3.5f, currentSodium.transform.position.y + Random.Range(0f, -1.15f), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
