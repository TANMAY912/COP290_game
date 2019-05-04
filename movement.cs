using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ff = 4000f, sf = 120f;
    public Vector3 dp;
    public bool moveu = false, moved = false, movel = false, mover = false, jump = false;
    void Start()
    {
        dp = transform.position;
        //Debug.Log(dp);
    }

    void Update()
    {
        moveu = Input.GetKey("w");
        movel = Input.GetKey("a");
        moved = Input.GetKey("s");
        mover = Input.GetKey("d");
        //jump = Input.GetKey("m");
    }
    void FixedUpdate()
    {
       //    rb.AddForce(0, 0, ff * Time.deltaTime);
            rb.AddForce(0,0,15 * Time.deltaTime, ForceMode.VelocityChange);
        if (mover)
        {
            rb.AddForce(sf * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (movel)
        {
            rb.AddForce(-sf * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(moveu)
        {
            rb.AddForce(0,0,sf * Time.deltaTime, ForceMode.VelocityChange);
   //         rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if(moved)
        {
            rb.AddForce(0,0,-sf * Time.deltaTime, ForceMode.VelocityChange);
 //           rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
    }
}