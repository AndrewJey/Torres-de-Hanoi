

<!-- local-development:start -->
# Desarrollo local

Puedes abrir este repositorio en VS Code, Antigravity o Sublime Text. El compilador y los servicios necesarios dependen del componente indicado abajo.

## Java / NetBeans

En NetBeans 25, abre la carpeta que contiene `build.xml` como proyecto Ant. Selecciona un JDK igual o posterior al nivel de fuente del proyecto; las compilaciones de esta revisión usan JDK 24.0.2. El asistente busca NetBeans y el JDK y mantiene la configuración de usuario en `.local-build/`.

```powershell
.uild-local.ps1
.\build-local.ps1 -Project 'ProyectoTorresDeHanoi - Java (Andrés Matta & Aarón Jara)/Torres-de-Hanoi-master/TorresDeHanoi/build.xml' -Target run
```

Si hay varios proyectos, elige el deseado con `-Project`. Puedes indicar `-JavaHome` y `-NetBeansHome`. `-Target test` ejecuta las pruebas que declare el proyecto; un objetivo de pruebas vacío no acredita cobertura.

## Visual Studio 2022 / .NET Framework

Instala la carga de trabajo de escritorio .NET y el paquete de destino indicado en la tabla. Los proyectos ASP.NET también requieren la carga web e IIS Express. Abre la solución `.sln` correspondiente y selecciona el proyecto de aplicación para iniciar.

```powershell
# Ejecutar desde Developer PowerShell de Visual Studio 2022
$solutionDir = (Resolve-Path 'Cris_Hellen - C#/TorresHanoi--/Torres de hanoi').Path + '\'
MSBuild.exe 'Cris_Hellen - C#/TorresHanoi--/Torres de hanoi/JCVDTorresdeHanoi/ParadigmasHanoi.csproj' /restore /p:RestorePackagesConfig=true /p:Configuration=Debug /p:DeployOnBuild=false "/p:SolutionDir=$solutionDir"
```

## Componentes y validación

Inventario y compilaciones locales del 2026-11-15. Una compilación correcta no acredita todavía interacción, compatibilidad de base de datos, instalador ni despliegue.

| Componente | Tipo / destino | Validación |
| --- | --- | --- |
| [Cris_Hellen - C#/TorresHanoi--/Torres de hanoi/JCVDTorresdeHanoi/ParadigmasHanoi.csproj](<Cris_Hellen - C#/TorresHanoi--/Torres de hanoi/JCVDTorresdeHanoi/ParadigmasHanoi.csproj>) | dotnet / v4.8.1 | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |
| [Cris_Hellen - C#/TorresHanoi--/Torres de hanoi/TorresdeHanoi.sln](<Cris_Hellen - C#/TorresHanoi--/Torres de hanoi/TorresdeHanoi.sln>) | solution | Sin ejecutar |
| [Proyecto(DavidGutierrez) - C#/GUI_THanoi/GUI_THanoi.sln](<Proyecto(DavidGutierrez) - C#/GUI_THanoi/GUI_THanoi.sln>) | solution | Sin ejecutar |
| [Proyecto(DavidGutierrez) - C#/GUI_THanoi/GUI_THanoi/GUI_THanoi.csproj](<Proyecto(DavidGutierrez) - C#/GUI_THanoi/GUI_THanoi/GUI_THanoi.csproj>) | dotnet / v4.8.1 | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |
| [ProyectoTorresDeHanoi - Java (Andrés Matta & Aarón Jara)/Torres-de-Hanoi-master/TorresDeHanoi/build.xml](<ProyectoTorresDeHanoi - Java (Andrés Matta & Aarón Jara)/Torres-de-Hanoi-master/TorresDeHanoi/build.xml>) | netbeans-ant / 1.8 | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |
| [ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/Backup/JCVDTorresdeHanoi.sln](<ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/Backup/JCVDTorresdeHanoi.sln>) | solution | Sin ejecutar |
| [ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/Backup/JCVDTorresdeHanoi/JCVDTorresdeHanoi.csproj](<ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/Backup/JCVDTorresdeHanoi/JCVDTorresdeHanoi.csproj>) | dotnet | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |
| [ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/JCVDTorresdeHanoi/ProyectoHanoi.csproj](<ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/JCVDTorresdeHanoi/ProyectoHanoi.csproj>) | dotnet / v4.8.1 | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |
| [ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/TorresdeHanoi.sln](<ProyectoTorresHanoi - C# (Carlos Alberto Salaz & Jonathan Araya)/sharp1/TorresdeHanoi.sln>) | solution | Sin ejecutar |
| [Proyecto_Torre_Hanoi_IA_2016 - Java (Arbay & Diego)/Proyecto_Torre_Hanoi_IA_2016-master/build.xml](<Proyecto_Torre_Hanoi_IA_2016 - Java (Arbay & Diego)/Proyecto_Torre_Hanoi_IA_2016-master/build.xml>) | netbeans-ant / 1.8 | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |
| [Torres-de-Hanoi-I.A. - C# (José Guerrero & José Carrillo)/TorreHanoi/TorreHanoi.sln](<Torres-de-Hanoi-I.A. - C# (José Guerrero & José Carrillo)/TorreHanoi/TorreHanoi.sln>) | solution | Sin ejecutar |
| [Torres-de-Hanoi-I.A. - C# (José Guerrero & José Carrillo)/TorreHanoi/TorreHanoi/TorreHanoi.csproj](<Torres-de-Hanoi-I.A. - C# (José Guerrero & José Carrillo)/TorreHanoi/TorreHanoi/TorreHanoi.csproj>) | dotnet / v4.8.1 | Compila; comprobado el 2026-11-15; ver alcance actualizado abajo |

## Archivos ignorados

`.gitignore` excluye credenciales locales, estado del editor y salidas de las herramientas detectadas. No deja de versionar archivos que ya estaban en Git. Los manifiestos, archivos de bloqueo, recursos fuente y scripts de esquema forman parte del código.
<!-- local-development:end -->

<!-- build-repairs-20261115:start -->
## Reparación y comprobación — 2026-11-15

- La variante Java utiliza controles Swing estándar y una demostración recursiva de tres discos, en lugar de Edisoncor y una clase Demo ausente.
- Se corrigieron recursos gráficos y referencias de Framework de variantes C#, incluida la copia Backup.

Comprobado:

- Compilan las dos variantes Java y las cinco variantes C#.
- Se construyeron los formularios de las cinco variantes C# y se cargaron sus recursos.

Comandos:

```powershell
Java: .\build-local.ps1; elige -Project para ejecutar una variante.
C#: abre la solución de la variante en Visual Studio 2022.
```

Alcance pendiente:

- No se verificó exhaustivamente el juego y todas las animaciones de cada variante.

<!-- build-repairs-20261115:end -->
