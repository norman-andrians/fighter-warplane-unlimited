/*
 * skrip ini berfungsi untuk mengatur munculnya awan
 */

using UnityEngine;

public class CloudsSpawner : MonoBehaviour
{
    // objek awan
    public GameObject[] awan;
    // delay munculkan awan
    public float delay = 20f;

    // posisi vector 2
    private float posx;
    private float posy;

    // waktu tiap frame
    private float waktu;

    // Start is called before the first frame update
    void Start()
    {
        // mengatur posisi vector 2 awan untuk pertama
        Vector2 pos1 = new Vector2(3f, 4f);
        Vector2 pos2 = new Vector2(4f, -3f);
        
        // memunculkan awan
        var awan1 = Instantiate(awan[0], pos1, Quaternion.identity);
        var awan2 = Instantiate(awan[1], pos2, Quaternion.identity);

        awan1.transform.parent = gameObject.transform;
        awan2.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // memulai waktu
        waktu += Time.deltaTime;
        // memunculkan awan
        munculkanAwan();

        Debug.Log("waktu: " + waktu.ToString("F2"));
    }

    // function untuk memunculkan awan
    private void munculkanAwan()
    {
        // memunculkan awan setiap delay
        while (true)
        {
            if (waktu%delay == 0)
            {
                int seedIndex = Random.Range(0, awan.Length);

                posx = Random.Range(transform.position.x - 10f, transform.position.x + 10f);
                posy = Random.Range(transform.position.y - 10f, transform.position.y + 10f);

                Instantiate(awan[seedIndex], new Vector2(posx, posy), Quaternion.identity);

                Debug.Log("munculkan awan");
            }
        }
    }
}
