using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TP : MonoBehaviour
{
    [SerializeField] private GameObject TPA;
    [SerializeField] private GameObject TPB;

    [SerializeField] private GameObject player;
    [SerializeField] private float playerSpeed;

    private TPcollider tpaCol;
    private TPcollider tpbCol;

    [SerializeField] private UnityEvent turnLVL;

    private void Awake()
    {
        tpaCol = TPA.GetComponent<TPcollider>();
        tpbCol = TPA.GetComponent<TPcollider>();
    }

    private void Update()
    {
        if (tpaCol.isActive == true)
        {
            var playerMove = player.GetComponent<PlayerMovement>();
            playerMove.speed *= playerSpeed;

            turnLVL?.Invoke();
            player.transform.position = TPB.transform.position;
            tpaCol.isActive = false;
        }

        if(tpbCol.isActive == true)
        {
            var playerMove = player.GetComponent<PlayerMovement>();
            playerMove.speed *= playerSpeed;

            turnLVL?.Invoke();
            player.transform.position = TPA.transform.position;
            tpbCol.isActive = false;
        }
    }
}
