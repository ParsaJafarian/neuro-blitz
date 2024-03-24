using UnityEngine;
using UnityEngine.SceneManagement;

public class Signals : MonoBehaviour
{
    Signal[] signals;
    public float timer = 45;
    public int requiredSignals = 10;
    private int count = 0;

    void Start()
    {
        signals = gameObject.GetComponentsInChildren<Signal>();
        for (int i = 0; i < signals.Length; i++)
        {
            signals[i] = signals[i].GetComponent<Signal>();
            signals[i].SetActive(false);
        }
        ActivateRandomSignal();
    }

    void Update()
    {
        // Check if any signal is active. If one is active, return
        foreach (Signal signal in signals)
            if (signal != null && signal.IsActive()) return;

        // If no signal is active, set a random signal to active and increment the count
        ActivateRandomSignal();
        count++;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("You ran out of time!");
            SceneManager.LoadScene("MainScene");
        }

        // Check if the required number of signals have been activated
        if (count >= requiredSignals)
        {
            Debug.Log("You won!");
            SceneManager.LoadScene("MainScene");
        }
    }

    void ActivateRandomSignal()
    {
        if (signals.Length == 0)
        {
            Debug.LogError("No signals found. Ensure there are GameObjects with the 'Signal' tag in the scene.");
            return;
        }

        int randomIndex = Random.Range(0, signals.Length);
        if (signals[randomIndex] != null) // Ensure the selected signal is not null
            signals[randomIndex].SetActive(true);
        else
            Debug.LogError("Attempted to activate a null signal at index: " + randomIndex);
    }
}
