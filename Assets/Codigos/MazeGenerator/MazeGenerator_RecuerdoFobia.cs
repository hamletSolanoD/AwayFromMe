using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator_RecuerdoFobia : MonoBehaviour
{


  
   [SerializeField]
    private float XCuadrantesSize;
    [SerializeField]
    private float YCuadrantesSize;
    [SerializeField]
    private float ZCuadrantesSize;
    private MazeGenerator_Sala[,,] mapa;

    [SerializeField]
    private GameObject recuerdosTrauma_Object;

    [SerializeField]
    private GameObject FobiaParedPrefab;





    private GameObject RecuerdoTrauma;


    // Start is called before the first frame update
    void Start()
    {
        mapa = FindObjectOfType<MazeGenerator_MapGenerator>().getMapa();
        generarRecuerdoFobia();
        GenerarParedFobiaNorte();
        GenerarParedFobiaEste();
        GenerarParedFobiaOeste();
        GenerarParedFobiaSur();

        
    }
    private void generarRecuerdoFobia()
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
                                case 3:
                                    RecuerdoTrauma = Instantiate(recuerdosTrauma_Object, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize), z * ZCuadrantesSize), new Quaternion());
                                    break;
                            }
                        }
                     
                    }


                }


            }


        }
    }
    private void GenerarParedFobiaNorte()
    {
        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int x = 0; x < mapa.GetLength(0); x++)
            {
                salaAnterior = null;
                for (int z = mapa.GetLength(2) - 1; z >= 0; z--)
                {

                    if (mapa[x, y, z] != null)
                    {
                        if (!(mapa[x, y, z].getTipoSala().Equals("pasillo")))
                        {// sala 

                            if (mapa[x, y, z].getNivelDificultad() == 4 && salaAnterior != null)
                            {// pintarBloqueoFobia
                               Instantiate(FobiaParedPrefab, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) + YCuadrantesSize / 2 + 0.002f), new Quaternion());
                            }
                        }
                    }

                    salaAnterior = mapa[x, y, z];
                }
            }
        }
    }
    private void GenerarParedFobiaEste()
    {
        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int z = 0; z < mapa.GetLength(2); z++)
            {
                salaAnterior = null;
                for (int x = 0; x < mapa.GetLength(0); x++)
                {
                    if (mapa[x, y, z] != null)
                    {
                        if (!(mapa[x, y, z].getTipoSala().Equals("pasillo")))               
                        {// si la sala anterior es una sala 
                            if (mapa[x, y, z].getNivelDificultad() == 4 && salaAnterior != null)
                            {// pintarBloqueoFobia
                               Instantiate(FobiaParedPrefab, new Vector3((x * XCuadrantesSize) - YCuadrantesSize / 2 - 0.002f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, 90, 0)));
                            }
                        }

                    }

                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }

    private void GenerarParedFobiaOeste()
    {
        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int z = 0; z < mapa.GetLength(2); z++)
            {
                salaAnterior = null;
                for (int x = mapa.GetLength(0) - 1; x >= 0; x--)
                {
                    if (mapa[x, y, z] != null)
                    {
                        if (!(mapa[x, y, z].getTipoSala().Equals("pasillo")))
                        {
                            if (mapa[x, y, z].getNivelDificultad() == 4 && salaAnterior != null)
                            {// pintarBloqueoFobia
                              Instantiate(FobiaParedPrefab, new Vector3((x * XCuadrantesSize) + YCuadrantesSize / 2 + 0.002f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, 90, 0)));
                            }
                          
                        }


                    }

                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }

    private void GenerarParedFobiaSur()
    {

        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int x = 0; x < mapa.GetLength(0); x++)
            {
                salaAnterior = null;
                for (int z = 0; z < mapa.GetLength(2); z++)
                {
                    if (mapa[x, y, z] != null)
                    {
                        if (!(mapa[x, y, z].getTipoSala().Equals("pasillo")))// si es un pasillo                      
                        {
                            if (mapa[x, y, z].getNivelDificultad() == 4 && salaAnterior != null)
                            {// pintarBloqueoFobia
                    Instantiate(FobiaParedPrefab, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - YCuadrantesSize / 2 - 0.002f), new Quaternion());
                            }                           
                        }
                    }
                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
