using UnityEngine;
using System.Collections;




public class XLine_Test : MonoBehaviour {
	public GameObject Line;
	public GameObject FXef;//Effet de particules du laser frappant l'objet


    bool closed = true;
    public AudioSource music;
    public AudioClip Open_door;
    private Door m_LeftDoor;
    private Door m_RightDoor;
    public GameObject LeftDoorShaft;
    public GameObject RightDoorShaft;
    public GameObject Collider;

    public bool Door_open_green = false;
    public bool Door_open_blue = false;
    public bool Door_statues = false;
    public bool laser = false;

    public float timeAnim = 1;
    public Vector3 goalOffset = Vector3.zero;

    public void DoEffectStatues()
    {
        StartCoroutine(AnimationRoutine());
    }
    int i = 0;
    public IEnumerator AnimationRoutine()
    {
        Vector3 Vector3Speed = goalOffset / timeAnim;

        for (float timer = 0; timer <= timeAnim; timer += Time.deltaTime)
        {
            this.transform.Rotate(Vector3Speed * Time.deltaTime);
            i = i + 1;
            if (i%36==2)
            {
                Door_statues = true;
            }
            
            yield return null;
        }
    }

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
        laser = true;
	}


    public void Open_green()
    {
        Door_open_green = true;
    }

    public void Open_blue()
    {
        Door_open_blue = true;
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
    {   if (closed & laser)
        {
            float LeftDoorShaftRotation = LeftDoorShaft.transform.localEulerAngles.y;
            float RightDoorShaftRotation = RightDoorShaft.transform.localEulerAngles.y;
            Debug.Log(LeftDoorShaftRotation);
            Debug.Log(closed);
            if ((LeftDoorShaftRotation >= 100) && (-180 <= RightDoorShaftRotation))
            {
                closed = false;
            }
            if (Door_open_green == true & Door_open_blue == true)
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


