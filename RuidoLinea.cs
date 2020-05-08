using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuidoLinea : MonoBehaviour
{
	public LineRenderer linea1;
	public LineRenderer linea2;
	public float		periodo;
	public int          cuantasPartes;
	public float		magnitud;

    void Start()
	{
		linea2.positionCount = cuantasPartes;
		StartCoroutine(Actualizar());
	}

	IEnumerator Actualizar()
    {
		for (int i = 0; i < cuantasPartes; i++)
		{
			Vector3 nPos = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),Random.Range(-1f,1f));
			nPos = nPos * magnitud;
			nPos.z = (linea1.GetPosition(1).z / cuantasPartes) * i;
			linea2.SetPosition(i, nPos);
		}
		yield return new WaitForSeconds(periodo);
		StartCoroutine(Actualizar());
    }
}
