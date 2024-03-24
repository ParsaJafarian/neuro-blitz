using UnityEngine;

public class Signal : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isActive;

    public void OnMouseDown()
    {
        Debug.Log("Signal clicked: " + name + " is now " + (isActive ? "active" : "inactive"));
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }

    public bool IsActive()
    {
        return isActive;
    }

    public void SetActive(bool active)
    {
        isActive = active;
        gameObject.SetActive(isActive);
    }
}
