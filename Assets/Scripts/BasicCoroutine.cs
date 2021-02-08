using System.Collections;
using UnityEngine;

public class BasicCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(BasicCoroutineFunction(0.5f));
    }

    IEnumerator BasicCoroutineFunction(float delay)
    {
        Debug.Log("Start coroutine");
        yield return new WaitForSeconds(delay);
        Debug.Log("Update coroutine");
        yield return new WaitForSeconds(delay);
        Debug.Log("End coroutine");
    }
}
