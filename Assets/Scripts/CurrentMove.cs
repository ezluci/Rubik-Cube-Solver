using UnityEngine;

public class CurrentMove : MonoBehaviour
{
    public string currentMoveVar;
    public string oldCurrentMoveVar;
    public UnityEngine.UI.Text textComponent;

    void Start()
    {
        oldCurrentMoveVar = currentMoveVar;
    }

    void Update()
    {
        if (oldCurrentMoveVar != currentMoveVar)
        {
            textComponent.text = currentMoveVar;
            oldCurrentMoveVar = currentMoveVar;
        }
    }
}
