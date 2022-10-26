using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemManager : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        if(!ps.isPlaying)
            ps.Play();
        //ps.enableEmission = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
