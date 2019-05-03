using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float speedZ;
    
    public Rigidbody rb;
    public float thrust;

    private bool forceFalling = false;
    
    private bool isGrounded = true;

    public int distance = 0;
    private int startPos;
    
    public float speedX = -10;

    // Start is called before the first frame update
    void Start() {
        startPos = (int) transform.position.x;
        Cursor.visible = false;
        //rb = GetComponent<Rigidbody>();
        BarrierSpawner.player = gameObject;
        StartCoroutine("IncreaseSpeed");
    }

    // Update is called once per frame
    void Update() {

        distance = startPos - (int) transform.position.x;
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        
        
        
        transform.eulerAngles = new Vector3(0, -0, 0);
        if (transform.position.z < 3 && transform.position.z > -3) {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                transform.Translate(0,0, Time.deltaTime * speedZ);
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                transform.Translate(0,0, Time.deltaTime * -speedZ);
        }


        if (isGrounded && Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity += thrust * Vector3.up;
            isGrounded = false;
        }
        if (!isGrounded && !forceFalling && Input.GetKey(KeyCode.DownArrow)) {
            rb.velocity += thrust * Vector3.down;
            forceFalling = true;
        }


        if (transform.position.z > 2) {
            transform.position = new Vector3(transform.position.x, transform.position.y, 2);
        }
        if (transform.position.z < -2) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2);
        }
    }

    IEnumerator IncreaseSpeed() {
        while (true) {
            speedX *= 1.01f;
            FloorSpawner.setSpeed(speedX);
            yield return new WaitForSeconds(1);
        }
    }



    void OnCollisionEnter(Collision other) {
            print("Collided!");
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            isGrounded = true;
            forceFalling = false;
    }
    
    private void OnTriggerEnter(Collider other) {
        Cursor.visible = true;
        SceneManager.LoadScene("GameOver");
    }

}