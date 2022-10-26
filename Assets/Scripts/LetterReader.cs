using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class LetterReader : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    // [SerializeField]
    public Image _noteImage;
    public Image _buttonImage;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Plane_Lettre" && _noteImage.enabled == false)
        {
            Debug.Log("Plane_Lettre was clicked");
            _noteImage.enabled = true;
            _buttonImage.enabled = true;

        }
        else if (e.target.name == "BackButton" && _noteImage.enabled == true)
        {
            Debug.Log("BackButton was clicked");
            _noteImage.enabled = false;
            _buttonImage.enabled = false;

        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "BackButton")
        {
            Debug.Log("Button was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "BackButton")
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
