# BlipValidate

**_BlipValidate_** is an ASP.NET Core MVC case study solution to accompany an ASP.NET Core article on [**codeArbor**](https://codearbor.com) and three guides in the [**PluralSight Guides**](https://www.pluralsight.com/guides/microsoft-net) collection for Microsoft .NET technologies.

## codeArbor Articles

[Building robust numeric fields for HTML forms with ASP.NET Core MVC](https://codearbor.com/library/building-robust-numeric-fields-for-html-forms-with-aspnet-core-mvc/) - Building robust numeric data fields for data entry on the web should include validation of client data on both the client, in the browser, and on the server. ASP.NET Core MVC provides excellent resources for these tasks.

## PluralSight Guides

[ASP.NET Core MVC Client Data Validation - Part 1: ViewModels and Data Annotations](https://www.pluralsight.com/guides/microsoft-net/asp-net-core-mvc-client-data-validation-part-1-viewmodels-and-data-annotations) - This guide, the first of three parts, presents the foundational level of client-side data validation using the MVVM design pattern: viewmodels and data annotations.

[ASP.NET Core MVC Client Data Validation - Part 2: jQuery validation](https://www.pluralsight.com/guides/microsoft-net/asp-net-core-mvc-client-data-validation-part-2-jquery-validation) - The second installment builds on the foundation created in Part 1 by explaining how widely-used jQuery libraries can provide responsive client-side data validation by working in conjunction with the HTML created by ASP.NET Core MVC.

[ASP.NET Core MVC Client Data Validation - Part 3: Controller validation](https://www.pluralsight.com/guides/microsoft-net/asp-net-core-mvc-client-data-validation-part-3-controller-validation) - Part 3 shows how the view model, data annotations, and the `ModelState` object come together with MVC model binding to provide server-side validation of client data, an essential part of the client data validation process.

*Notice: codeArbor, PluralSight, and the author(s) disclaim any liability for errors or omissions in this code. See the [Disclaimer of Warranties and Limitation of Liability](#disclaimer-of-warranties-and-limitation-of-liability) for complete information.*

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

## Contributing

See the accompanying instructions on [How to contribute](CONTRIBUTING.md).

## Disclaimer of Warranties and Limitation of Liability

The contents of this repository are offered on an as-is and as-available basis and the authors make no representations or warranties of any kind concerning the contents, whether express, implied, statutory, or other. This includes, without limitation, warranties of title, merchantability, fitness for a particular purpose, non-infringement, absence of latent or other defects, accuracy, or the presence or absence of errors, whether or not known or discoverable.

To the extent possible, in no event will the authors be liable on any legal theory (including, without limitation, negligence) or otherwise for any direct, special, indirect, incidental, consequential, punitive, exemplary, or other losses, costs, expenses, or damages arising out of the use of the contents, even if the the authors have been advised of the possibility of such losses, costs, expenses, or damages.

The disclaimer of warranties and limitation of liability provided above shall be interpreted in a manner that, to the extent possible, most closely approximates an absolute disclaimer and waiver of all liability.