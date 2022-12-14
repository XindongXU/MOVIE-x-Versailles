using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.Events;
// ajouter sous one collider of player

public class IndiceReader1 : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public UnityEvent EffectToDo;
    // public string TagFilter;
    // [SerializeField]
    public Image _indiceImage0;
    public Image _indiceImage1;
    public Image _indiceImage2;
    public Image _indiceImage3;

    public Image _buttonImage;
    private int _roomNum = 0;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.name == "Room0")
    //    {
    //        Debug.Log("enter Hercule");
    //        EffectToDo?.Invoke();
    //        _roomNum = 0;
    //        Debug.Log(_roomNum);
    //    }
    //    else if (other.name == "Room1")
    //    {
    //        Debug.Log("enter Abondance");
    //        EffectToDo?.Invoke();
    //        _roomNum = 1;
    //        Debug.Log(_roomNum);
    //    }
    //    else if (other.name == "Room2")
    //    {
    //        Debug.Log("enter Venus");
    //        EffectToDo?.Invoke();
    //        _roomNum = 2;
    //        Debug.Log(_roomNum);
    //    }
    //    else if (other.name == "Room3")
    //    {
    //        Debug.Log("enter Diane");
    //        EffectToDo?.Invoke();
    //        _roomNum = 3;
    //        Debug.Log(_roomNum);
    //    }

    //}

    //public void Roomnumber0()
    //{
    //    _roomNum = 0;
    //    Debug.Log("roomnumber = " + _roomNum);
    //}

    //public void Roomnumber1()
    //{
    //    _roomNum = 1;
    //    Debug.Log("roomnumber = " + _roomNum);
    //}

    //public void Roomnumber2()
    //{
    //    _roomNum = 2;
    //    Debug.Log("roomnumber = " + _roomNum);
    //}

    //public void Roomnumber3()
    //{
    //    _roomNum = 3;
    //    Debug.Log("roomnumber = " + _roomNum);
    //}

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
                        Debug.Log("Indice Hercule in");
                        _indiceImage0.enabled = true;
                        break;
                    case 1:
                        Debug.Log("Indice Abondance in");
                        _indiceImage1.enabled = true;
                        break;
                    case 2:
                        Debug.Log("Indice Venus in");
                        _indiceImage2.enabled = true;
                        break;
                    case 3:
                        Debug.Log("Indice Diane in");
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
                _indiceImage0.enabled = false;
                _indiceImage1.enabled = false;
                _indiceImage2.enabled = false;
                _indiceImage3.enabled = false;

                // switch (_roomNum)
                // {
                //     case 0:
                //         Debug.Log("Indice Abondance out");
                //         _indiceImage0.enabled = false;
                //         break;
                //     case 1:
                //         Debug.Log("Indice Hercule out");
                //         _indiceImage1.enabled = false;
                //         break;
                //     case 2:
                //         Debug.Log("Indice Venus out");
                //         _indiceImage2.enabled = false;
                //         break;
                //     case 3:
                //         Debug.Log("Indice Diane out");
                //         _indiceImage3.enabled = false;
                //         break;
                //     default:
                //         Debug.Log("Nowhere");
                //         break;
                // }
            }
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "IndiceBackButton")
        {
            Debug.Log("IndiceBackButton was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "IndiceBackButton")
        {
            Debug.Log("IndiceBackButton was exited");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.z <= 50 && this.transform.localPosition.z >= 32)
        {
            Debug.Log("enter Hercule");
            _roomNum = 0;
            Debug.Log(_roomNum);
        }
        else if (this.transform.localPosition.z <= 32 && this.transform.localPosition.z >= 25)
        {
            Debug.Log("enter Abondance");
            _roomNum = 1;
            Debug.Log(_roomNum);
        }
        else if (this.transform.localPosition.z <= 25 && this.transform.localPosition.z >= 10)
        {
            Debug.Log("enter Venus");
            _roomNum = 2;
            Debug.Log(_roomNum);
        }
        else if (this.transform.localPosition.z <= 10 && this.transform.localPosition.z >= 0)
        {
            Debug.Log("enter Diane");
            _roomNum = 3;
            Debug.Log(_roomNum);
        }
    }
}
