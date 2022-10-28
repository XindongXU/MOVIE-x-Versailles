using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Interactable_buste : MonoBehaviour
{
    public GameObject myLight;
    private Light myActivateLight;
    // Start is called before the first frame update
    void Start()
    {
        myActivateLight = myLight.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myActivateLight.enabled == true)
        {
            GameObject.Find("Buste_abondance_d2_lod1_100k_t1_8k_Material_u1_v1").GetComponent<Interactable>().enabled = true;
        }
    }
}
