using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed = 5f;

    void Start() {
        //vidio 1
        //this.transform.Translate(goal.transform.position);
        //this.transform.Translate(6,0,2);

        //vidio 2
        //direction = goal.transform.position - this.transform.position;
        //this.transform.position = this.transform.position + direction;
        //this.transform.Translate(direction);
    }

    private void Update() {
        //vidio 2
        //this.transform.position = this.transform.position + direction * 0.01f;
        //this.transform.position = this.transform.position + direction.normalized;
        //direction = goal.transform.position - this.transform.position;
        //Vector3 velocity = direction.normalized * speed*Time.deltaTime;
        //this.transform.position = this.transform.position + velocity;

        //vidio 3
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude > 2 ) {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
