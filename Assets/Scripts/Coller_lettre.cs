using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coller_lettre : MonoBehaviour
{
    public GameObject B;   //AҪ�����B
    public GameObject A;

    void Start()
    {
        
    } 
     
    void Update()
    {
        A.transform.position = Vector3.MoveTowards(A.transform.position, B.transform.position, 0.01f);
    }
        
}
