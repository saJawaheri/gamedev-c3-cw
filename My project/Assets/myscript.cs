using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class myscript : MonoBehaviour
{//player movment

    void OnMouseDrag()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = playerPos;
    }

    void OnCollisionEnter2D(Collision2D other){
        SceneManager.LoadScene("easy lvl");
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag== "Finish") { 
        }
        SceneManager.LoadScene("imposible lvl");

    

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
