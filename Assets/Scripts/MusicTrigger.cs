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

    public GameObject nextKeyToPLay;
    public GameObject keyToHide;



    // Start is called before the first frame update
    void Start()
    {
        objectToSpawn.SetActive(false);
        audio = GetComponent<AudioSource>();
        nextKeyToPLay.SetActive(false);
        keyToHide.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Hand"))
        {
            Collider col = GetComponent<Collider>();
            col.enabled = false;
            objectToSpawn.SetActive(true);
            Instantiate(particleEffect, particleEffectLocation.position, particleEffectLocation.rotation);
            audio.PlayOneShot(pianoKeySFX, Volume);
            GetComponent<Animator>().Play("KeyPress");
            Invoke("NextKey", 15);
        }

    }

    void NextKey()
    {
        nextKeyToPLay.SetActive(true);
        keyToHide.SetActive(false);
    }


}
