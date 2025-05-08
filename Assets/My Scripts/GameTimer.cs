using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float timeLeft = 60f; // Game duration in seconds
    public TextMeshProUGUI TimerText;
    public string gameOverScene = "GameOverScene"; // Or handle it another way

    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;
        timeLeft = Mathf.Max(timeLeft, 0);

        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        TimerText.text = $"Time: {minutes:00}:{seconds:00}";

        if (timeLeft <= 0 && !gameEnded)
        {
            EndGame();
        }
    }


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void EndGame()
    {
        gameEnded = true;
        // Option 1: Load another scene
        SceneManager.LoadScene(gameOverScene);
    }
}
