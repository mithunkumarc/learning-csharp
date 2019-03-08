Simple escape sequences are interpreted literally.

@ : verbatim identifier 

        string filename1 = @"c:\documents\files\u0066.txt";
        string filename2 = "c:\\documents\\files\\u0066.txt";
        
        filename1 is same as filename2
        
        example : 
            static void Main(String[] args){

                String with_verbatim = @"c:\newfolder\newfile";
                String without_verbatim = "c:\newfolder\newfile";
                Console.WriteLine("without verbatim : "+ without_verbatim);       
                Console.WriteLine("with verbatim : " + with_verbatim);
                 
            }
            
            
            ouput : 
            
            without verbatim : c:
            ewfolder
            ewfile
            
            with verbatim : c:\newfolder\newfile
