using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// D�clenche un UnityEvent lorsque le joueur clic sur l'objet. ATTENTION CELA NECESSITE UN COLLIDER
public class D_OnClick : MonoBehaviour
{
    public UnityEvent EffectToDo;

    public void OnMouseDown()
    {
        EffectToDo?.Invoke();
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