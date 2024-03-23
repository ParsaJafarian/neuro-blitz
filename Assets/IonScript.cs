using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U = Utils;

public class IonScript : MonoBehaviour
{
    private Vector3 _dragOffset;
    private bool isDragging;
    public bool isPotassium;
    public BoxCollider2D sodiumCollider;
    public BoxCollider2D potassiumCollider;
    public CircleCollider2D ionCollider;
    public Rigidbody2D ionBody;
    bool inPosition = false;

    public void OnMouseDown()
    {
        _dragOffset = transform.position - GetMousePos();
        isDragging = true;
    }
    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void OnMouseDrag()
    {
        if(!inPosition)
            transform.position = GetMousePos() + _dragOffset;
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if ((collision.gameObject.name == "SodiumCollider" && !isPotassium && !isDragging))
        {
            ionBody.bodyType = RigidbodyType2D.Static;
            transform.position = sodiumCollider.transform.position;
            inPosition = true;
            
        } else if (collision.gameObject.name == "PotassiumCollider" && isPotassium)
        {
            ionBody.bodyType = RigidbodyType2D.Static;
            transform.position = potassiumCollider.transform.position;
            inPosition = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!inPosition)
        {
            ionBody.bodyType = RigidbodyType2D.Dynamic;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}