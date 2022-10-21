using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activate_fire : MonoBehaviour
{
    //public UnityEvent EffectToDo;
    public string TagFilter1;
    public string TagFilter2;
    public string TagFilter3;
    public ParticleSystem particleSystem;
    bool candle1 = false;
    bool candle2 = false;
    bool candle3 = false;


    void Activate()
    {
        if (candle1 == candle2 == candle3 == true)
        {
            particleSystem.Play();
        }
    }

    public void OnTriggerEnter(Collider other) //OnTriggerExit OnTriggerEnter
    {
        if (other.CompareTag(TagFilter1))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle1 = true;
            Activate();
        }
        else if(other.CompareTag(TagFilter2))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle2 = true;
            Activate();
        }
        else if (other.CompareTag(TagFilter3))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle3 = true;
            Activate();
        }
        else
        {
            print(this.name + " a dté une collision par un objet non autorisé seul les objets possant le tag : " + TagFilter + " sont autorisé");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}