using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aca es el start");
        gameObject.transform.position = new Vector3(0,-1.94f,0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("aca es el updated");
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2f * Time.deltaTime,0,0);

        // movimiento derecha - izquierda
        if (Input.GetKey("right") && (gameObject.transform.position.x < 8.63) )
        {
            gameObject.transform.Translate(3.5f * Time.deltaTime,0,0);
        }
        else if (Input.GetKey("left")  && (gameObject.transform.position.x >= -10.2))
        {
            gameObject.transform.Translate(-3.5f * Time.deltaTime,0,0);
        
        }

        if (Input.GetKey("up") && gameObject.transform.position.y < 4)
        {
            gameObject.transform.Translate(0, 3.5f * Time.deltaTime, 0);
        }
            
    }
}
