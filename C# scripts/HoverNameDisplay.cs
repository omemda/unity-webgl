using UnityEngine;
using UnityEngine.UI;

// A C# script for displaying text in a UI label. Changes label on mouse hover over object
public class HoverNameDisplay : MonoBehaviour
{
    public Text UILabel;
    public string displayedText;

    public void OnMouseOver()
    {
        UILabel.text = displayedText;
    }
    public void OnMouseExit()
    {
        UILabel.text = " ";
    }
}
