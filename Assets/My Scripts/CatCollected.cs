using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CatCollected : MonoBehaviour
{
      private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

          if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
            // Add to counter
            CatCollector.Instance.AddCat();

            // Remove cat
            Destroy(gameObject, 1f);
        }
    }
}
