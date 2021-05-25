using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public GameObject objectToSpawn;
    public AudioClip pianoKeySFX;
    AudioSource audio;
    public float Volume;

    public GameObject nextKeyToPLay;
    public GameObject keyToHide;

    public GameObject thisKeyReal;
    public GameObject thisKeyFake;



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
            audio.PlayOneShot(pianoKeySFX, Volume);
            GetComponent<Animator>().Play("KeyPress");
            Invoke("NextKey", 15);
            Invoke("EndKey", 17);
        }

    }

    void NextKey()
    {
        nextKeyToPLay.SetActive(true);
        keyToHide.SetActive(false);
    }

    void EndKey()
    {
        thisKeyReal.SetActive(false);
        thisKeyFake.SetActive(true);
    }
       


}
