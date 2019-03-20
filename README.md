# TuFactura.co
> Permite Integrar sus proyectos con la API de tufactura.co. Emita Facturas y Notas Electrónica para Colombia cumpliendo con todas las normas vigentes. [Wiki Tufactura](https://github.com/tufactura-co/NugetTufactura.co/wiki)

> _Debe Adquirir una Suscripción en www.tufactura.co. Hay Suscripciones Gratis._
***
### Desde la Consola de paquetes de Visual
* `Install-Package TuFactura.co`
### Desde el administrador de paquetes
![](https://raw.githubusercontent.com/tufactura-co/NugetTufactura.co/master/image.png)
***
* Agregue las referencias:
<br>`using TuFactura.co;`
<br>`using TuFactura.co.Modelo;`
***
* Estas constantes pueden ser leídas desde el **webconfig** o de **BD**. Estos Parámetros son entregados con la suscripción. Visite www.tufactura.co
<br>`private const string Usuario = "";`
<br>`private const string Pass = "";`
<br>`private const string Suscriptor = "";`
***
* Instancie la clase TuFacturaco. 
<br>`TuFacturaco tufactura = new TuFacturaco(Usuario, Pass, Suscriptor, Ambientes.Habilitacion);`
<br>`Ambientes.Habilitacion` es el ambiente de pruebas.
***
### Métodos Disponibles:
* [EstadoAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/EstadoAsync)
* [CrearActualizarPersonaAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/CrearActualizarPersonaAsync)
* [EmitirFacturaAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/EmitirFacturaAsync)
* [ConsultarTrazabilidadFacturaAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/ConsultarTrazabilidadFacturaAsync)
* [EmitirNotasAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/EmitirNotasAsync)
* [ConsultarTrazabilidadNotaAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/ConsultarTrazabilidadNotaAsync)
* [CargarAnexosAsync](https://github.com/tufactura-co/NugetTufactura.co/wiki/CargarAnexosAsync)
* [Utilidades](https://github.com/tufactura-co/NugetTufactura.co/wiki/Utilidades)
### Persistencia:
* [Modelo](https://github.com/tufactura-co/NugetTufactura.co/wiki/Modelo)
### Recursos:
* [Solución Visual](https://codeload.github.com/tufactura-co/NugetTufactura.co/zip/master)
* [Código Completo](https://github.com/tufactura-co/NugetTufactura.co/blob/master/prueba-Nuget/Program.cs)
* [Ayuda API TuFactura.co](http://integradordemo.tufactura.co/Help)
* [Adquirir Suscripción](www.tufactura.co)
* [Información Nuget](https://www.nuget.org/packages/TuFactura.co/)
* [Wiki](https://github.com/tufactura-co/NugetTufactura.co/wiki)



