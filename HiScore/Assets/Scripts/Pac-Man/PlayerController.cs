using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float MovementSpeed = 0.4f;
    public static int dots = 513;

    [Header("Inputs")]
    public KeyCode MoveLeft;
    public KeyCode MoveRight;
    public KeyCode MoveUp;
    public KeyCode MoveDown;

    Vector2 currentMovementDirection = Vector2.right;
    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.velocity = (currentMovementDirection * MovementSpeed) * Time.deltaTime;

    }

    void Update()
    {
        // Get the users input and set the movement direction. 
        // We check this in update because update runs every frame, 
        // polling input inside FixedUpdate can cause controls to feel unresponsive.
        
        currentMovementDirection = GetMovementDirection();
        if(dots < 480) {
            //print("Dots: " + dots);
            //SceneManager.LoadScene(sceneName: "InvadersLI");
        }
    }

    void OnTriggerEnter2D(Collider2D co) {
    	if(co.name == "Ghost") {
    		if(LivesScript.livesLeft == 1) {
    			print("Game Over");
    			LivesScript.livesLeft = 3;
                ScoringScript.scoreValue = 0;
                SceneManager.LoadScene(sceneName: "GameOver");
                //Application.LoadLevel(Application.loadedLevel);
    		}
    		else{
    			LivesScript.livesLeft--;
    			print("Lives: " + LivesScript.livesLeft);
    		}
        //513
    	}
        //print(co.name);
        if(co.name == "Key" || co.name == "Key1") {
            SceneManager.LoadScene(sceneName: "InvadersLI");
        }
    }

    Vector2 GetMovementDirection() {

        //Initial direction is zero ([0,0])
        Vector2 direction = Vector2.zero;

        //Set direction according to arrow keys
        if (Input.GetKey(MoveUp))
            direction =Vector2.up;
        else if (Input.GetKey(MoveDown))
            direction = -Vector2.up;
        else if (Input.GetKey(MoveLeft))
            direction = -Vector2.right;
        else if (Input.GetKey(MoveRight))
            direction = Vector2.right;

        return direction != Vector2.zero ? direction : currentMovementDirection;
    }
}