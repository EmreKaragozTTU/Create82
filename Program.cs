using System;

namespace create82
{
    class Program
    {
        class WriteTextFile
        {
            static void Main()
            {
                string pretext = "#include <stdio.h>\nvoid secretFunction()\n{\nprintf(\"Congratulations!\");\nprintf(\"";
                string aftertext = "!\"); \n} \n \nvoid FileCompress() \n{ \n    	char buffer[20]; \n	char exists[28] = \"test -f \"; \n	char zip[25] = \"gzip \"; \n	char cp[45] = \"cp \"; \n	char mv[45] = \"mv \"; \n	int status; \n	 \n \n    	printf(\"Enter file name to compress:\"); \n    	gets(buffer); \n	 \n	strcat(exists, buffer); \n	status = system(exists); \n	if (status == 256) { \n		printf(\"%s\", \"File not found, exiting\"); \n		return; \n	} \n \n	strcat(cp, buffer); \n	strcat(cp, \" \"); \n	strcat(cp, buffer); \n	strcat(cp, \"1\"); \n	system(cp); \n \n	strcat(zip, buffer); \n	status = system(zip); \n	if (status == 256) { \n		printf(\"%s\", \"Gzip failed, exiting\"); \n		return; \n	} \n	else { \n		printf(\"%s has been zipped.\", buffer); \n	} \n \n	strcat(mv, buffer); \n	strcat(mv, \"1\"); \n	strcat(mv, \" \"); \n	strcat(mv, buffer); \n	system(mv); \n \n	return; \n}	 \n \nint main() \n{ \n    FileCompress(); \n \n    return 0; \n}";

                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\the82v2.txt");
                string batfileBase = "gcc ";
                string batfileO = " -fno-stack-protector -fno-pie -fno-plt -no-pie -m32 -o";
                string batfileAll = "";
                for (int i = 0; i < lines.Length; i++) 
                {
                    string finaltext = pretext + lines[i] + aftertext;
                    int temp = i + 1;
                    string filename = "program" +temp+".c";
                    System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\"+filename, finaltext);
                    batfileAll = batfileAll + batfileBase + filename + batfileO + " " + temp + "\n";
                }
                System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\runme.bat", batfileAll);

            }
        }
    }
}
