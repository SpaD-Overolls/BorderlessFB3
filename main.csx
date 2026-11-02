#load "ump.csx"

using UndertaleModLib.Models;

class BorderlessLoader : UMPLoader
{
	public override string CodePath => "code/";

    public override bool UseGlobalScripts => true;
	
	public BorderlessLoader(UMPWrapper wrapper) : base(wrapper)
    {
    }
	
	public override string[] GetCodeNames(string filePath)
    {
        List<string> entries = new List<string>();
        string fileName = Path.GetFileNameWithoutExtension(filePath);
		
		// assume all code files starting with o are for objects
		if (fileName.StartsWith("o"))
		{
			fileName = "gml_Object_" + fileName;
		}
		
        entries.Add(fileName);
        return entries.ToArray();
    }
	
	public override bool AcceptFile(string filePath)
    {
        return true;
    }

}

void Build()
{
	BorderlessLoader loader = new(UMP_WRAPPER);
	
	string scriptPath = Path.GetDirectoryName(ScriptPath);
	loader.Load();
	
	ScriptMessage("Borderless Fullscreen Mod for Five Nights at Frickbear's 3 + Four Layers Down was imported!");
}