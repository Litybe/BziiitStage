using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamGyroAR : MonoBehaviour {
    public GameObject webPlane;
    public RenderTexture curved;
    GameObject cameraParent;
	// Use this for initialization
	void Start () {
        if (Application.isMobilePlatform)
        {
            cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right, 90);
        }
        Input.gyro.enabled = true;

        WebCamTexture webcamTexture = new WebCamTexture();
        webPlane.GetComponent<MeshRenderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
	
	// Update is called once per frame
	void Update () {
        Quaternion rotFix = new Quaternion(Input.gyro.attitude.x,
                                            Input.gyro.attitude.y,
                                            -Input.gyro.attitude.z,
                                            -Input.gyro.attitude.w);
        this.transform.localRotation = rotFix;
                                        
	}
}
