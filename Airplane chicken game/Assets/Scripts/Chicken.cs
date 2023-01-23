using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    
    //Variables
    private float jumpHight;


    //Call another script
    public GameManager gameManager;
    private Rigidbody2D rigidbody2;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
    if(Input.GetKeyDown(KeyCode.W) && (gameManager.chicken.transform.position.y <= 3 && gameManager.chicken.transform.position.y >= -3))
        Jump();
    else
    {
        gameManager.chicken.transform.rotation = new Quaternion(0,0,gameManager.chicken.transform.rotation.z-0.0009f,1);
    }
    
    }
    void Jump()
    {

        gameManager.chicken.transform.position = new Vector3 (gameManager.chicken.transform.position.x,(gameManager.chicken.transform.position.y+0.9f),0);       
        gameManager.chicken.transform.rotation = new Quaternion(0,0,gameManager.chicken.transform.rotation.z+0.09f,1);
    }
}


