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
    }

    // Update is called once per frame
    void Update()
    {
        if (myActivateLight.enabled == true)
        {
            busteRigidbody.constraints = RigidbodyConstraints.None;
            GameObject.Find("Buste_abondance_d2_lod1_100k_t1_8k_Material_u1_v1").GetComponent<Interactable>().enabled = true;
        }
    }
}
