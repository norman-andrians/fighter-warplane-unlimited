using System.Collections;
using UnityEngine;

public class CloudsSpawner : MonoBehaviour
{
    public GameObject[] awan;
    public float delay = 2f;

    private float posx;
    private float posy;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos1 = new Vector2(3f, 4f);
        Vector2 pos2 = new Vector2(4f, -3f);
        
        var awan1 = Instantiate(awan[0], pos1, Quaternion.identity);
        var awan2 = Instantiate(awan[1], pos2, Quaternion.identity);

        awan1.transform.parent = gameObject.transform;
        awan2.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator munculkanAwan()
    {
        while (true)
        {
            int seedIndex = Random.Range(0, awan.Length);

            posx = Random.Range(transform.position.x - 10f, transform.position.x + 10f);
            posy = Random.Range(transform.position.y - 10f, transform.position.y + 10f);

            Instantiate(awan[seedIndex], new Vector2(posx, posy), Quaternion.identity);

            yield return new WaitForSeconds(delay);
        }
    }
}
