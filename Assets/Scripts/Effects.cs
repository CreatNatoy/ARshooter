using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DieEffects());
    }

    private IEnumerator DieEffects()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject); 
    }
}
