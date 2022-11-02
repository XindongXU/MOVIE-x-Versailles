using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class IndiceReader : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    // [SerializeField]
    public Image _indiceImage0;
    public Image _indiceImage1;
    public Image _indiceImage2;
    public Image _indiceImage3;

    public Image _buttonImage;
    public int _roomNum;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "IndiceButton")
        {
            Debug.Log("IndiceButton was clicked");
            if (_indiceImage0.enabled == false && _indiceImage1.enabled == false && _indiceImage2.enabled == false && _indiceImage3.enabled == false) 
            {
                _buttonImage.enabled = true;
                switch (_roomNum)
                {
                    case 0:
                        Debug.Log("Abondance");
                        _indiceImage0.enabled = true;
                        break;
                    case 1:
                        Debug.Log("Hercule");
                        _indiceImage1.enabled = true;
                        break;
                    case 2:
                        Debug.Log("Venus");
                        _indiceImage2.enabled = true;
                        break;
                    case 3:
                        Debug.Log("Diane");
                        _indiceImage3.enabled = true;
                        break;
                    default:
                        Debug.Log("Nowhere");
                        break;
                }
            }
        }
        else if (e.target.name == "IndiceBackButton")
        {
            Debug.Log("BackButton was clicked");
            if (_indiceImage0.enabled == true || _indiceImage1.enabled == true || _indiceImage2.enabled == true || _indiceImage3.enabled == true) 
            {
                _buttonImage.enabled = false;
                switch (_roomNum)
                {
                    case 0:
                        Debug.Log("Abondance");
                        _indiceImage0.enabled = false;
                        break;
                    case 1:
                        Debug.Log("Hercule");
                        _indiceImage1.enabled = false;
                        break;
                    case 2:
                        Debug.Log("Venus");
                        _indiceImage2.enabled = false;
                        break;
                    case 3:
                        Debug.Log("Diane");
                        _indiceImage3.enabled = false;
                        break;
                    default:
                        Debug.Log("Nowhere");
                        break;
                }
            }
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
