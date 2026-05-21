using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;  
    public Canvas canvas;              

    public Transform leftLane;
    public Transform centerLane;
    public Transform rightLane;

    public float interval = 1.0f;

    void Start()
    {
        Debug.Log("Spawner Start: InvokeRepeating 開始");
        InvokeRepeating(nameof(Spawn), 1f, interval);
    }

    void Spawn()
    {
        Debug.Log("Spawn 実行");

        Transform[] lanes = { leftLane, centerLane, rightLane };

        Transform lane = lanes[Random.Range(0, lanes.Length)];
        Debug.Log("選ばれたレーン: " + lane.name);

        GameObject obj = Instantiate(obstaclePrefab, canvas.transform);
        Debug.Log("生成されたオブジェクト: " + obj.name);

        RectTransform rt = obj.GetComponent<RectTransform>();
        RectTransform laneRT = lane.GetComponent<RectTransform>();

        if (rt == null)
        {
            Debug.LogError("RectTransform が見つかりません！UI プレハブですか？");
            return;
        }

        if (laneRT == null)
        {
            Debug.LogError("レーンに RectTransform がありません！UI レーンですか？");
            return;
        }

        rt.anchoredPosition = laneRT.anchoredPosition;
        rt.localScale = Vector3.one;
        rt.localRotation = Quaternion.identity;

        Debug.Log("UI の生成位置（anchoredPosition）: " + rt.anchoredPosition);
    }
}
