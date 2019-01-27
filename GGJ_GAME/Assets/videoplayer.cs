using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoplayer : MonoBehaviour
{
    public GameObject VideoPlayer;
    public int timeToStop;

    void Start()
    {
        VideoPlayer.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            VideoPlayer.SetActive(true);
            Destroy(VideoPlayer, timeToStop);
        }
    }
}
