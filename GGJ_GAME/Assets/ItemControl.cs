using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemControl : MonoBehaviour
{
    public AudioClip Sound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            
            this.gameObject.SetActive(false);
            Destroy(gameObject);
            source = GetComponent<AudioSource>();
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(Sound, vol);
        }
    }
}
