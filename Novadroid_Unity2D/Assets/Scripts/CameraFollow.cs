using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    /*private Vector2 velocity;
    public float smoothTimeY;
    public float smoothTimeX;
    public GameObject player;

    void Start () {

        player = GameObject.FindGameObjectsWithTag("Player");
	}
	
    void FIdesUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }*/
    //[SerializeField] = To make the private variable visible in the inspector.
    //private float xMax;
  
    private Transform target;
    public float yOffset;

    void Start() {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        //Vector3(0,0,0)
        transform.position = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);
    }
}
