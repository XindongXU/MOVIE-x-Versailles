using UnityEngine;
using System.Collections;




public class XLine_Test : MonoBehaviour {
	public GameObject Line;
	public GameObject FXef;//Effet de particules du laser frappant l'objet

	bool laser = false;

    bool closed = true;
    public AudioSource music;
    public AudioClip Open_door;
    private Door m_LeftDoor;
    private Door m_RightDoor;
    public GameObject LeftDoorShaft;
    public GameObject RightDoorShaft;
    public GameObject Collider;

    bool Door_open = false;

	public void DoEffect()
    {
    
    

    // Use this for initialization
    // Update is called once per frame

		RaycastHit hit;
		Vector3 Sc;// Transformer la taille
		Sc.x=0.5f;
		Sc.z=0.5f;
        if (Physics.Raycast(transform.position, this.transform.forward, out hit)){
			Debug.DrawLine(this.transform.position,hit.point);
			Sc.y=hit.distance;
			FXef.transform.position=hit.point;
			FXef.SetActive(true);
		}
        //Lorsque le laser ne touche pas l'objet, maintenez la longueur du rayon à 500 m et réglez l'effet de frappe pour qu'il ne s'affiche pas
        else
        {
			Sc.y=500;
		    FXef.SetActive(false);
		}
			
		Line.transform.localScale=Sc;
        bool laser = true;
	}

   
    public void Open()
    {
        Door_open = true;
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
            if (Door_open == true)
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


