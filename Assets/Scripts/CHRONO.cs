using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHRONO : MonoBehaviour
{
    public float time = 10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (timer ());
        time +=1;
    }

    IEnumerator timer()
    {
        while(time>0)
        {
            time--;
            yield return new WaitForSeconds (1f);
            GetComponent<Text> ().text = string.Format ("{0:0}:{1:00}", Mathf.Floor (time/60), time%60);

        }
        if(time == 0)
        {
            Debug.Log("Le chevalier de Rohan rentre de la messe, vous avez échoué...")
        }
    }
}
