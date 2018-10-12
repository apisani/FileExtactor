# File extraction and parsing challenge
## Retrieving racing horses from XML and JSON files and displaying them in a console application sorted out by price.

.NET core console application with two class libraries and a testing project

### Documentation
XML documentation can be found in root:
```
fileExraction_challenge\fileExraction.xml
```
### Unit Testing
Unit testing is available for that project using MS test.

### Time limit
This solution has been developed with a 3 time limit.
Following implemention if more time was allowed:

* More unit testing with more specific cases (catching proper exceptions, ordering of the list...)
* Create a more abstract interface for file extraction. (i.e IFileExtractor) to allow more versatility for other file formats.
* Developing a new functionality to fetch files more dynamically and analyse extension to use proper class library (if .json, if .xml ...)

### Externl tools used
* [JSON .NET](https://www.newtonsoft.com/json)
* [json2csharp](http://json2csharp.com/)
* [Xml2CSharp](https://xmltocsharp.azurewebsites.net/)



### Console application

Simply run application from visual studio...
