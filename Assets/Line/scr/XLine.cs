using UnityEngine;
using System.Collections;

public class XLine : MonoBehaviour {
	public GameObject Line;
	public GameObject FXef;//Effet de particules du laser frappant l'objet

	bool laser = false;

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
}
