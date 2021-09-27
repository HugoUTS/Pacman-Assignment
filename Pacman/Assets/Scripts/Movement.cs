using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 4.0f;

    private Vector2 direction = Vector2.zero;

    //To Start
    void Start()
    {
        
    }
    // Update per frame
    void Update()
    {
        CheckInput();

        Move ();
        
    }

    void CheckInput ()
    {
        if (Input.GetKeyDown(KeyCode.A))

            direction = Vector2.left;

        else if (Input.GetKeyDown(KeyCode.D))
            direction = Vector2.right;

        else if (Input.GetKeyDown(KeyCode.W))
            direction = Vector2.up;

        else if (Input.GetKeyDown(KeyCode.S))
            direction = Vector2.down;
    }

    void Move ()
    {
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }
}


