using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float minSpeed = 1f;
    public float maxSpeed = 3f;

    private float speed;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void FixedUpdate()
    {
        Vector2 jalan = new Vector2(-speed, 0);

        transform.Translate(jalan * Time.deltaTime);
    }
}
