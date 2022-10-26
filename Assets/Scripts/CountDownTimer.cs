using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public Image _GOImage;

    [SerializeField] TMPro.TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    private void GameOver()
    {
        _GOImage.enabled = true;

    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        // countdownText.text = currentTime.ToString("0");

        countdownText.text = string.Format("{0:d2}:{1:d2}", (int)currentTime / 60, (int)currentTime % 60);
        if (currentTime <= 0)
        {
            currentTime = 0;
            if (_GOImage.enabled == false)
            {
                GameOver();
            }

        }
    }
}
