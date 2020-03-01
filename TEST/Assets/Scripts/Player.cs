using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincremento,Xincremento;
    public float speed;
    public float minHeight;
    public float maxHeight;
    public float minWidth;
    public float maxWidth;

    public int health=3;

    // Update is called once per frame
    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincremento);
            
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincremento);
                    }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minWidth )
        {
            targetPos = new Vector2(transform.position.x - Xincremento,transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxWidth)
        {
            targetPos = new Vector2(transform.position.x + Xincremento,transform.position.y );
        }

    }
     
    
}
