using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class Client : MonoBehaviour
{
	const string url = "http://localhost:8000/";
	
	[SerializeField] TextMeshProUGUI hourText;
	
	public void OnConnectClick()
	{
		StartCoroutine(TryConnection());
	}

	private IEnumerator TryConnection()
	{
		UnityWebRequest request = UnityWebRequest.Get(url);

		yield return request.SendWebRequest();

		if(request.result == UnityWebRequest.Result.Success)
		{
			hourText.text = $"Current Hour: {request.downloadHandler.text}";
		}
		else
		{
			PopUpUI.Instance.SetTitle("Error!")
				.SetMessage("No se ha podido establecer la conexión.")
				.Show();
		}
	}
}
