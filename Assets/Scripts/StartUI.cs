using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class StartUI : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public SteamVR_LaserPointer laserPointer;
    public Image _StartImage;
    public Image _GOImage;
    // public GameObject _BvInterface;
    public GameObject _BvText;
    [SerializeField] TMPro.TextMeshProUGUI countdownText;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

    }

    private void GameOver()
    {
        if (_GOImage.enabled == false)
        {
            _GOImage.enabled = true;
        }
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Plane_Start" && _StartImage.enabled == false)
        {
            Debug.Log("Plane_Start was clicked");
            Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
            _StartImage.enabled = true;
            // _buttonImage.enabled = true;

            while(_BvText.GetComponent<Transform>().position.y <= 75)
            {
                transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
                Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
                // test
                // from -45 to 75;
                // duration : 120 deltaTime;
                // Destroy(_BvInterface, 10.0f);
            }
            // _StartImage.enabled = false;
            // Destroy(_BvText);

            // while(currentTime >= 0)
            // {
            //     currentTime -= 1 * Time.deltaTime;
            //     countdownText.text = string.Format("{0:d2}:{1:d2}", (int)currentTime / 60, (int)currentTime % 60);
            // }
            // GameOver();
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
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        // while(this.GetComponent<Transform>().position.y <= 75)
        // {
        //     transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
        //     // from -45 to 75;
        //     // duration : 120 deltaTime;
        //     // Destroy(_BvInterface, 10.0f);
        // }
        // // Destroy(gameObject);
        // Destroy(_BvInterface);
    }
}