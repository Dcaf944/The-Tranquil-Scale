using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public GameObject objectToSpawn;

    public AudioClip pianoKeySFX;
    public GameObject particleEffect;
    public Transform particleEffectLocation;
    AudioSource audio;
    public float Volume;


    // Start is called before the first frame update
    void Start()
    {
        objectToSpawn.SetActive(false);
        audio = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            objectToSpawn.SetActive(true);
            Instantiate(particleEffect, particleEffectLocation.position, particleEffectLocation.rotation);
            audio.PlayOneShot(pianoKeySFX, Volume);
            GetComponent<Animator>().Play("KeyPress");
        }

    }

}
