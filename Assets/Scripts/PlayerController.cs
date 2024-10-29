using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 19;
    public Transform NaveTOTAL;
    public int giro = 30;

    void Start()
    {

    }


    void Update()
    {
       
        float rotY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * rotY * Time.deltaTime * speed);
        float desZ = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * desZ * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * giro);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * giro);

        }



        if (NaveTOTAL.transform.position.y < -30)
        {
            NaveTOTAL.transform.position = Vector3.zero;

        }

    }
}