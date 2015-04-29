# A MAZE. 2015 - Live Audio Workshop files
*Slides + files from the "wobble wobble - making things react to live music in Unity" workshop from the A MAZE. 2015 festival.*

####Consists of:
- a theoretical presentation (amaze_livemusic_workshop.pptx)
- two VVVV patches (FFT32_simple.v4p and BeatDetection.v4p)
- two scenes demonstrating the use of the stuff described in the presentation (tunnel.unity and icosa.unity)

To create new scenes based on this stuff, drop the OSC prefab onto a new scene and access OSCReceiverC.OSCValues.
To change the amount of OSCValues received, edit the static int OSCCount in OSCReceiverC (should've made this more automatic and stuff :V)

####Download & install these things before starting:
- Unity (http://unity3d.com/get-unity)
- on Windows
  - VB-Audio Cable (http://vb-audio.pagesperso-orange.fr/Cable/)
  - VVVV (http://vvvv.org/downloads)
- on Mac
  - Soundflower (https://rogueamoeba.com/freebies/soundflower/)
  - VDMX (https://vidvox.net/)
 
####Tutorial (Windows only):
Install Unity, VVVV and VB-Audio Cable. Go to Control Panel > Sound > Playback and set CABLE Input as the default playback device (remember to change it back after you've finished playing around with the demo).

<img src="http://i.imgur.com/UPiUkxy.png" align="center">

Open up VVVV and open the "FFT32_simple.v4p" patch (located in the "VVVV patches" directory). Change the "mic input switcher" node to "CABLE Input", you can also change the gain to adjust the FFT values.

<img src="http://i.imgur.com/n9OegUg.png" align="center">

If it's set up correctly you should now see the FFT values jumping up and down to the sound that you're playing.

<img src="http://i.imgur.com/voTVefr.png" align="center">

Open up the Unity project and launch the "tunnel.unity" scene (it's in the Scenes directory). Press Play - if everything works correctly you should see the visuals reacting to the sound. 

<img src="http://i.imgur.com/9srT4XT.png" align="center">

PRO TIP: To be able to listen to your music while it's being passed through a digital audio cable, go to Sound > Recording, select the audio cable output, go to Properties > Listen and enable "Listen to this device" via your standard audio output (like Speakers).

<img src="http://i.imgur.com/NHJD7eN.png" align="center">

  
####Additional links:
- http://www.creativeapplications.net/mac/visuals-for-sonar-festival-vdmx-to-unity3d-tutorials/ - great tutorial for Soundflower / VDMX integration on Mac
- http://vvvv.org/documentation/osc - VVVV documentation for the OSC protocol
- https://github.com/heaversm/unity-osc-receiver - OSC to Unity implementation in this project is based off this one, look it up if you prefer JS instead of C#
- https://github.com/jorgegarcia/UnityOSC/ - other OSC to Unity implementation, is also cool

####Contact (feel free to ask about things!):
- spierek /at/ gmail.com
- @Spierek on Twitter
- http://spierek.net
