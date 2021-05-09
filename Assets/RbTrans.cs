using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbTrans : MonoBehaviour
{
    // Start is called before the first frame update

        public Transform handPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = handPos.position;
    }
}
