using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPcollider : MonoBehaviour
{
    public bool isActive;

    public float activeTime;
    public float activeTimer = 1;

    private void Update()
    {
        if (activeTime > 0)
        {
            activeTime -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (activeTime <= 0)
        {
            isActive = true;
            activeTime = activeTimer;
        }
        else
        {
            return;
        }

        //StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.5f);
        isActive = false;
    }
}
