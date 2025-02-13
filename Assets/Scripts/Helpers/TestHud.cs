using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestHud : MonoBehaviour
{
    public UnityEvent test;
    public UnityEvent test2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(R());
    }

    private IEnumerator R()
    {
        Debug.Log("START");
        test.Invoke();
        yield return new WaitForSeconds(2);
        StartCoroutine(Q());
    }
    private IEnumerator Q()
    {
        yield return new WaitForSeconds(1);
        test2.Invoke();
    }
}
