using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsInstance : MonoBehaviour
{
    float startTime;
    public float speed = 1.0f;

    public GameObject mObject;
    public Color startColour;
    public Color colour;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        mObject = this.gameObject;
        material = mObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Time.time - startTime) * speed;
        GetComponent<Renderer>().material.color = Color.Lerp(startColour, colour, t);
    }
}
