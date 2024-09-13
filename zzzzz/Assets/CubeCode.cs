using UnityEngine;

public class CubeCode : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce ;
    public float sidewaysForce ;
    private float screenWidth;

    private void  Start() 

    {
      screenWidth = Screen.width / 2;

    }
    
    void Update()

    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        //TouchMove();
        keyboardControl();

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }


    void keyboardControl()

    {
         if ( Input.GetKey ("d") )
        
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        
        }

        if ( Input.GetKey ("a") )
        
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        
        }

    } 










    /*void TouchMove()
    {

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            

            if (touch.position.x > screenWidth)

            {
               rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
            }


            else if (touch.position.x < screenWidth)

            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
            }


        }

    }*/
}