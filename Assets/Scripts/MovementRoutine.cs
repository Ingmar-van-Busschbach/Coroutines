using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRoutine : MonoBehaviour
{
    public Vector3 targetPos;
    public float speed;
    public GameObject obj;
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(MovementRoutineFunction(speed, targetPos, obj));
        }
    }
    IEnumerator MovementRoutineFunction(float speed, Vector3 targetPos, GameObject obj)
    {
        while(Vector3.Distance(obj.transform.position, targetPos) >= 0.0001)
        {
            obj.transform.position = Vector3.Lerp(obj.transform.position, targetPos, speed);
            yield return null;
        }
    }
}
