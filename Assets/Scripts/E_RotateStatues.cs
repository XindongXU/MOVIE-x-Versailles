using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class E_RotateStatues : MonoBehaviour

{
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
}

//{
    //float rotSpeed = 10;
    //void OnMouseDrag()
    //{
    //    float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;

    //   transform.RotateAround(Vector3.up, rotX);

    //}
    //public Transform objectToRotateAround;
    //void RotateAroundObject()
    //{
        // Rotates around the pivot object's position and the Y-Axis by 60 degrees
    //    transform.RotateAround(objectToRotateAround.position, Vector3.up, 60);
    //}
//}