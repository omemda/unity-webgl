
using UnityEngine;
using UnityEngine.UI;

// A C# script to change camera position and replace UI labet text with required input
public class ChangeTarget : MonoBehaviour
{
    public Text UILabel;
    public string displayedText;
    public GameObject getTarget;

    public void SwitchTarget()
    {
        UILabel.text = displayedText;
        Camera.main.GetComponent<CameraRot>().target = getTarget.transform;
    }

}
