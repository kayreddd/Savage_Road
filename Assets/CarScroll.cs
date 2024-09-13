using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScroll : MonoBehaviour
{
    public float scrollSpeed = 10f; 
    public float destroyY = -10f; 


    void Update()
    {
        ScrollCar();
    }

    void ScrollCar()
    {

        transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime, Space.World);


        if (transform.position.y <= destroyY)
        {

            gameObject.SetActive(false);

        }
    }
}
