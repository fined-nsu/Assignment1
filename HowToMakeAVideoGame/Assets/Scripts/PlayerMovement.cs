using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 4000f;
    public float sidewaysForce = 120f;
    private float newSpeed = 1f;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, (forwardForce * newSpeed)  * Time.deltaTime);
        
        if (Input.GetKey("d"))
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
    public void UpdateSpeed(float sliderValue)
    {
        newSpeed = sliderValue;
    }
}