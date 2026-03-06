using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    public float zMin;
    public float zMax;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime*speed);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, zMin);
        }
        
        if (transform.position.x > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);   
        }
    }
}
