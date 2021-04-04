using UnityEngine;
using System.Collections;

public class Aim: MonoBehaviour
{

    void Update()
    {
        Vector3 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); //kijkt naar de muis

    }
}