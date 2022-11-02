using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class XLine_Test : MonoBehaviour
{
    public GameObject Line;
    public GameObject FXef;//Effet de particules du laser frappant l'objet
    public GameObject statue;


    bool closed = true;
    public AudioSource music;
    public AudioClip Open_door;
    private Door m_LeftDoor;
    private Door m_RightDoor;
    public GameObject LeftDoorShaft;
    public GameObject RightDoorShaft;
    public GameObject Collider;
    public GameObject DiamandBleu;
    public GameObject DiamandVert;

    bool Door_open_green;
    bool Door_open_blue;
    bool Door_statues = false;
    bool laser = false;



    public float timeAnim = 1;
    public Vector3 goalOffset = Vector3.zero;

    public void DoEffectStatues()
    {
        StartCoroutine(AnimationRoutine());
    }
    float AngY;
    public IEnumerator AnimationRoutine()
    {
        Vector3 Vector3Speed = goalOffset / timeAnim;

        for (float timer = 0; timer <= timeAnim; timer += Time.deltaTime)
        {
            this.transform.Rotate(Vector3Speed * Time.deltaTime);
            yield return null;
        }
    }

    public void DoEffect()
    {

        // Use this for initialization
        // Update is called once per frame

        RaycastHit hit;
        Vector3 Sc;// Transformer la taille
        Sc.x = 0.5f;
        Sc.z = 0.5f;
        if (Physics.Raycast(transform.position, this.transform.forward, out hit))
        {
            Debug.DrawLine(this.transform.position, hit.point);
            Sc.y = hit.distance;
            FXef.transform.position = hit.point;
            FXef.SetActive(true);
        }
        //Lorsque le laser ne touche pas l'objet, maintenez la longueur du rayon à 50 m et réglez l'effet de frappe pour qu'il ne s'affiche pas
        else
        {
            Sc.y = 50;
            FXef.SetActive(false);
        }

        Line.transform.localScale = Sc;
        laser = true;
        Debug.Log("le laser est en mode:" + laser);
    }


    public void Open_green()
    {
        DiamandVert.GetComponent<Diamond_variable>().Door_open = true;
        Debug.Log("le diamand vert est en mode" + Door_open_green);
    }

    public void Open_blue()
    {

        DiamandBleu.GetComponent<Diamond_variable>().Door_open = true;
        Debug.Log("le diamand bleu est en mode" + Door_open_blue);
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
        //Door_open_green = DiamandVert.GetComponent<Diamond_variable>().Door_open;
        //Door_open_blue = DiamandBleu.GetComponent<Diamond_variable>().Door_open;

        //Door_open_blue = false;
        //Door_open_blue = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (closed && laser)
        {
            float LeftDoorShaftRotation = LeftDoorShaft.transform.localEulerAngles.y;
            float RightDoorShaftRotation = RightDoorShaft.transform.localEulerAngles.y;
            Debug.Log(LeftDoorShaftRotation);
            Debug.Log(closed);

            if ((LeftDoorShaftRotation >= 100) && (-180 <= RightDoorShaftRotation))
            {
                closed = false;
            }
            AngY = statue.transform.localEulerAngles.y;
            if (AngY > 310 && AngY < 330)
            {
                Door_statues = true;
                Debug.Log("les statues sont en mode" + Door_statues);
            }

            Debug.Log("statue =" + Door_statues);
            Debug.Log("laqer =" + laser);
            Debug.Log("vert=" + DiamandVert.GetComponent<Diamond_variable>().Door_open);
            Debug.Log("bleu=" + DiamandBleu.GetComponent<Diamond_variable>().Door_open);

            if (DiamandVert.GetComponent<Diamond_variable>().Door_open == true && DiamandBleu.GetComponent<Diamond_variable>().Door_open == true && Door_statues == true)
            {
                Debug.Log("statue =" + Door_statues);
                Debug.Log("laqer ="+ laser);
                //Debug.Log("vert="+ Door_open_green);
                //Debug.Log("bleu="+ Door_open_blue);

                Destroy(Collider);

                music.clip = Open_door;
                music.Play();


                m_LeftDoor.OpenLeftDoorMethod();
                m_RightDoor.OpenRightDoorMethod();

            }

        }



    }
}


    


