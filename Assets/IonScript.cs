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
    bool done = false;

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
        transform.position = GetMousePos() + _dragOffset;
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("entered");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        ionBody.bodyType = RigidbodyType2D.Static;
        if (collision.gameObject.name == "SodiumCollider" && !isPotassium && !isDragging)
        {
            done = true;
            print("done");
        }
        else if (collision.gameObject.name == "PotassiumCollider" && isPotassium)
        {

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!done)
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
        print(ionBody.bodyType);
    }
}
