# TIGER (A Model Based Test Generation Framework based on GraphWalker, an open source MBT tool, to generate test scripts)
We have used the MBT concept for developing the framework i.e. transformation layer for concretization of abstract test cases and generation of test script.
An interface has been developed to provide input files i.e Model file in Json or GraphML (as GraphWalker supports these two formats of model for generating abstract test cases)
We have also defined mapping rules to concretize the abstract test cases. However, for test script generation we have excluded the 'ScriptCreator' class due to confidential information about the SUT developed by Bombardier Transporation AB, Sweden. However, a customize class can be added to generate test scripts.
'JsonReading' class contains the implementaion detail to read the abstract test cases and a customize method for deserialization of information contained in Json file in a List of 'DataModel' class objects.
'Signal' class contains the model for storing information about the signals.
'xmlReader' takes the information about signals in xml format and stores the relevant information in a List of Signals.
Mapping Rules are defined in 'TestGenerator' class which are used to concretize the abstract test cases generate the scripts using 'ScriptCreator' class.
Program.cs is the main executor class.

_______________________________________________________________________________________________________________________________________________________________________________
