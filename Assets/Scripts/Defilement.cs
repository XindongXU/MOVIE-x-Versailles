using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class Defilement : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public Image _StartImage;
    public Image _GOImage;
    public GameObject _BvInterface;
    public GameObject _BvText;
    // [SerializeField] TMPro.TextMeshProUGUI countdownText;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Plane_Start" && _StartImage.enabled == false)
        {
            Debug.Log("Plane_Start was clicked");
            _StartImage.enabled = true;
            // _buttonImage.enabled = true;

            while(_BvText.GetComponent<Transform>().position.y <= 75)
            {
            transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
            // test
            // from -45 to 75;
            // duration : 120 deltaTime;
            // Destroy(_BvInterface, 10.0f);
            }

        }
        else if (e.target.name == "BackButton" && _StartImage.enabled == true)
        {
            Debug.Log("BackButton was clicked");
            _StartImage.enabled = false;
            _buttonImage.enabled = false;

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while(this.GetComponent<Transform>().position.y <= 75)
        {
            transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
            // from -45 to 75;
            // duration : 120 deltaTime;
            // Destroy(_BvInterface, 10.0f);
        }
        // Destroy(gameObject);
        Destroy(_BvInterface);

        

    }
}