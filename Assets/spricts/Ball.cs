using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    float power =10f;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce((transform.right + transform.forward) * power,ForceMode.Impulse);
        
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Finish"){
            Destroy(this.gameObject);
            gameover.SetActive(true);
        }
    }

}
