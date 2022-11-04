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
    public GameObject _Player;
    [SerializeField] TMPro.TextMeshProUGUI countdownText;
    [SerializeField] TMPro.TextMeshProUGUI BvText;
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
            Destroy(_Player);
            SceneManager.LoadScene(0);
        }
        
        if (e.target.name == "Plane_Start" && _StartImage.enabled == false)
        {
            Debug.Log("Plane_Start was clicked");
            Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
            _StartImage.enabled = true;
            _IsGameStarted = true;
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
        // _IsGameStarted = true;
        if (_IsGameStarted == true)
        {
            if (_BvText.GetComponent<Transform>().position.y <= 5)
            {
                _BvText.GetComponent<Transform>().Translate(new Vector3(0, Time.deltaTime/4, 0));
                Debug.Log((int)_BvText.GetComponent<Transform>().position.y);
            }
            else if (_StartImage.enabled == true)
            {
                _StartImage.enabled = false;
                BvText.enabled = false;
            }
            else if (currentTime >= 0)
            {
                currentTime -= 1 * Time.deltaTime;
                // countdownText.color = Color.white;
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