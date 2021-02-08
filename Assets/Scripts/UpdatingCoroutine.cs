using System.Collections;
using UnityEngine;

public class UpdatingCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(UpdatingCoroutineFunction(0.5f));
    }

    IEnumerator UpdatingCoroutineFunction(float delay)
    {
        Debug.Log("Start coroutine");
        for (int i = 0; i < 10; i++){
            Debug.Log("Update coroutine");
            if (i != 9)
            {
                yield return new WaitForSeconds(delay);
            }
        }
        Debug.Log("End coroutine");
    }
}
