using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject Bullets;
    public Transform BulletPos;


    public float sensitivity = 500f; //감도 설정
    float rotationX = 0.0f;  //x축 회전값
    float rotationY = 0.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        rotationX += x * sensitivity * Time.deltaTime;
        rotationY += y * sensitivity * Time.deltaTime;

        if (rotationY > 30)
        {
            rotationY = 30;
        }
        else if (rotationY < -30)
        {
            rotationY = -30;
        }
        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);


        if (Input.GetMouseButtonUp(0))
        {
            GameObject Bullet = Instantiate(Bullets,BulletPos.position,transform.localRotation);

        }

    }

}
