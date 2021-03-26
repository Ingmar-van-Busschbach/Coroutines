using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ease : MonoBehaviour
{
    public Vector3 targetPos;
    public Vector3 targetScale;
    public float speed;
    public float scaleSpeed;
    public GameObject obj;
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(MovementRoutineFunction(speed, targetPos, obj));
            StartCoroutine(ScaleRoutineFunction(speed, targetPos, obj));
        }
    }
    public static Vector3 EaseInQuad(Vector3 start, Vector3 end, float value)
    {
        end -= start;
        return end * value * value + start;
    }

    IEnumerator MovementRoutineFunction(float speed, Vector3 targetPos, GameObject obj)
    {
        while (Vector3.Distance(obj.transform.position, targetPos) >= 0.0001)
        {
            obj.transform.position = EaseInQuad(obj.transform.position, targetPos, speed);
            yield return null;
        }
    }
    IEnumerator ScaleRoutineFunction(float speed, Vector3 targetScale, GameObject obj)
    {
        while (Vector3.Distance(obj.transform.position, targetPos) >= 0.0001)
        {
            obj.transform.localScale = EaseInQuad(obj.transform.localScale, targetPos, scaleSpeed);
            yield return null;
        }
    }
}
