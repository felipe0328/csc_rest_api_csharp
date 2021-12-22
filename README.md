#Rest API programming test C#

This project is created using ASP.NET, 
the project requirements can be found in TestDescription.docx

##How To Run:

You need to have dotnet 6.0 installed on your machine

`dotnet run` -> To Run the project directly

##Exposed Endpoints

| Type  | Endpoint       | Needs Auth | Description            |
|------ |----------------|------------|------------------------|
|  Get  | jobs/          | No         | list all existing jobs |
|  Get  | jobs/\<status> | No         | get jobs by status     |
|  Post | jobs/          | Yes        | creates new job        |

