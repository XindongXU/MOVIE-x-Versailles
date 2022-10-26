using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dotweentransparent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color co = GetComponent<MeshRenderer>().material.color;
        co.a = 1f;
        GetComponent<MeshRenderer>().material.color = co;
    }

    public void Showletter()
    {
        
        GetComponent<MeshRenderer>().material.DOFade(0, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
