----------Foreword----------

Tricky to use, hard to master, might cause crashes.
This dll is built from dungeonneko's Sharploud repository and was tested with should be compatible with Flax 1.11

----------How to use----------

1. Copy DLL into your flax project, doesn't matter where for the sake of this example we'll plonk it inside the Content folder.
2. Add to your modules build.cs by adding the line:
	options.ScriptingAPI.FileReferences.Add(Path.Combine(FolderPath, "..", "..", "Content", "SoLoud.dll"));
3. Copy the SoLoud TTS C# script into your projects source folder.
4. Place the script onto an actor in your scene.
5. Enter playmode and press E and you should be hearing a Text-To-Speech saying "Hello World!" with filters, reverb and echo applied.

----------Closing words----------

This serves as an experiment into using other audio solutions within Flax.
The reverb is a little too strong and the documentation on the effects in general is lacking.