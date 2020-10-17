using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public int speed;
    public bool xAxis;
    public int direction;
    public bool faceRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(xAxis == true && direction < 0 && faceRight == true) {
            transform.localScale = transform.localScale * -1;
        }
        else if(xAxis == true && direction > 0 && faceRight == false) {
            transform.localScale = transform.localScale * -1;
        }
        if(xAxis == true) {
            transform.Translate(new Vector3(direction * speed * Time.deltaTime, 0, 0));
        }
        else {
            transform.Translate(new Vector3(0, direction * speed * Time.deltaTime, 0));
        }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "car") {
            
        }
        else if(collision.gameObject.tag == "traffic") {
            
        }
        else if(collision.gameObject.tag == "end"){
            Destroy(gameObject);
        }
    }
}
