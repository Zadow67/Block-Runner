using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float offset;
    public Transform playertransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.z = playertransform.position.z + offset;
        transform.position = cameraPos;
    }
}
