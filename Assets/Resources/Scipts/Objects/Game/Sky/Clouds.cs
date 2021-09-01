/* 
 * ini adalah skrip untuk menggerakkan awan
 */

using UnityEngine;

public class Clouds : MonoBehaviour
{
    // mengatur minimum dan maximum kecepatan random
    public float minSpeed = 1f;
    public float maxSpeed = 3f;

    // kecepatan awan
    private float speed;

    void Start()
    {
        // mengatur kecepatan random
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void FixedUpdate()
    {
        // vector 2 menjalankan awan
        Vector2 jalan = new Vector2(-speed, 0);

        // menjalankan awan
        transform.Translate(jalan * Time.deltaTime);
    }
}
