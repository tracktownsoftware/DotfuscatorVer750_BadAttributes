rem 1) Open a developer command prompt
rem 2) cd to the folder that contains obfuscate.bat
rem 3) run obfuscate.bat to produce the bug
rem See README.md for description of the BUG and a WORKAROUND
"C:\Program Files (x86)\PreEmptive Protection Dotfuscator Professional 7.5.0\dotfuscator.exe" dotfuscator.xml

rem dotfuscatorFIXED.xml works by removing the excludelist assembly element "name" attribute and subelements 
rem added by the Dotfuscator editor.
rem the 
rem "C:\Program Files (x86)\PreEmptive Protection Dotfuscator Professional 7.5.0\dotfuscator.exe" dotfuscatorFIXED.xml