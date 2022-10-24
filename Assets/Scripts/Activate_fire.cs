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
        if (candle1 && candle2 && candle3)
        {
            print("yes");
            particleSystem.Play();
        }
    }

    public void OnTriggerEnter(Collider other) //OnTriggerExit OnTriggerEnter
    {
        if (other.CompareTag(TagFilter1))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle1 = true;
            print(TagFilter1 + candle1);
            Activate();
        }
        else if(other.CompareTag(TagFilter2))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle2 = true;
            print(TagFilter2 + candle2);
            Activate();
        }
        else if (other.CompareTag(TagFilter3))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle3 = true;
            print(TagFilter3 + candle3);
            Activate();
        }
        else
        {
            print(this.name + " a dté une collision par un objet non autorisé seul les objets possant le tag : candle sont autorisé");
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