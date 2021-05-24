using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsInstance : MonoBehaviour
{

    public GameObject mObject;
    public Color colour;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        mObject = this.gameObject;
        material = mObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        material.color = colour;
    }
}
