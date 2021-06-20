using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKey : MonoBehaviour
{

    public GameObject startingText;

    // Start is called before the first frame update
    void Start()
    {
        startingText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        startingText.SetActive(false);
    }


}
