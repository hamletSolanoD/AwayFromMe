using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator_MapGenerator : MonoBehaviour
{

    public Material[] MaterialesPiso;
    public Material[] MaterialesPared;
    public Material[] MaterialesCielo;

    public int Nivel;

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public MazeGenerator_Sala[,,] getMapa() {
        MazeGenerator_Sala[,,] MAPA = null;
        switch (Nivel) {
    
           
            case 1: //mapa intro
                MazeGenerator_Sala[,,] Intro =
                    {// laberinto jefe 2

                    {{      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                            new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0,5),
                            new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1,5),
                            null,
                            null} },

                       {{      null,
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0),
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1),
                             new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],3),
                            null
                            } },
                         {{
                            null,
                             null,
                            new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1,5),
                        null,null
                            } },
                            {{
                            null,
                            null,
                              new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0,5),
                                new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0,5),
                             new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],4)
                            } },



                };
                MAPA = Intro;
                break;
            case 2: //mapa
                MazeGenerator_Sala[,,] IntroSalasEnemigos =
                    {// laberinto jefe 2

                    {{      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                    null,
                      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1),

                            null,
                            null} },

                    {{      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0),
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1),
                        null} },

                    {{      
                        null,
                        null,
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],3),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0,5),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1,5)
                        } },


                    {{
                        null,
                        null,
                        null,
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],2),
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0),
                        } },
                         {{
                        null,
                        null,
                         new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],4),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0,5),
                                            new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1,5)
                        } }


                };
                MAPA = IntroSalasEnemigos;
                break;
            case 3: //mapa intro
                MazeGenerator_Sala[,,] Nivel1 =
                    {

                    {{      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                       new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],2), } },

                         {{      null,
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                  new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                    new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) } },

                         {{  
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                  new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0),
                   null,
                       new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) } },


                         {{
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                     null,
                new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                     new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1),
                                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0)
 } },
                              {{
                     new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,2),
null,
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,1),
                   null,
                                                   new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,1),
 } },
                       
                              {{
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                    null,
           new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                   null,
                       new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) } },
                          
                              {{
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                null,
                     
                      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1),
                       new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5),
                        new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)
                } },

                                 {{       new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                     new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5),
                      new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                  new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5),
                    new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) } },


                                   {{       new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],4),
                     null,null,null,
                     new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],3), } }











                };
                MAPA = Nivel1;
                break;
            case 4:

                MazeGenerator_Sala[,,] Nivel4 = {
{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null ,null ,null ,null ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],3) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null}},

{{null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5)}},

{{null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],4) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null}},

  };


                MAPA = Nivel4;

                break;
            case 5:
                MazeGenerator_Sala[,,] EnemigoArania =
                 {

                    {{      new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0),
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5),
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5),
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                            new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0)}},


                    {{                                    new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),

                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                                                          new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5)}},

       {{                                    new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),

                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                                                          new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5)}},{{                                    new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),

                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                                                          new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5)}},
       {{                                    new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0),

                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                              new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],5),
                                                          new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0)}}

                };
                MAPA = EnemigoArania;
                break;
            case 6:
                MazeGenerator_Sala[,,] Nivel6 = {
{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2)}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],3) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null}},

{{null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,null}},

{{null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null}},

{{null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null}},

{{null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],4) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null}},

  };


                MAPA = Nivel6;


                break;
            case 7:
                MazeGenerator_Sala[,,] Nivel7 = {
{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1)}},

{{null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null}},

{{null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1)}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2)}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2)}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2)}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2)}},

{{null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5)}},

{{null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],0) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5)}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],2) ,null ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null}},

{{new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],1,5) ,null ,null}},

{{new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],4) ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],1,5) ,null ,null ,null ,null ,null ,null ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("pasillo",MaterialesPiso[1],MaterialesPared[1], MaterialesCielo[1],0,5) ,new MazeGenerator_Sala("sala",MaterialesPiso[1],MaterialesPared[1],MaterialesCielo[1],3)}},

  };


                MAPA = Nivel7;


                break;


        }
        
        return MAPA;

    }
}
