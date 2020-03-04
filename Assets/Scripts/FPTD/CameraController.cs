using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPTD
{
    public class CameraController : MonoBehaviour
    {
        public bool invert = false;
        public float smooth = 10f;
        private float angleX;

        // Start is called before the first frame update
        void Start()
        {
            //Quaternion rot = transform.rotation;
            //Debug.Log(rot.eulerAngles);
            //transform.rotation = rot;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            float angle = Input.GetAxis("Mouse Y");
            angle *= smooth * Time.deltaTime;

            if (invert) {
                angle *= -1;
            }

           // if (Input.GetAxis("Mouse Y") != 0f) {
             //   transform.Rotate(Vector3.right, angle);
            //}

            Quaternion rot = transform.rotation;
            Vector3 angel = rot.eulerAngles;

            //angle.x = Mathf.Clamp(rot.eulerAngles.x, -50f, 50);


            angleX += angle;
            angleX = Mathf.Clamp(angleX, -60f, 60f);

            transform.rotation = Quaternion.Euler(
                Vector3.right * angleX);


        }
    }
}