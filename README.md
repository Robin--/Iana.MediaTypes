# Iana.MediaTypes 
## Iana MediaTypes Reference Class for .Net Core 2.0
This is a .Net 2.0 C# Reference Class For the IANA Media Types 
( https://www.iana.org/assignments/media-types/media-types.xhtml )

This class specifies Media Types (formerly known as MIME types) and Media
Subtypes that are assigned and listed by the IANA.

I wrote this class to use with **Microsoft's System.Net.Http.Headers.ContentType** class 
( https://msdn.microsoft.com/en-us/library/system.net.http.headers.httpcontentheaders.contenttype(v=vs.118).aspx ) 
to facilitate the transfer of media types via HTTP using C#.


### Typical Usage: 
```
Headers.ContentType = new MediaTypeHeaderValue(Iana.MediaTypes.Text.plain) { CharSet = "UTF-8" };
```
