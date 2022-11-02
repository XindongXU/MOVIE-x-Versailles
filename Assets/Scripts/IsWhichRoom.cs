using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsWhichRoom : MonoBehaviour
{
    public UnityEvent EffectToDo;
    public string TagFilter;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == TagFilter)
        {
            print(this.name + " declenche par " + this.gameObject);
            EffectToDo?.Invoke();

        }
        else
        {
            print(this.name + " a dt�� une collision par un objet non autoris�� seul les objets possant le tag : " + TagFilter + " sont autoris��");
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
