using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EndSceneManager : MonoBehaviour
{
    public TextMeshProUGUI finalText;
    void Start()
    {
        int finalCount = CatCollector.Instance != null ? GetCatCountSafe() : 0;
        finalText.text = $"You collected {finalCount} cats!";
    }

    private int GetCatCountSafe()
    {
        // Access the private field using a method, or make it public if you prefer
        return typeof(CatCollector)
            .GetField("catCount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            .GetValue(CatCollector.Instance) is int count ? count : 0;
    }
}
