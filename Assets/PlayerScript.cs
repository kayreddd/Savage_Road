 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int speed = 20;
    public Vector2 horizontalBounds;
    public Vector2 verticalBounds;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, y, 0) * speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, horizontalBounds.x, horizontalBounds.y), Mathf.Clamp(transform.position.y, verticalBounds.x, verticalBounds.y), 0);
        
    }
}
