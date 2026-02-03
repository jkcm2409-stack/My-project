using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Camra : MonoBehaviour
{
    public GameObject fmale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX;

        mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;

        transform.position = new Vector3(mouseX, transform.position.y,transform. position.z); 

        float mouseY;

        mouseY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        transform.position = new Vector3(transform.position.x, mouseY ,transform. position.z);
    }
    private void OnCollisionStay2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "light") 
        {
            if(Input.GetKeyDown(KeyCode.W)) 
            {
                  Debug.Log("hi");
            }
        }
    }
}
