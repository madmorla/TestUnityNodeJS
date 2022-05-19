using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialog
{
	public string title = "Title";
	public string message = "Message goes here.";
}

public class PopUpUI : MonoBehaviour
{
	[SerializeField] GameObject canvas;
	[SerializeField] TextMeshProUGUI titleUIText;
	[SerializeField] TextMeshProUGUI messageUIText;
	[SerializeField] Button closeUIButton;

	Dialog dialog = new Dialog();

	//Singleton pattern
	public static PopUpUI Instance;
	
	void Awake()
	{
		Instance = this;

		//Add close event listener
		closeUIButton.onClick.RemoveAllListeners();
		closeUIButton.onClick.AddListener(Hide);
	}
		
	public PopUpUI SetTitle(string title)
	{
		dialog.title = title;
		return Instance;
	}
		
	public PopUpUI SetMessage(string message)
	{
		dialog.message = message;
		return Instance;
	}

	public void Show()
	{
		titleUIText.text = dialog.title;
		messageUIText.text = dialog.message;

		canvas.SetActive(true);
	}

	public void Hide()
	{
		canvas.SetActive(false);

		//Reset Dialog
		dialog = new Dialog();
	}
}
