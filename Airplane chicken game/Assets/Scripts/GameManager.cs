using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Make the background
    public Renderer backGroundGame;

    //Chicken
    public GameObject chicken;

    // Start is called before the first frame update
    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {
        
        //Continue move to the background
        backGroundGame.material.mainTextureOffset = backGroundGame.material.mainTextureOffset + new Vector2(0.20f,0) * Time.deltaTime; 

    }
}
