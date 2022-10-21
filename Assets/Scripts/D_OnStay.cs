using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class D_OnStay : MonoBehaviour
{
    //public UnityEvent EffectToDo;
    public string TagFilter = "Player";
    bool executed = false;
    float timer = 0;
    public ParticleSystem particleSystem;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(TagFilter))
        {
            print(this.name + " declenché par " + this.gameObject);

            if (executed == false)
            {
                timer += Time.deltaTime;
                if (timer >= 3)
                {
                    executed = true;
                    particleSystem.Play();
                }
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