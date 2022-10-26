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
        // 查找组件引用
        txtTimer = this.GetComponent<Text>();
        // 重复调用（被执行的方法名称，第一次执行时间，每次执行间隔时间）
        InvokeRepeating("Timer", 1, 1);
    }
 
    private void Timer()
    {
        second = second - 1;
        txtTimer.text = string.Format("{0:d2}:{1:d2}", (int)second / 60, (int)second % 60);
 
        if (second <= 3) 
        {
            txtTimer.color = Color.red;
            if (second <= 0)
            {
                GameOver();

                // 取消调用
                CancelInvoke("Timer");
            }
        }
    }

    private void GameOver()
    {
        _GOImage.enabled = true;

    }
}

// {
//     private Text txtTimer;
//     public float second;
 
//     private void Start()
//     {
//         txtTimer = this.GetComponent<Text>();
//     }
 
//     private void Update()
//     {
 
//         if (second > 0)
//         {
//             second = second - Time.deltaTime;
//             if (second / 60 < 1)
//             {
//                 if (second < 4)
//                 {
//                     txtTimer.color = Color.red;
//                 }
//                 txtTimer.text = string.Format("00:{0:d2}", (int)second % 60);
//             }
//             else
//             {
//                 txtTimer.text = string.Format("{0:d2}:{1:d2}", (int)second / 60, (int)second % 60);
//             }
//         }
//         else
//         {
//             txtTimer.text = "00:00";
//             txtTimer.color = Color.red;
//         }
        
//     }
// }