using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour

{
    private Rigidbody2D myBody;

    void Awake() =>
        myBody = GetComponent<Rigidbody2D>(); 


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            myBody.MovePosition(myBody.position + Vector2.right);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            myBody.MovePosition(myBody.position + Vector2.left);
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
            myBody.MovePosition(myBody.position + Vector2.up);
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
            myBody.MovePosition(myBody.position + Vector2.down);

     /*   // for android..

        if (Input.GetMouseButtonDown(0))
        {
            myBody.MovePosition(myBody.position + Vector2.up);
        }

        */
    } //Update 

    void OnTriggerEnter2D(Collider2D target)
    {
        Debug.Log("hi");

        if (target.tag == "Blender2")
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

        }
    }

} // class
