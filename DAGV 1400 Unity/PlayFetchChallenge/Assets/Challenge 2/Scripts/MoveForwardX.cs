using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed = 45.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
