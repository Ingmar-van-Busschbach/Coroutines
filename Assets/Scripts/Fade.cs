using System.Collections;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public float duration = 1.0f;
    public int steps = 10;
    public Material mat;

    void Start()
    {
        if(mat!= null)
        {
            float delay = duration / steps;
            float stepSize = 1.0f / steps;
            StartCoroutine(FadeCoroutine(delay, stepSize, steps));
        }
    }

    IEnumerator FadeCoroutine(float delay, float stepSize, int steps)
    {
        for(int i = 1; i <= steps; i++)
        {
            Color c = mat.color;
            c.a = 1.0f - (stepSize * i);
            mat.color = c;
            yield return new WaitForSeconds(delay);
        }
        Color c2 = mat.color;
        c2.a = 0.0f;
        mat.color = c2;
    }
}
