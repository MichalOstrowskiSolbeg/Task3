# Task3
ASP .NET Core MVC application "Hot desc". 
Project uses repository-service pattern. Project contains of 3 layers (Repository, Service, UI). Each layer is a different project. 
Project uses EF to connect to MsSql database. DBModels were created by scaffolding DbContext. 
Validation was made with FluentValidation library which could help me separate request objects from validation.

Features:
CRUD on Reservation table.
See all employees, see employee details with all made reservations.
See all workplaces, see workplace details with all assigned items to it.
