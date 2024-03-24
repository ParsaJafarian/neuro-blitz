using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using T = TotalIons;

public class GameScript : MonoBehaviour
{
    public int potassiumNumber;
    public int sodiumNumber;
    public GameObject potassium;
    public GameObject sodium;
    List<GameObject> potassiumList = new List<GameObject>();
    List<GameObject> sodiumList = new List<GameObject>();
    bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < potassiumNumber; i++)
        {
            GameObject currentPotassium = Instantiate(potassium);
            potassiumList.Add(currentPotassium);
            currentPotassium.transform.position = new Vector3(currentPotassium.transform.position.x + Random.Range(0.5f,1)*i*4.0f, currentPotassium.transform.position.y + Random.Range(0f, 1.15f), 0);
        }
        for (int i = 0; i < sodiumNumber; i++)
        {
            GameObject currentSodium = Instantiate(sodium);
            sodiumList.Add(currentSodium);
            currentSodium.transform.position = new Vector3(currentSodium.transform.position.x + Random.Range(0.5f, 1) * i * 3.0f, currentSodium.transform.position.y + Random.Range(0f, -1.15f), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TotalIons.totalIons == 0 && !finished)
        {
            for(int j =0;j < potassiumList.Count;j++)
            {
                GameObject currentPotassium = potassiumList[j];
                currentPotassium.transform.position = new Vector3(sodium.transform.position.x + Random.Range(0.5f, 1) * j * 4.0f, sodium.transform.position.y + Random.Range(0f, -1.15f), 0);
            }
            for (int j = 0; j < sodiumList.Count; j++)
            {
                GameObject currentSodium = sodiumList[j];
                currentSodium.transform.position = new Vector3(sodium.transform.position.x + Random.Range(0.5f, 1) * j * 3.0f, potassium.transform.position.y + Random.Range(0f, 1.15f), 0);
            }
            finished = true;
            SceneManager.LoadScene("MainScene");
        }
    }
}
