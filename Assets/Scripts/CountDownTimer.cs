using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    private Text txtTimer;
    public Image _GOImage;
    public float second;
 
    private void Start()
    {
        txtTimer = this.GetComponent<Text>();
        // 重复调用（被执行的方法名称，第一次执行时间，每次执行间隔时间）
        InvokeRepeating("Timer", 1, 1);
    }
 
    private void Timer()
    {
        second = second - 1;
        txtTimer.text = string.Format("{0:d2}:{1:d2}", (int)second / 60, (int)second % 60);
        Debug.Log(int(second));
        Debug.Log(txtTimer.text);

        if (second <= 3)
        {
            txtTimer.color = Color.red;
            if (second <= 0)
            {
                if (_GOImage.enabled == false)
                {
                    GameOver();
                }
                CancelInvoke("Timer");
            }
        }
    }

    private void GameOver()
    {
        _GOImage.enabled = true;
    }

    private void Update()
    {

    }
 }