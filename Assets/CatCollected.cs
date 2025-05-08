using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCollected : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add to counter
            CatCollector.Instance.AddCat();

            // Remove cat
            Destroy(gameObject);
        }
    }
}
