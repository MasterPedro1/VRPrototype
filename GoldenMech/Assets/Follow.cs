using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform cameraposition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraposition.position;
    }
}
