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
    private new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myActivateLight = myLight.GetComponent<Light>();
        rigidbody = buste.GetComponent<Rigidbody>();
        //GameObject.Find("Buste").GetComponent<Interactable>().enabled = false;
        //print("bustebuste");
    }

    // Update is called once per frame
    void Update()
    {
        if (myActivateLight.enabled == true && GameObject.Find("Buste").GetComponent<Interactable>().enabled == false)
        {
            GameObject.Find("Buste").GetComponent<Interactable>().enabled = true;
            //buste.AddComponent<Interactable>();
            buste.AddComponent<Throwable>();
            rigidbody.constraints = RigidbodyConstraints.None;
        }
        /*
        if (GameObject.Find("Buste").GetComponent<Interactable>().enabled == false)
        {
            print("buste false");
        }
        */
    }
}
