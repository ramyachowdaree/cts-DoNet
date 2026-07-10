# Lab 1 - Understanding ORM with a Retail Inventory System

## Scenario

You are building an inventory management system for a retail store.
The system stores products, categories, and stock levels in a SQL Server database.

## Objective

Understand ORM (Object Relational Mapping) and how Entity Framework Core bridges C# objects and relational database tables.

## What is ORM?

ORM (Object Relational Mapping) is a technique that maps C# classes to database tables.

Example:

Product class  ---> Products table

Category class ---> Categories table

Instead of writing SQL queries manually, developers can use C# objects.

## Benefits of ORM

- Faster development
- Less SQL code
- Better maintainability
- Automatic object-table mapping
- Database abstraction

## EF Core vs EF Framework

### EF Core

- Cross-platform
- Lightweight
- Supports LINQ
- Supports Async Queries
- Better Performance
- Supports Compiled Queries

### EF Framework (EF6)

- Windows only
- Older framework
- Less flexible
- Mainly for .NET Framework applications

## EF Core 8.0 Features

- JSON Column Mapping
- Compiled Models
- Better Performance
- Interceptors
- Improved Bulk Operations

## Commands

Create Console Application

dotnet new console -n RetailInventory

Go into project

cd RetailInventory

Install Packages

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

## Outcome

Successfully understood ORM concepts and created an EF Core console project.