using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer1 : MonoBehaviour
{
    private Text txtTimer;
    public Image _GOImage;
    public float second;
 
    private void Start()
    {
        txtTimer = this.GetComponent<Text>();
    }
    
    private void GameOver()
    {
        _GOImage.enabled = true;

    }
 
    private void Update()
    {
 
        if (second > 0)
        {
            second = second - Time.deltaTime;
            
            if (second / 60 < 1)
            {
                if (second < 4)
                {
                    txtTimer.color = Color.red;
                }
                txtTimer.text = string.Format("00:{0:d2}", (int)second % 60);
            }
            else
            {
                txtTimer.text = string.Format("{0:d2}:{1:d2}", (int)second / 60, (int)second % 60);
            }
        }
        else
        {
            txtTimer.text = "00:00";
            txtTimer.color = Color.red;

            if (_GOImage.enabled == false)
            {
                GameOver();
            }
        }

        Debug.Log((int)second);
        Debug.Log(txtTimer.text);
        
    }
}