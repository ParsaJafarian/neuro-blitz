using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U = Utils;

public class IonScript : MonoBehaviour
{
    bool isDragging;
    public BoxCollider2D sodiumCollider;
    public BoxCollider2D potassiumCollider;

    public void OnMouseDown(){
        isDragging = true;
    }

    public void OnMouseUp(){
        isDragging = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
        
        
    }
}
