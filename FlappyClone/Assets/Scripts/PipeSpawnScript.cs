using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
	public GameObject Pipe;
    // spawnRate: Smaller = quicker spawn
	public float spawnRate = 1.75f;
	private float timer = 0f;
    // heightOffset: Bigger = more drastic pipe variation
    public float heightOffset = 7.6f;
	// Start is called before the first frame update
	void Start()
	{
        spawnPipe();
	}

	// Update is called once per frame
	void Update()
	{
		if (timer < spawnRate)
		{
			timer = timer + Time.deltaTime;
		}
		else
		{
			spawnPipe();
            timer = 0f;
		}
	}
    void spawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}
