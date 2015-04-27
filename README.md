# A MAZE. 2015 - Live Audio Workshop files
Slides + files from the "wobble wobble - making things react to live music in Unity" workshop from the A MAZE. 2015 festival.

Consists of:
- a theoretical presentation (amaze_livemusic_workshop.pptx)
- two VVVV patches (FFT32_simple.vvvv and BeatDetection.vvvv)
- two scenes demonstrating the use of the stuff described in the presentation (tunnel.unity and icosa.unity)

To create new scenes based on this stuff, drop the OSC prefab onto a new scene and access OSCReceiverC.OSCValues.
To change the amount of OSCValues received, edit the static int OSCCount in OSCReceiverC (should've made this more automatic and stuff :V)

Download & install these things before starting:
- Unity (http://unity3d.com/get-unity)
- on Windows
  - VB-Audio Cable (http://vb-audio.pagesperso-orange.fr/Cable/)
  - VVVV (http://vvvv.org/downloads)
- on Mac
  - Soundflower (https://rogueamoeba.com/freebies/soundflower/)
  - VDMX (https://vidvox.net/)
  
Additional links:
- http://www.creativeapplications.net/mac/visuals-for-sonar-festival-vdmx-to-unity3d-tutorials/ - great tutorial for Soundflower / VDMX integration on Mac
- http://vvvv.org/documentation/osc - VVVV documentation for the OSC protocol
- https://github.com/heaversm/unity-osc-receiver - OSC to Unity implementation in this project is based off this one, look it up if you prefer JS instead of C#
- https://github.com/jorgegarcia/UnityOSC/ - other OSC to Unity implementation, is also cool

Contact (feel free to ask about things!):
- spierek /at/ gmail.com
- @Spierek on Twitter
- http://spierek.net
