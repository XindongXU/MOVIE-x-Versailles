using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.Events;

public class SCRIPT_STATUES : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;


    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }
    public UnityEvent EffectToDo;
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "statue1_venus_d2_lod1_100k_t1_8k_Material_u1_v1.001")
        {
            EffectToDo?.Invoke(); 
        }

        if (e.target.name == "statue2_venus_d2_lod1_100k_t1_8k_Material_u1_v1.001")
        {
            EffectToDo?.Invoke(); 
        }
    }


    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was exited");
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

