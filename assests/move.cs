using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 40.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
