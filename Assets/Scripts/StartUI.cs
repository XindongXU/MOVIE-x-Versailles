using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class StartUI : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public SteamVR_LaserPointer laserPointer;
    public Image _StartImage;
    public Image _GOImage;
    public Image _RestartImage;

    // public GameObject _BvInterface;
    public GameObject _BvText;
    [SerializeField] TMPro.TextMeshProUGUI countdownText;
    bool _IsGameStarted = false;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

    }

    private void GameOver()
    {
        if (_GOImage.enabled == false && _RestartImage.enabled == false)
        {
            _GOImage.enabled = true;
            _RestartImage.enabled = true;
        }
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "RestartButton" && _RestartImage.enabled == true)
        {
            SceneManager.LoadScene(0);
        }
        
        if (e.target.name == "Plane_Start" && _StartImage.enabled == false)
        {
            Debug.Log("Plane_Start was clicked");
            Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
            _StartImage.enabled = true;
            _IsGameStarted = true;
            // _buttonImage.enabled = true;

            //while (_BvText.GetComponent<Transform>().position.y <= 5)
            //{
            //    _BvText.GetComponent<Transform>().Translate(new Vector3(0, 1 * Time.deltaTime, 0));
            //    Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
            //    // test
            //    // from -45 to 75;
            //    // duration : 120 deltaTime;
            //    // Destroy(_BvInterface, 10.0f);
            //}


            // _StartImage.enabled = false;
            // Destroy(_BvText);

            //while (currentTime >= 0)
            //{
            //    currentTime -= 1 * Time.deltaTime;
            //    countdownText.text = string.Format("{0:d2}:{1:d2}", (int)currentTime / 60, (int)currentTime % 60);
            //}
            //GameOver();
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
        if (_IsGameStarted == true)
        {
            if (_BvText.GetComponent<Transform>().position.y <= 7)
            {
                _BvText.GetComponent<Transform>().Translate(new Vector3(0, Time.deltaTime/4, 0));
                Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
            }
            else if (_StartImage.enabled == true)
            {
                _StartImage.enabled = false;
                // destroy tout;
                // Destroy(_StartImage);
                Destroy(_BvText);
            }
            else if (currentTime >= 0)
            {
                currentTime -= 1 * Time.deltaTime;
                countdownText.color = Color.white;
                countdownText.text = string.Format("{0:d2}:{1:d2}", (int)currentTime / 60, (int)currentTime % 60);
                if (currentTime <= 30)
                {
                    countdownText.color = Color.red;
                }
            }

            if (currentTime < 0)
            {
                _IsGameStarted = false;
                GameOver();
            }
            
        }
    }
}