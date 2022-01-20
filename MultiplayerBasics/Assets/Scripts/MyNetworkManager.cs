using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
   public override void OnClientConnect(NetworkConnection conn)
   {
       base.OnClientConnect(conn);

       Debug.Log("I connected to a server!");
   }
}
