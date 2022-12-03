# User API Dev Guide

The project have 3 main libraries along with WebAPI project, and they are reference in below order

TestProject.Data -> TestProject.Repository -> TestProject.Service -> TestProject.WebAPI

TestProject.Data : In this library, all the models and entity is placed

TestProject.Repository : This library has DBContext and all the repositories which is used to take data, update and delete.
Repository pattern is used to achieved CRUD type of database operation.
Also, AutoMapper is added to convert entity to model, and model to entity.
To add your case, look for AutoMapper -> Mapper.cs file

TestProject.Service: Here, all the logical part needs to be done and to call the repository.

Mention all service and repository dependancies in TestProject.WebApi -> Helpers -> DependancyInjection.cs

To handle global exception, middlerware is added. Check for ExceptionMiddlewareExtensions.cs

## Building

Before starting application, change the database connection in appsetting.json

## Testing

Test cases are executed as per requirements

## Deploying

Before starting application, change the database connection string in appsetting.json.
Publish the TestProject.WebAPI and deploy on server.

## Additional Information
