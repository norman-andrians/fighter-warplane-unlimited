/*
 * skrip ini berfungsi untuk mengatur munculnya awan
 */

using UnityEngine;
using System.Collections;

public class CloudsSpawner : MonoBehaviour
{
    // objek awan
    public GameObject[] awan;
    // delay munculkan awan
    public float delay = 20f;

    public bool debugTest = false;

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

        // memulai memunculkan awan
        StartCoroutine(munculkanAwan());
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // untuk test
        if (debugTest)
        {
            if (Input.GetKeyDown(KeyCode.P))
                membuatAwan();
        }
    }

    // function untuk membuat awan
    private void membuatAwan()
    {
        int seedIndex = Random.Range(0, awan.Length);

        float posx = Random.Range(transform.position.x - 10f, transform.position.x + 10f);
        float posy = Random.Range(transform.position.y - 10f, transform.position.y + 10f);
        Vector2 posisiAwan = new Vector2(posx, posy);

        var awanBiasa = Instantiate(awan[seedIndex], posisiAwan, Quaternion.identity);

        awanBiasa.transform.parent = gameObject.transform;

        Debug.Log("munculkan awan");
    }

    // function untuk memunculkan awan
    private IEnumerator munculkanAwan()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            membuatAwan();
        }
    }
}
