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

    public bool Door_open_green = false;
    public bool Door_open_blue = false;
    public bool Statues = false;

    //Rotate Stautes
    public float timeAnim = 1;
    public Vector3 goalOffset = Vector3.zero;

    public void DoEffect()
    {
        StartCoroutine(AnimationRoutine());
    }

    public IEnumerator AnimationRoutine()
    {
        Vector3 Vector3Speed = goalOffset / timeAnim;

        for (float timer = 0; timer <= timeAnim; timer += Time.deltaTime)
        {
            this.transform.Rotate(Vector3Speed * Time.deltaTime);
            //this.transform.DORotate(Vector3Speed, 1).SetEase(Ease.InElastic);
            // Attendre la prochaine frame physique (dans Time.deltaTime sec)
            yield return null;
        }
    }
    int i = 0;

    public UnityEvent EffectToDo;
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "statue1_venus_d2_lod1_100k_t1_8k_Material_u1_v1.001")
        {
            EffectToDo?.Invoke();
            i++; 
        }

        if (e.target.name == "statue2_venus_d2_lod1_100k_t1_8k_Material_u1_v1.001")
        {
            EffectToDo?.Invoke();
            i++;
        }
        if (i%36 == 2)
        {
            Statues = true;
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


