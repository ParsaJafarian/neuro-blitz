using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Electron : MonoBehaviour
{

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Use axis of the background to move the electron
        float dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float dy = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(dx * Vector3.right, Space.World);
        transform.Translate(dy * Vector3.up, Space.World);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Maze completed!");
        //close the scene
        gameObject.SetActive(false);
        SceneManager.LoadScene("MainScene");
        ScoreManager.modifyScore(500);
    }
}
