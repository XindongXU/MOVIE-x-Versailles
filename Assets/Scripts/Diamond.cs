using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private Game0bject PlaceableobjectPrefabi

    private KeyCode newobjectHotkey = Keycode.A.I

    private GameObject currentPlaceableObject;
    private flot mouseWheelRotation;
    private void Update (){
        HandleNewObjectHotkey();
        if (currentPlaceable0bject != null)
        {
            MoveCurrentObjectToMouse();
            RotateFromMouseWheel();
            ReleaseIfClicked);
        }
    }
    private void HandleNewObjectHotkey()
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
