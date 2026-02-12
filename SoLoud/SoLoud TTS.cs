using FlaxEngine;
using SoLoud;


public class SoLoudTTS : Script
{
    private Soloud soloud;
    private Speech speech;
    private LofiFilter lofiFilter;
    private EchoFilter echoFilter;
    private FreeverbFilter freeverbFilter;
    public override void OnStart()
    {
        soloud = new Soloud();
        speech = new Speech();
        lofiFilter = new LofiFilter();
        echoFilter = new EchoFilter();
        freeverbFilter = new FreeverbFilter();

        speech.setText("Hello world!");
        lofiFilter.setParams(8000, 5); //parameter for lofi
        echoFilter.setParams(0.4f, 0.2f); //parameters for echo, delay and decay. Do not set decay to 1, else it will echo for ever.
        freeverbFilter.setParams(1, 0.5f, 0.5f, 2f); //parameters for reverb, Mode, size, dampening, and width. None of the options seem to do anything.

        soloud.init(Soloud.CLIP_ROUNDOFF |
                    Soloud.ENABLE_VISUALIZATION);
        
        soloud.setGlobalVolume(1); //global audio volume
        speech.setFilter(0, lofiFilter); //set lofi filter to the speech object
        soloud.setGlobalFilter(0, echoFilter); //set echo filter to global channel
        soloud.setGlobalFilter(1, freeverbFilter); //set reverbe filter to global channel. Freeverb CANNOT be on an object, it will crash. 
    }
    
    public override void OnUpdate()
    {
        if(Input.GetKeyDown(KeyboardKeys.E)) //Play 2d oneshot
            soloud.play(speech);
    }
    public override void OnDisable()
    {
        soloud.deinit(); //deinit once we stop play otherwise it might keep playing
    }
}
