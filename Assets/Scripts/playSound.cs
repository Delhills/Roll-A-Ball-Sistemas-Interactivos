using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

/*
            public AudioSource audioSource;
            
            audioSource.Play();
 */

public class playSound : MonoBehaviour
{

    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(audioSource==false);
        //Debug.Log("Ole!!!");
    }

}
