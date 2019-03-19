# TuFactura.co
Permite Integrar sus proyectos con la API de tufactura.co. Emita Facturas y Notas Electrónica para Colombia cumpliendo con todas las normas vigentes.

***

Desde la Consola de paquetes de Visual
* `Install-Package TuFactura.co`


* Agregue las referencias:
<br>`using TuFactura.co;`
<br>`using TuFactura.co.Modelo;`

<br>`private const string Usuario = "";`
<br>`private const string Pass = "";`
<br>`private const string Suscriptor = "";`
<br> Instancie la clase TuFacturaco. 
<br>TuFacturaco tufactura = new TuFacturaco(Usuario, Pass, Suscriptor, Ambientes.Habilitacion) ;
      
