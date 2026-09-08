using UnityEngine;

public class CameraToggler : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    // Start is called once before the first ex
    // ecution of Update after the MonoBehaviour is created
    private void Start()
    {
        cameraOne.enabled = true;
        cameraTwo.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraOne.enabled = !cameraOne.enabled;
            cameraTwo.enabled = !cameraTwo.enabled;
        }
    }
}
