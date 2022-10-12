using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class E_InstantiatorRotate : MonoBehaviour
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