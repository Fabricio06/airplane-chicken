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
        {
            gameManager.chicken.transform.position = new Vector3 (-8.38f,gameManager.chicken.transform.position.y+0.5f,0);
            
        }
    }

}


