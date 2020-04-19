using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles4 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(4);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
