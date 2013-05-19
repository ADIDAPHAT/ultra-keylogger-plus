using System;
using System.Reflection;

[assembly: Obfuscation(Feature = "encrypt resources [compress]", Exclude = false)]
[assembly: Obfuscation(Feature = "encrypt symbol names with password 'I like cake, and it is not a lie!'", Exclude = false)]
[assembly: Obfuscation(Feature = "string encryption", Exclude = true)]
