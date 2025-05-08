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
        Instance = this;
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
