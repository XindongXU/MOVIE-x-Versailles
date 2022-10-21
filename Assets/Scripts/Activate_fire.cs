using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activate_fire : MonoBehaviour
{
    //public UnityEvent EffectToDo;
    public string TagFilter = "Player";
    bool executed = false;
    float timer = 0;
    public ParticleSystem particleSystem;
    int candle = 0;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(TagFilter))
        {
            print(this.name + " declenché par " + this.gameObject);
            candle += 1;
            if (candle == 3)
            {
                particleSystem.Play();
            }
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