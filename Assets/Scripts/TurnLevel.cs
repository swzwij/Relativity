using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLevel : MonoBehaviour
{
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
