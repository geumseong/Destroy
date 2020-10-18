using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    public int speed;
    public bool xAxis;
    public int direction;
    public string face;
    public Sprite car1;
    public Sprite car2;
    Vector3 traffic1;
    Vector3 traffic2;
    Vector3 traffic3;
    Vector3 traffic4;
    // Start is called before the first frame update
    void Start()
    {
        traffic1 = GameObject.Find("TrafficCollider1").transform.position;
        traffic2 = GameObject.Find("TrafficLight1 (1)").transform.position;
        traffic3 = GameObject.Find("TrafficLight1 (2)").transform.position;
        traffic4 = GameObject.Find("TrafficLight1 (3)").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(face == "right") {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            this.GetComponent<SpriteRenderer>().sprite = car1;
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        else if(face == "left") {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            this.GetComponent<SpriteRenderer>().sprite = car2;
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if(face == "up") {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            this.GetComponent<SpriteRenderer>().sprite = car1;
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        else {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            this.GetComponent<SpriteRenderer>().sprite = car1;
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if(transform.position.x > -6.1 && transform.position.x < -5.5 && transform.position.y < 2.5 && transform.position.y > 1.9) {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count1 % 4){
                case 0: //Right
                    face = "right";
                    break;
                case 1: //Left
                    face = "left";
                    break;
                case 2: //Up
                    face = "up";
                    break;
                case 3: //Down
                    face = "down";
                    break;
            }
        }
        if(transform.position.x > -6.1 && transform.position.x < -5.5 && transform.position.y < -2.38 && transform.position.y > -2.98) {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count2 % 4){
                case 0: //Right
                    face = "right";
                    break;
                case 1: //Left
                    face = "left";
                    break;
                case 2: //Up
                    face = "up";
                    break;
                case 3: //Down
                    face = "down";
                    break;
            }
        }
        if(transform.position.x > 5.01 && transform.position.x < 5.61 && transform.position.y < 2.5 && transform.position.y > 1.9) {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count4 % 4){
                case 0: //Left
                    face = "left";
                    break;
                case 1: //Up
                    face = "up";
                    break;
                case 2: //Down
                    face = "down";
                    break;
                case 3: //Right
                    face = "right";
                    break;
            }
        }
        if(transform.position.x > 5.01 && transform.position.x < 5.61 && transform.position.y < -2.38 && transform.position.y > -2.98) {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count3 % 4){
                case 0: //Left
                    face = "left";
                    break;
                case 1: //Up
                    face = "up";
                    break;
                case 2: //Down
                    face = "down";
                    break;
                case 3: //Right
                    face = "right";
                    break;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "car") {
            
        }
        /*else if(collision.tag == "traffic1") {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count1 % 4){
                case 0: //Right
                    face = "right";
                    break;
                case 1: //Left
                    face = "left";
                    break;
                case 2: //Up
                    face = "up";
                    break;
                case 4: //Down
                    face = "down";
                    break;
            }
        }
        else if(collision.tag == "traffic2") {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count2 % 4){
                case 0: //Right
                    face = "right";
                    break;
                case 1: //Left
                    face = "left";
                    break;
                case 2: //Up
                    face = "up";
                    break;
                case 4: //Down
                    face = "down";
                    break;
            }
        }
        else if(collision.tag == "traffic3") {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count3 % 4){
                case 0: //Left
                    face = "left";
                    break;
                case 1: //Up
                    face = "up";
                    break;
                case 2: //Down
                    face = "down";
                    break;
                case 4: //Right
                    face = "right";
                    break;
            }
        }
        else if(collision.tag == "traffic4") {
            switch(GameObject.Find("TrafficController").GetComponent<TrafficLight>().count4 % 4){
                case 0: //Left
                    face = "left";
                    break;
                case 1: //Up
                    face = "up";
                    break;
                case 2: //Down
                    face = "down";
                    break;
                case 4: //Right
                    face = "right";
                    break;
            }
        }*/
        else if(collision.tag == "end"){
            Destroy(this);
        }
    }
}
