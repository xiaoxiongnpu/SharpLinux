using System;



{
  
  {
    
    {
      
// some lovely, lovely globals.
	string product = "SharpLinux";
      
      
      
      
      
	Environment.GetEnvironmentVariable ("processor_architecture");
      
      
      
      
      
      
      
// check for some important files.
	Console.WriteLine ("I: Setting up directories...");
      
      
					     Directory.
					     GetCurrentDirectory ());
      
      
      
      
	"" + product + " " + buildhost + " " + version + "-" + codename +
	"-" + compiler + " " + builddate + "(" + buildid + ") " +
	machinetype + "";
      
      
      
      
      
// see if /bin/login lives.
// actually, we see if it doesn't, and quit if so.
	if (!File.Exists ("" + rootpath + "\\bin\\login.exe"))
	
	{
	  
	  
	  
	  
	  
	
      
      
      
      
      
      
      
	new ProcessStartInfo ("" + rootpath + "\\bin\\login.exe") 
      {
      
      
      
    
  


