using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Disappear : MonoBehaviour
{
    public GameObject Statue;
    Vector3 v1 = new Vector3(0, 0.6799998f, 0); // the postion of "Normand" on the map
    //bool existence = true;
    public AudioSource music;
    public AudioClip Open_door;

    public bool Open(GameObject Statue)
    {
        if(v1 == Statue.transform.localPosition){
            return true;
        }
        
        else
        {
            return false;
        }
    }

    
    private void Awake()
    {
        music = gameObject.AddComponent<AudioSource>();
        music.playOnAwake = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
         if (Open(Statue) == true)
         {
            Destroy(this.gameObject);
            music.clip = Open_door;
            music.Play();
         }
        

    }

    }

