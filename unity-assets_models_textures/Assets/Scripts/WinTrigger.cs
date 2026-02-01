using UnityEngine;
using TMPro;

public class WinTrigger : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private Timer timerScript;
    private bool hasWon = false;

    void Start()
    {
        // Find the timer text in the scene
        timerText = FindObjectOfType<TextMeshProUGUI>();
        // Find the Timer script
        timerScript = FindObjectOfType<Timer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the Win trigger
        if (other.CompareTag("Player") && !hasWon)
        {
            hasWon = true;
            
            // Stop the timer
            if (timerScript != null)
            {
                timerScript.StopTimer();
            }
            
            // Increase text size and change color to green
            if (timerText != null)
            {
                timerText.fontSize = 60;
                timerText.color = Color.green;
            }
        }
    }
}
