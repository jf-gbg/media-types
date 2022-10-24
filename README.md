# media-types

Problem:
Even though Windows and macOS sometimes hide them, most files have file extensions, a suffix that starts with a period (.) at the end of their name. 
For instance, file names for GIFs end with .gif, and file names for JPEGs end with .jpg or .jpeg. 
When you double-click on a file to open it, your computer uses its file extension to determine which program to launch.

Web browsers, by contrast, rely on media types, formerly known as MIME types, to determine how to display files that live on the web. 
When you download a file from a web server, that server sends an HTTP header, along with the file itself, indicating the file’s media type. 
For instance, the media type for a GIF is image/gif, and the media type for a JPEG is image/jpeg. 
To determine the media type for a file, a web server typically looks at the file’s extension, mapping one to the other.

See developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types for common types.

Implement a program that prompts the user for the name of a file and then outputs that file’s media type if the file’s name ends, case-insensitively, 
in any of these suffixes:

    .gif
    .jpg
    .jpeg
    .png
    .pdf
    .txt
    .zip

If the file’s name ends with some other suffix or has no suffix at all, output application/octet-stream instead, which is a common default.


Solution: 
Create a class called File, an enum called extension and a dictionary called ExtensionToMediaType. 
All Files should have en extension and a name. When the user enters a name for a file the program should automatically get the extension from the name
by reading all the end characters up to the first "." character. This should be done using a private method in the class. 

