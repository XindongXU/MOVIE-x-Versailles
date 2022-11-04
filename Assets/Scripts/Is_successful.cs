using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class Is_successful : MonoBehaviour
{
    public string TagFilter;
    public Image _EndImage;
    public GameObject _EndingText;
    public GameObject _Player;

    bool _IsSuccessful = false;
    // Start is called before the first frame update
    void Start()
    {
        _IsSuccessful = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == TagFilter)
        {
            print(this.name + " declench?par " + this.gameObject);

            if (other.GetComponent<MeshRenderer>().material.color.a == 0)
            {
                // XXD
                _IsSuccessful = true;

                if (_EndImage.enabled == false)
                {
                    _EndImage.enabled = true;
                    Debug.Log((int)_EndingText.GetComponent<Transform>().position.y);
                }
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
        if (_IsSuccessful == true)
        {
            if (_EndingText.GetComponent<Transform>().position.y <= 5)
            {
                _EndingText.GetComponent<Transform>().Translate(new Vector3(0, Time.deltaTime/8, 0));
                Debug.Log((int)_EndingText.GetComponent<Transform>().position.y);
            }
            else
            {
                _IsSuccessful = false;
                _EndImage.enabled = false;
                Destroy(_Player);
                SceneManager.LoadScene(0);
            }    
        
        }
    }
}
