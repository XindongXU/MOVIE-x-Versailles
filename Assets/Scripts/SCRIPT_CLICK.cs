using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.Events;

public class SCRIPT_CLICK : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;


    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
        laserPointer.PointerClick += PointerClick2;
        laserPointer.PointerClick += PointerClick3;
    }
    public UnityEvent EffectToDo1;
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "statue1_venus_d2_lod1_100k_t1_8k_Material_u1_v1.001")
        {
            EffectToDo1?.Invoke(); 
        }

        if (e.target.name == "statue2_venus_d2_lod1_100k_t1_8k_Material_u1_v1.001")
        {
            EffectToDo1?.Invoke(); 
        }
    }

    public UnityEvent EffectToDo2;
    public void PointerClick2(object sender, PointerEventArgs e)
    {
        if (e.target.name == "DiamandBleu")
        {
            EffectToDo2?.Invoke(); 
        }
    }

    public UnityEvent EffectToDo3;
    public void PointerClick3(object sender, PointerEventArgs e)
    {
        if (e.target.name == "DiamandVert")
        {
            EffectToDo3?.Invoke(); 
        }
    }


    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "")
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

