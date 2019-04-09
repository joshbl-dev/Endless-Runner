using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float speed;
    
    public Rigidbody rb;
    public float thrust;
    
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start() {
        //rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        
//        var angle = Mathf.Atan2(Input.mousePosition.y, Input.mousePosition.x) * Mathf.Rad2Deg;
//        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); 
        
        transform.eulerAngles = new Vector3(0, -0, 0);
        if (transform.position.z < 3 && transform.position.z > -3) {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                transform.Translate(0,0, Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                transform.Translate(0,0, Time.deltaTime * -speed);
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
            isGrounded = true;
    }
    
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Start");
    }
}