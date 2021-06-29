using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator_Items : MonoBehaviour
{


    [SerializeField]
    private float XCuadrantesSize;
    [SerializeField]
    private float YCuadrantesSize;
    [SerializeField]
    private float ZCuadrantesSize;


    [SerializeField]
    private GameObject recuerdosVida_Object;
    [SerializeField]
    private GameObject recuerdosFuerza_Object;
    [SerializeField]
    private GameObject recuerdosVelocidad_Object;


    private MazeGenerator_Sala[,,] mapa;

    private GameObject RecuerdoTrauma;


    private void GenerarRecuerdos(MazeGenerator_Sala sala, float posicionX, float posicionY, float posicionZ)
    {

        for (int e = 1; e <= sala.getNumeroRecuerdos() + 1; e++)
        {
            float desfacex = 0, desfacez = 0;
            switch (e)
            {
                case 1: desfacex = -3.5f; desfacez = 3.5f; break;
                case 2: desfacex = 3f; desfacez = 3.5f; break;
                case 3: desfacex = 3.5f; desfacez = -3.5f; break;
                case 4: desfacex = -3.5f; desfacez = -3.5f; break;
            }
            switch (Random.Range(1, 4))
            {
                case 1:
                    GameObject recuerdoFuerza = Instantiate(recuerdosFuerza_Object, new Vector3(posicionX + desfacex, posicionY + recuerdosFuerza_Object.transform.lossyScale.y / 2, posicionZ + desfacez), new Quaternion());
                    break;
                case 2:
                    GameObject recuerdoVelocidad = Instantiate(recuerdosVelocidad_Object, new Vector3(posicionX + desfacex, posicionY + recuerdosVelocidad_Object.transform.lossyScale.y / 2, posicionZ + desfacez), new Quaternion());

                    break;
                case 3:
                    GameObject recuerdoVida = Instantiate(recuerdosVida_Object, new Vector3(posicionX + desfacex, posicionY + recuerdosVida_Object.transform.lossyScale.y / 2, posicionZ + desfacez), new Quaternion());
                    break;
            }

        }
    }
    private void generarItems()
    {

        for (int z = 0; z < mapa.GetLength(2); z++)
        {

            for (int y = 0; y < mapa.GetLength(1); y++)
            {

                for (int x = 0; x < mapa.GetLength(0); x++)
                {
                    if (mapa[x, y, z] != null)
                    {

                        if (mapa[x, y, z].getTipoSala().Equals("sala"))
                        {
                            switch (mapa[x, y, z].getNivelDificultad())
                            {
                                case 0:
                                    GenerarRecuerdos(mapa[x, y, z], x * XCuadrantesSize, (y * YCuadrantesSize), z * ZCuadrantesSize);
                                    break;
                                case 1:
                                    GenerarRecuerdos(mapa[x, y, z], x * XCuadrantesSize, (y * YCuadrantesSize), z * ZCuadrantesSize);
                                    break;
                                case 2: GenerarRecuerdos(mapa[x, y, z], x * XCuadrantesSize, (y * YCuadrantesSize), z * ZCuadrantesSize); break;
                                case 3:
                                    GenerarRecuerdos(mapa[x, y, z], x * XCuadrantesSize, (y * YCuadrantesSize), z * ZCuadrantesSize);
                                    break;
                            }
                        }
                    }
                }


            }


        }
    }




    // Start is called before the first frame update
    void Start()
    {
        mapa = FindObjectOfType<MazeGenerator_MapGenerator>().getMapa();
        generarItems();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
