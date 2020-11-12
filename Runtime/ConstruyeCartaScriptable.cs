using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ConstruyeCartaScriptable : MonoBehaviour
{
   public List<CartaScriptableObject> CartaScriptableObjects = new List<CartaScriptableObject>();
    public Sprite[] Sprites;
    public Sprite dorso;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    [ContextMenu("Constructor")]
    public void Constructor()
    {
        //Creamos los scritable, rellenamos informacion
        CartaScriptableObjects.Add(new CartaScriptableObject("As de bastos", CartaScriptableObject.Palo.Bastos, 1, 1, false, Sprites[0], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Dos de bastos", CartaScriptableObject.Palo.Bastos, 2, 2, false, Sprites[1], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Tres de bastos", CartaScriptableObject.Palo.Bastos, 3, 3, false, Sprites[2], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cuatro de bastos", CartaScriptableObject.Palo.Bastos, 4, 4, false, Sprites[3], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cinco de bastos", CartaScriptableObject.Palo.Bastos, 5, 5, false, Sprites[4], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Seis de bastos", CartaScriptableObject.Palo.Bastos, 6, 6, false, Sprites[5], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Siete de bastos", CartaScriptableObject.Palo.Bastos, 7, 7, false, Sprites[6], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Sota de bastos", CartaScriptableObject.Palo.Bastos, 10, 10, true, Sprites[7], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Caballo de bastos", CartaScriptableObject.Palo.Bastos, 11, 11, true, Sprites[8], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Rey de bastos", CartaScriptableObject.Palo.Bastos, 12, 12, true, Sprites[9], dorso));
        //Copas
        CartaScriptableObjects.Add(new CartaScriptableObject("As de copas", CartaScriptableObject.Palo.Copas, 1, 1, false, Sprites[10], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Dos de copas", CartaScriptableObject.Palo.Copas, 2, 2, false, Sprites[11], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Tres de copas", CartaScriptableObject.Palo.Copas, 3, 3, false, Sprites[12], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cuatro de copas", CartaScriptableObject.Palo.Copas, 4, 4, false, Sprites[13], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cinco de copas", CartaScriptableObject.Palo.Copas, 5, 5, false, Sprites[14], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Seis de copas", CartaScriptableObject.Palo.Copas, 6, 6, false, Sprites[15], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Siete de copas", CartaScriptableObject.Palo.Copas, 7, 7, false, Sprites[16], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Sota de copas", CartaScriptableObject.Palo.Copas, 10, 10, true, Sprites[17], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Caballo de copas", CartaScriptableObject.Palo.Copas, 11, 11, true, Sprites[18], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Rey de copas", CartaScriptableObject.Palo.Copas, 12, 12, true, Sprites[19], dorso));
        //Espadas
        CartaScriptableObjects.Add(new CartaScriptableObject("As de espadas", CartaScriptableObject.Palo.Espadas, 1, 1, false, Sprites[20], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Dos de espadas", CartaScriptableObject.Palo.Espadas, 2, 2, false, Sprites[21], dorso));

        CartaScriptableObjects.Add(new CartaScriptableObject("Tres de espadas", CartaScriptableObject.Palo.Espadas, 3, 3, false, Sprites[22], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cuatro de espadas", CartaScriptableObject.Palo.Espadas, 4, 4, false, Sprites[23], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cinco de espadas", CartaScriptableObject.Palo.Espadas, 5, 5, false, Sprites[24], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Seis de espadas", CartaScriptableObject.Palo.Espadas, 6, 6, false, Sprites[25], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Siete de espadas", CartaScriptableObject.Palo.Espadas, 7, 7, false, Sprites[26], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Sota de espadas", CartaScriptableObject.Palo.Espadas, 10, 10, true, Sprites[27], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Caballo de espadas", CartaScriptableObject.Palo.Espadas, 11, 11, true, Sprites[28], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Rey de espadas", CartaScriptableObject.Palo.Espadas, 12, 12, true, Sprites[29], dorso));
        //Oros
        CartaScriptableObjects.Add(new CartaScriptableObject("As de oros", CartaScriptableObject.Palo.Oros, 1, 1, false, Sprites[30], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Dos de oros", CartaScriptableObject.Palo.Oros, 2, 2, false, Sprites[31], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Tres de oros", CartaScriptableObject.Palo.Oros, 3, 3, false, Sprites[32], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cuatro de oros", CartaScriptableObject.Palo.Oros, 4, 4, false, Sprites[33], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Cinco de oros", CartaScriptableObject.Palo.Oros, 5, 5, false, Sprites[34], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Seis de oros", CartaScriptableObject.Palo.Oros, 6, 6, false, Sprites[35], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Siete de oros", CartaScriptableObject.Palo.Oros, 7, 7, false, Sprites[36], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Sota de oros", CartaScriptableObject.Palo.Oros, 10, 10, true, Sprites[37], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Caballo de oros", CartaScriptableObject.Palo.Oros, 11, 11, true, Sprites[38], dorso));
        CartaScriptableObjects.Add(new CartaScriptableObject("Rey de oros", CartaScriptableObject.Palo.Oros, 12, 12, true, Sprites[39], dorso));
        //Creamos los Assets del tipo CartaScriptableObjectScriptableObject
        for (int i = 0; i < CartaScriptableObjects.Count; i++)
        {
            // CartaObjeto carta = (CartaObjeto)ScriptableObject.CreateInstance("CartaObjeto");
            //Que asset quiero crear y donde lo creo

            AssetDatabase.CreateAsset(CartaScriptableObjects[i], "Assets/Resources/CartaSO/" + CartaScriptableObjects[i].nombre + ".asset");
            AssetDatabase.SaveAssets();
        }
    }
 }
