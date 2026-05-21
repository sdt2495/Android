using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // ‰º‚ÉˆÚ“®
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // ‰æ–ÊŠO‚Éo‚½‚çíœ
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
