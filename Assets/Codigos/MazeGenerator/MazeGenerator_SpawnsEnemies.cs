using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MazeGenerator_SpawnsEnemies : MonoBehaviour
{

    [SerializeField]
    private float XCuadrantesSize;
    [SerializeField]
    private float YCuadrantesSize;
    [SerializeField]
    private float ZCuadrantesSize;


    [SerializeField]
    private GameObject SpawnerPrefab;

    private MazeGenerator_Sala[,,] mapa;



    private void GenerarSpawnsEnemigos(MazeGenerator_Sala sala, float posicionX, float posicionY, float posicionZ)
    {

        for (int e = 0; e <= sala.getEnemigosNumeroSpawn(); e++)
        {
            int desfacex = 0, desfacez = 0;
            switch (e)
            {
                case 1: desfacex = -2; desfacez = 2; break;
                case 2: desfacex = 2; desfacez = 2; break;
                case 3: desfacex = 2; desfacez = -2; break;
                case 4: desfacex = -2; desfacez = -2; break;
            }
            GameObject spawner = Instantiate(SpawnerPrefab, new Vector3(posicionX + desfacex, posicionY, posicionZ + desfacez), new Quaternion());
            spawner.GetComponent<Spawner>().inicializar(sala.getNivelDificultad(), new Vector3(posicionX, posicionY + 2, posicionZ));
        }
    }

    private void generarSpawnsEnemigos()
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
                            GenerarSpawnsEnemigos(mapa[x, y, z], x * XCuadrantesSize, y * YCuadrantesSize, z * ZCuadrantesSize);
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
        generarSpawnsEnemigos();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
