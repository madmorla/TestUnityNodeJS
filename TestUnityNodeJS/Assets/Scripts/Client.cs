using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class Client : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI hourText;
	const string url = "http://localhost:8000/";


    void Start()
	{
		
	}

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
			hourText.color = Color.white;

		}
		else
		{
			hourText.text = "ERROR de conexi�n";
			hourText.color = Color.red;
		}
	}
}
