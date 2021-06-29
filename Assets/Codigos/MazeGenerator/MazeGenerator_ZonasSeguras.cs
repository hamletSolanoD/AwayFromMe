using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator_ZonasSeguras : MonoBehaviour
{

    [SerializeField]
    private GameObject ZonaSegura_Object;

    [SerializeField]
    private float XCuadrantesSize;
    [SerializeField]
    private float YCuadrantesSize;
    [SerializeField]
    private float ZCuadrantesSize;
    private MazeGenerator_Sala[,,] mapa;

    [SerializeField]
    private GameObject paredMesh;


    // Start is called before the first frame update
    void Start()
    {
        mapa = FindObjectOfType<MazeGenerator_MapGenerator>().getMapa();
        generarZonasSeguras();
       

    }
    private void generarZonasSeguras()
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

                                    GameObject ZonaSegura = Instantiate(ZonaSegura_Object, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize), z * ZCuadrantesSize), new Quaternion());

                                    ZonaSegura.GetComponent<HabiltarZonaSegura>().Inicializar(
                                       (z + 1 < mapa.GetLength(2)) ? (mapa[x, y, z + 1] != null ? true : false) : false,
                                       (z - 1 >= 0) ? (mapa[x, y, z - 1] != null ? true : false) : false,
                                       (x - 1 >= 0) ? (mapa[x - 1, y, z] != null ? true : false) : false,
                                        (x + 1 < mapa.GetLength(0)) ? (mapa[x + 1, y, z] != null ? true : false) : false,
                                          new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) + ZCuadrantesSize / 2),
                                          new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - ZCuadrantesSize / 2),
                                          new Vector3((x * XCuadrantesSize) - XCuadrantesSize / 2, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)),
                                          new Vector3((x * XCuadrantesSize) + XCuadrantesSize / 2, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)),
                                          paredMesh
                                        );


                                    break;
                            }
                        }
                    }
                }


            }


        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
