# BlipValidate

**_BlipValidate_** is an ASP.NET Core MVC case study solution to accompany three guides in the **PluralSight** [**HackGuides()**](https://www.pluralsight.com/guides/microsoft-net) collection for Microsoft .NET technologies.

## PluralSight Hack.Guides()

[ASP.NET Core MVC Client Data Validation - Part 1: ViewModels and Data Annotations](https://www.pluralsight.com/guides/microsoft-net/asp-net-core-mvc-client-data-validation-part-1-viewmodels-and-data-annotations) - This guide, the first of three parts, presents the foundational level of client-side data validation using the MVVM design pattern: viewmodels and data annotations.

[ASP.NET Core MVC Client Data Validation - Part 2: jQuery validation](https://www.pluralsight.com/guides/microsoft-net/asp-net-core-mvc-client-data-validation-part-2-jquery-validation) - The second installment builds on the foundation created in Part 1 by explaining how widely-used jQuery libraries can provide responsive client-side data validation by working in conjunction with the HTML created by ASP.NET Core MVC.

[ASP.NET Core MVC Client Data Validation - Part 3: Controller validation](https://www.pluralsight.com/guides/microsoft-net/asp-net-core-mvc-client-data-validation-part-3-controller-validation) - Part 3 shows how the view model, data annotations, and the `ModelState` object come together with MVC model binding to provide server-side validation of client data, an essential part of the client data validation process.

*Notice: PluralSight and the author disclaim any liability for errors or omissions in this code.*

## Solution Projects

| Project | Application Layer |
| :--- | :--- |
| Blip.Data | Data Context, Entities, and Repositories |
| Blip.Web | User Interface (views) and Business Logic (controllers) |

## Technologies

| Dependency | Version*
| :--- | ---:
| .NET Standard | 2.0.1
| ASP.NET Core (All) | 2.0.5
| Bootstrap | 3.3.7
| Entity Framework Core SQL Server | 2.0.1
| jQuery | 3.2.1
| jQuery Validation | 1.17.0
| Microsoft jQuery Unobtrusive Validation | 3.2.6

&ast; As of the latest commit.

## Getting Started

1. Download or clone this repository.
1. Open the solution in Visual Studio 2017 or higher.
1. Open a Package Manager Console window.
1. Change Default Project to **BlipValidate.Data**.
1. Run `update-database` to create the database.

* Note that the database is not required to run code associated with any of the Guides listed above.

## Configuration

* The following files contain configuration strings which may require modification for the developer's specific environment:

    | Project | File
    | :--- | :---
    | Blip.Web | config.json

* The configuration strings specify the instance of SQL Server Express installed with Visual Studio 2017 as the target database server: `Data Source=(localdb)\ProjectsV13`. Developers using a different target database will have to change the connection strings in both projects.

## License

This project is licensed under the terms of the MIT license.