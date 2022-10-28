using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coller_lettre : MonoBehaviour
{
    public Transform B;   //A要跟随的B
    public float smoothTime = 0.01f;  //A平滑移动的时间
    private Vector3 AVelocity = Vector3.zero;
    //private A mainA;  

    void Awake()
    {
        //mainA = A.main;
    } 
     
    void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, B.position + new Vector3(0, 0, -5), ref AVelocity, smoothTime);
    }
        
}
