# Sistema de inventario de productos

- Sistema con Windows Forms con C# y SQL Server

# Estructura del proyecto

```
MiApp.sln
├── MiApp.UI            (WinForms: Forms, UserControls, Theme)
│   ├── Views/          (Forms e interfaces IView)
│   ├── Controls/       (controles reutilizables)
│   ├── Theme/          (aquí vive el "CSS")
│   └── Program.cs      (composición/DI)
├── MiApp.Application   (Presenters, servicios, DTOs)
├── MiApp.Domain        (entidades, reglas)
└── MiApp.Infrastructure(EF Core, repositorios, APIs)
```