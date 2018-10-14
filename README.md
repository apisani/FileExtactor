# File extraction and parsing challenge
## Retrieving racing horses from XML and JSON files and displaying them in a console application sorted out by price.

.NET Core console application with two class libraries and a testing project

### Unit Testing
Unit testing is available for that project using MS test.

### Time limit
This solution has been developed with a 2 hours time limit.
Total time spent with read.me: 2h30 
Following implemention if more time was allowed:

* More unit testing with more specific cases (catching proper exceptions, ordering of the list...)
* Create a more abstract interface for file extraction. (i.e IFileExtractor) to allow more versatility for other file formats.
* Developing a new functionality to fetch files more dynamically and analyse extension to use proper class library (if .json, if .xml ...)

### Externl tools used
* [JSON .NET](https://www.newtonsoft.com/json)
* [json2csharp](http://json2csharp.com/)
* [Xml2CSharp](https://xmltocsharp.azurewebsites.net/)

### Pre-requisite
* .NET Core 2.1

### Console application

To run the application, simply open it in Visual Studio and run it.
