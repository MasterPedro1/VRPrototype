using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject handpoint;

    private GameObject picked = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objeto"))
        {
            Debug.Log("Chocó");
            if (Input.GetKey("e") && picked == null)
            {
                Debug.Log("Grabbing");

                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = handpoint.transform.position;

                other.gameObject.transform.SetParent(handpoint.gameObject.transform);

                picked = other.gameObject;
            }
        }
    }
}
