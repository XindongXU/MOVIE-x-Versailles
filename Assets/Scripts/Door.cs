using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Door : MonoBehaviour
{
    Transform tf;
    private bool isOpen = false;
    //public float speed = 0.01f;
    public GameObject DoorShaft;
    //private Vector3 DoorCraftPosition = DoorCraft.transform.LocalPosition;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLeftDoorMethod()
    {

        //tf.localRotation = Quaternion.Slerp(tf.localRotation, 90, angleSpeed);
        //tf.Rotate(Vector3.up * Time.deltaTime * speed, 100);
        Vector3 DoorCraftPosition = DoorShaft.transform.position;
        tf.RotateAround(DoorCraftPosition, Vector3.up, 20 * Time.deltaTime);
        Debug.Log("close");
        isOpen = !isOpen;
    }

    public void OpenRightDoorMethod()
    {
        Vector3 DoorCraftPosition = DoorShaft.transform.position;
        tf.RotateAround(DoorCraftPosition, -Vector3.up, 20 * Time.deltaTime);
        Debug.Log("close");
        isOpen = !isOpen;
    }

    /*
    public void CloseDoorMethod()
    {
        tf.Rotate(Vector3.up, -100);
        Debug.Log("open");
        isOpen = !isOpen;
    }

    public bool GetIsOpen()
    {
        return isOpen;
    }
    public void SetIsOpen(bool b)
    {
        isOpen = b;
    }
    */
}