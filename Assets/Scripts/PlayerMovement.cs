using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb".
    public Rigidbody rb;

    public float forwardForce;
    public float sidewaysForce = 500f;
    public Slider slider;
    public static float Speed;


    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate ()
    {
        forwardForce = DataManager.Speed;

        rb.AddForce(0, 0, forwardForce * slider.value * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
