using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLevel : MonoBehaviour
{
    [SerializeField] private int dir;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) Up();
        if (Input.GetKeyDown(KeyCode.O)) Right();
        if (Input.GetKeyDown(KeyCode.I)) Down();
        if (Input.GetKeyDown(KeyCode.U)) Left();
    }

    public void Up()
    {
        gameObject.transform.Rotate(0, 0, 0);
    }

    public void Right()
    {
        gameObject.transform.Rotate(0, 0, 90);
    }

    public void Down()
    {
        gameObject.transform.Rotate(0, 0, 180);
    }

    public void Left()
    {
        gameObject.transform.Rotate(0, 0, 270);
    }
}
