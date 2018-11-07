FileAssociationInfo fai = new FileAssociationInfo(".bob");
    if (!fai.Exists)
      {
         fai.Create("MyProgramName");

         //Specify MIME type (optional)
         fai.ContentType = "application/myfile";

         //Programs automatically displayed in open with list
         fai.OpenWithList = new string[]
        { "notepad.exe", "wordpad.exe", "someotherapp.exe" };
       }
       
       ProgramAssociationInfo pai = new ProgramAssociationInfo(fai.ProgID);
    if (!pai.Exists)
      {
         pai.Create
         (
         //Description of program/file type
         "My Program's File Type",

         new ProgramVerb
              (
              //Verb name
              "Open",
              //Path and arguments to use
              @"C:\SomePath\MyApp.exe %1"
              )
            );

         //optional
         pai.DefaultIcon = new ProgramIcon(@"C:\SomePath\SomeIcon.ico");
       }