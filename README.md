# Core

- Serves as the calculator core. This will be used in "extension" libraries to carry out necessary calculations

## Planned Extensions

- TransformationExtension, takes in a csv file from the fitnotes app and performs various calculations such as volume calculations
- ProgramSchedulerExtension, this will develop a program based on user provided input

## Aug 29, 2022

- Next Step:
	- BodyGroup not necessary
	- Create a Json file containing list of exercises
	- Start figuring out csv processor. How to deserialize each row into potentially a `LogEntry` object
	- `Logentry` objects to be grouped / mapped into a session? 
		- A `SessionAnalyzer` class may be of use here

- To be groomed:
	- Processors that will handle the various types of datasources coming in. For example a csv datasource, vs an api datasource. Base 
	implementation should be covered in CORE, but extensions can override with their own implementations if necessary
	- The idea is to have the datasource exercises be categorized and lumped together by the processor into sessions divided by date (TBD)
	- Database storage is indepenedent of the processor used, and should be based from CORE. Extensions can have different implementations
	of the CORE db class managers but 

## Aug 28, 2022

- Keeping classes as capapble of being deserialized from JSON to account for future API development
- Work on designing the base structure for the classes
