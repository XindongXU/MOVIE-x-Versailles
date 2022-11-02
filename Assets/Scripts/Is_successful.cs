using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_successful : MonoBehaviour
{
    public string TagFilter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == TagFilter)
        {
            print(this.name + " declench?par " + this.gameObject);
            if (other.GetComponent<MeshRenderer>().material.color.a == 0)
            {
                // XXD
            }

        }
        else
        {
            print(this.name + " a dt?une collision par un objet non autoris? seul les objets possant le tag : " + TagFilter + " sont autoris?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
