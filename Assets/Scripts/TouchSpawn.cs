using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpawn : MonoBehaviour
{

    public GameObject Prefab;
    public GameObject Prefab2;
    public Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 25f));
            Instantiate(Prefab, touchPos, Quaternion.identity);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 touchPos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 25f));
            Instantiate(Prefab2, touchPos, Quaternion.identity);
        }
    }
}
