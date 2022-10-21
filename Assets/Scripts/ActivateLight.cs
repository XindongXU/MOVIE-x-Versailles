using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLight : MonoBehaviour
{
    public bool isOnLight = true;
    public Light myLight;

    public void Light()
    {
        myLight = gameObject.GetComponentInChildren<Light>();
        if (isOnLight)
        {
            myLight.enabled = true;
        }
        else
        {
            myLight.enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
