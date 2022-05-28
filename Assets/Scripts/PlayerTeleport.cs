using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    [SerializeField] private GameObject lvl;
    private GameObject currentTeleporter;
    public float lastTeleport;

    private void Update()
    {
        lastTeleport += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;

            if (currentTeleporter != null && lastTeleport > 1)
            {
                var destination = currentTeleporter.GetComponent<Teleporter>().GetDestination();
                var destinationRotation = destination.GetComponent<Teleporter>().rotation;

                if (destinationRotation == 1)
                {
                    lvl.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (destinationRotation == 2)
                {
                    lvl.transform.eulerAngles = new Vector3(0, 0, 90);
                }
                if (destinationRotation == 3)
                {
                    lvl.transform.eulerAngles = new Vector3(0, 0, 180);
                }
                if (destinationRotation == 4)
                {
                    lvl.transform.eulerAngles = new Vector3(0, 0, 270);
                }

                lastTeleport = 0;
                transform.position = destination.gameObject.transform.position;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            if(collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
