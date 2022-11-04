using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Interactable_statue_after_lights_on : MonoBehaviour
{
    //public GameObject statue;
    public GameObject myLight;
    private Light myActivateLight;
    public GameObject buste;
    private Rigidbody busteRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myActivateLight = myLight.GetComponent<Light>();
        busteRigidbody = buste.GetComponent<Rigidbody>();
        //busteRigidbody.isKinematic = false;
        //busteRigidbody.detectCollisions = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (myActivateLight.enabled == true)
        {
            busteRigidbody.constraints = RigidbodyConstraints.None;
            buste.GetComponent<Interactable>().enabled = true;
            //buste.AddComponent<Throwable>();
        }
    }
}
