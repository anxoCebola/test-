using UnityEngine;

public class DesplRotNAVE : MonoBehaviour
{
    public int speed;
    public int giro;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Rotate(Vector3.forward * Time.deltaTime * giro);




    }
}
