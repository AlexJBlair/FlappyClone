using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Move Speed: Bigger = faster pipe scroll
    public float moveSpeed = 13f;
    public float deadZone = -40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Debug.Log("Pipe Deleted!");
            Destroy(gameObject);
        }
    }
}
