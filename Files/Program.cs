// The File class from the System.IO namespace, allows us to work with files

// AppendText()	Appends text at the end of an existing file
// Copy()	Copies a file
// Create()	Creates or overwrites a file
// Delete()	Deletes a file
// Exists()	Tests whether the file exists
// ReadAllText()	Reads the contents of a file
// Replace()	Replaces the contents of a file with the contents of another file
// WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
using System.IO;

File.WriteAllText("./files/temp.txt", "Hello, this is test");
Console.WriteLine(File.ReadAllText("./files/temp.txt"));