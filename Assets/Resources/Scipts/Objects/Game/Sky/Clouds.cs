/* 
 * ini adalah skrip untuk awan
 */

using System.Collections;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    // mengatur minimum dan maximum kecepatan random
    public float minSpeed = 1f;
    public float maxSpeed = 3f;

    // waktu mati
    public float lifeTime = 6f;

    // kecepatan awan
    private float speed;

    private bool isDead = false;

    // warna render
    private Renderer rend;
    private Color warnaAwan;

    void Start()
    {
        // mengatur kecepatan random
        speed = Random.Range(minSpeed, maxSpeed);

        StartCoroutine(hancurkanAwan());
        alphaAwan();
    }

    // fucntion untuk mengubah warna dan opacity (alpha) untuk awan
    private void alphaAwan()
    {
        warnaAwan = new Vector4(1, 1, 1, Random.Range(.5f, .8f));

        rend = gameObject.GetComponent<Renderer>();
        rend.material.color = warnaAwan;
    }

    private void FixedUpdate()
    {
        if (isDead)
        {
            Destroy(gameObject);
        }
        else
        {
            // vector 2 menjalankan awan
            Vector2 jalan = new Vector2(-speed, 0);

            // menjalankan awan
            transform.Translate(jalan * Time.deltaTime);
        }
    }

    private IEnumerator hancurkanAwan()
    {
        yield return new WaitForSeconds(lifeTime);
        isDead = true;
    }
}
