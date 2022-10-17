using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door_Open : MonoBehaviour
{
    //public GameObject Statue;
    //Vector3 v1 = new Vector3(-1.91f, 0.8382025f, 29.14f); // the postion of "Normand" on the map
    bool closed = true;
    public AudioSource music;
    public AudioClip Open_door;
    private Door m_LeftDoor;
    private Door m_RightDoor;
    public GameObject LeftDoorShaft;
    public GameObject RightDoorShaft;
    public GameObject Collider;
    public UnityEvent EffectToDo;
    public string TagFilter = "Player";

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagFilter))
        {
            print(this.name + " declench¨¦ par " + this.gameObject);
            EffectToDo?.Invoke();
        }
        else
        {
            print(this.name + " a dt¨¦ une collision par un objet non autoris¨¦ seul les objets possant le tag : " + TagFilter + " sont autoris¨¦");
        }
    }

    public bool Open()
    {
        return true;
    }

    
    private void Awake()
    {
        music = gameObject.AddComponent<AudioSource>();
        music.playOnAwake = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        m_LeftDoor = LeftDoorShaft.GetComponent<Door>();
        m_RightDoor = RightDoorShaft.GetComponent<Door>();
    }

    // Update is called once per frame
    void Update()
    {   if (closed)
        {
            float LeftDoorShaftRotation = LeftDoorShaft.transform.localEulerAngles.y;
            float RightDoorShaftRotation = RightDoorShaft.transform.localEulerAngles.y;
            Debug.Log(LeftDoorShaftRotation);
            Debug.Log(closed);
            if ((LeftDoorShaftRotation >= 100) && (-180 <= RightDoorShaftRotation))
            {
                closed = false;
            }
            if (Open() == true)
            {
                Destroy(Collider);

                music.clip = Open_door;
                music.Play();

                
                m_LeftDoor.OpenLeftDoorMethod();
                m_RightDoor.OpenRightDoorMethod();

            }

        }
         
        

    }

    }

