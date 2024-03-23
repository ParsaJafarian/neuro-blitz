using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MazeLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Load a maze from mazes folder using random number
        string[] mazePaths = Directory.GetFiles(Application.dataPath + "/Resources/Mazes", "*.png");
        int mazeIndex = Random.Range(0, mazePaths.Length);

        // Extract just the name of the maze without the path or file extension
        string mazeNameWithExtension = Path.GetFileName(mazePaths[mazeIndex]);
        string mazeName = Path.GetFileNameWithoutExtension(mazeNameWithExtension);
        Debug.Log("Loading maze: " + mazeName);

        // Create sprite renderer if it doesn't exist
        if (gameObject.GetComponent<SpriteRenderer>() == null)
            gameObject.AddComponent<SpriteRenderer>();

        // Load and assign the sprite
        // Note: 'Mazes/' is prefixed because 'mazeName' should be a path relative to any 'Resources' folder
        Sprite mazeSprite = Resources.Load<Sprite>("Mazes/" + mazeName);
        gameObject.GetComponent<SpriteRenderer>().sprite = mazeSprite;

        if (mazeSprite == null)
            Debug.LogError("Failed to load the maze sprite. Make sure the maze is located at 'Assets/Resources/Mazes' and the path is correct.");
        
    }

}
