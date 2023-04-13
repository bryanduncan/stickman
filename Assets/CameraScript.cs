using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    float yVel = 0.01f;
    float xVel = 0.01f;
    float smoothTime = 0.3f;
    float newY;
    float newX;
    float xAvg;
    float yAvg;
    // Start is called before the first frame update
    void Start()
    {
        xAvg = (0 + player1.transform.position.x + player2.transform.position.x) / 3;
        yAvg = (0 + player1.transform.position.y + player2.transform.position.y) / 3;
    }

    // Update is called once per frame
    void Update()
    {
        xAvg = (0 + player1.transform.position.x + player2.transform.position.x) / 3;
        yAvg = (0 + player1.transform.position.y + player2.transform.position.y) / 3;
        Camera.main.transform.position = new Vector3(newX, newY, Camera.main.transform.position.z);
    }

    public void UpdateY()
    {
        newY = Mathf.SmoothDamp(transform.position.y, yAvg, ref yVel, smoothTime);
    }
    public void UpdateX()
    {
        newX = Mathf.SmoothDamp(transform.position.x, xAvg, ref xVel, smoothTime);
    }
}
