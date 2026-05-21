using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public Transform leftPos;
    public Transform centerPos;
    public Transform rightPos;

    private int lane = 1; // 0=ç∂, 1=íÜâõ, 2=âE

    void Awake()
    {
        Instance = this;
    }

    public void MoveLeft()
    {
        lane = Mathf.Max(0, lane - 1);
        UpdatePosition();
    }

    public void MoveRight()
    {
        lane = Mathf.Min(2, lane + 1);
        UpdatePosition();
    }

    void UpdatePosition()
    {
        switch (lane)
        {
            case 0:
                transform.position = leftPos.position;
                break;
            case 1:
                transform.position = centerPos.position;
                break;
            case 2:
                transform.position = rightPos.position;
                break;
        }
    }
}
