using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private Rigidbody rbPlayer;

    void Start()
    {

    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f,0.0f,speed);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbPlayer.AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbPlayer.AddForce(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbPlayer.AddForce(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rbPlayer.AddForce(Vector3.back * speed);
        }
    }
}