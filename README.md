# Torres-de-Hanoi

<!-- local-development:start -->
## Desarrollo local

Consulta [RUNNING.md](RUNNING.md) para ubicar cada componente, abrirlo en su IDE, compilarlo y conocer las comprobaciones realizadas y los requisitos pendientes.
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
