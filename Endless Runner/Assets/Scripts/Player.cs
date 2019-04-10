using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float speedZ;
    
    public Rigidbody rb;
    public float thrust;
    
    private bool isGrounded = true;
    
    public static int speedX = -5;

    // Start is called before the first frame update
    void Start() {
        //rb = GetComponent<Rigidbody>();
        BarrierSpawner.player = gameObject;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        
        
        
        transform.eulerAngles = new Vector3(0, -0, 0);
        if (transform.position.z < 3 && transform.position.z > -3) {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                transform.Translate(0,0, Time.deltaTime * speedZ);
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                transform.Translate(0,0, Time.deltaTime * -speedZ);
        }


        if (isGrounded && Input.GetKey(KeyCode.Space)) {
            rb.velocity += thrust * Vector3.up;
            isGrounded = false;
        }


        if (transform.position.z > 2) {
            transform.position = new Vector3(transform.position.x, transform.position.y, 2);
        }
        if (transform.position.z < -2) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2);
        }
    }

    void OnCollisionEnter(Collision other) {
            print("Collided!");
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            isGrounded = true;
    }
    
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Start");
    }
}