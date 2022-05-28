using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private GameObject destination;
    public int rotation;

    public GameObject GetDestination()
    {
        return destination;
    }
}
