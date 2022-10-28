using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Show_letter : MonoBehaviour
{
    public UnityEvent EffectToDo;
    public string TagFilter;
    float time = 0;
    public new ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.name == TagFilter)
        {
            print(this.name + " declench¨¦ par " + this.gameObject);
            time += Time.deltaTime;
            if (time > 3)
            {
                if (particleSystem.isPlaying)
                {
                    EffectToDo?.Invoke();
                    print("yes");
                }
                
            }
        }
        else
        {
            print(this.name + " a dt¨¦ une collision par un objet non autoris¨¦ seul les objets possant le tag : " + TagFilter + " sont autoris¨¦");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
