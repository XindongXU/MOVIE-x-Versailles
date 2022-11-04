using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.Events;

public class LetterReader : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    [SerializeField]
    private Image _noteImage;
    public UnityEvent EffectToDo;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "BackButton" && _noteImage.enabled == true)
        {
            Debug.Log("Lettre was clicked");
            _noteImage.enabled = false;
            EffectToDo?.Invoke();

        }
        else if (e.target.name == "Plane_Lettre" && _noteImage.enabled == false)
        {
            Debug.Log("Plane was clicked");
            _noteImage.enabled = true;
            EffectToDo?.Invoke();

        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "BackButton")
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
        else if (e.target.name == "BackButton")
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
