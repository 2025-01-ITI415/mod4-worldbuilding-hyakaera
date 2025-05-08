using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CatCollector : MonoBehaviour
{
    public static CatCollector Instance;

    public TextMeshProUGUI catCountText;
    private int catCount = 0;

    private void Awake()
{
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject); // Keeps it alive across scenes
    }
    else
    {
        Destroy(gameObject);
    }

    UpdateUI();
}

    public void AddCat()
    {
        catCount++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (catCountText != null)
        {
            catCountText.text = "Cats Collected: " + catCount;
        }
    }
}
