using UnityEngine;

/* 
	OSC RECEIVER C#
	A modified version of this plugin - https://github.com/heaversm/unity-osc-receiver
*/

[RequireComponent(typeof(Osc))]
[RequireComponent(typeof(UDPPacketIO))]
public class OSCReceiverC : MonoBehaviour {
    #region Variables
    [SerializeField] private string     remoteIP        = "127.0.0.1";
    [SerializeField] private int        listenerPort    = 8000;
    [SerializeField] private int        senderPort      = 9000;
    [SerializeField] private Transform  controller;
    private Osc                         handler;

    public static int                   OSCcount        = 32;
    public static float[]               OSCvalues       = new float[OSCcount];
    #endregion

    #region Monobehaviour Methods
    void Start () {
        UDPPacketIO udp = GetComponent<UDPPacketIO>();
        udp.init(remoteIP, senderPort, listenerPort);
        handler = GetComponent<Osc>();
        handler.init(udp);
        handler.SetAllMessageHandler(MessageHandler);
    }
    #endregion

    #region Methods
    // called every time Unity receives a message
    public void MessageHandler(OscMessage message) {
        string msgString = Osc.OscMessageToString(message);
        MainDebug.WriteLine(msgString);     // writing out the message to see if everything works correctly

        for (int i = 0; i < OSCcount; i++) {
            OSCvalues[i] = float.Parse(message.Values[i].ToString());
        }
    }
    #endregion
}
