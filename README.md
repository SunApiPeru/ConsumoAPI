# ConsumoAPI
Ejemplos de código en diferentes lenguajes de programación para hacer uso de nuestra API.
<div class="page-header">
    <h1>API <small>Funcionalidades</small></h1>
</div>

<p class="bg-warning"> <b>&nbsp;Nota:</b> Todas las funcionalidades deben tener un par&aacute;metro GET <code>api_key</code> con el valor personal de su llave.</p>

<table class="table table-hover">
    <caption>Consulta contribuyentes</caption>
    <thead> <tr> <th>#</th> <th>Funcionalidad</th> <th>Descripci&oacute;n</th> <th>M&eacute;todo</th> <th>Ruta</th> <th>Par&aacute;metros</th> </tr> </thead>
   <tr>
       <td>1</td>
       <td> Obtener contribuyente</td>
       <td>Obtiene el contribuyente seg&uacute;n su RUC</td>
       <td><span class="label label-primary">GET</span></td>
       <td><code>/api/contribuyente</code></td>
       <td><code>ruc [num&eacute;rico]</code></td>
   </tr>
    <tr>
        <td>2</td>
        <td> Obtener contribuyentes</td>
        <td>Obtiene lista de contribuyentes seg&uacute;n el nombre</td>
        <td><span class="label label-primary">GET</span></td>
        <td><code>/api/contribuyente</code></td>
        <td><code>nombre [alfanum&eacute;rico], todos [boleano, opcional]</code></td>
    </tr>
    <tr>
        <td>3</td>
        <td><span class="label label-default">Nuevo</span> Validar RUC</td>
        <td>Valida si un RUC tiene la estructura correcta</td>
        <td><span class="label label-primary">GET</span></td>
        <td><code>/api/validar_ruc</code></td>
        <td><code>ruc [num&eacute;rico]</code></td>
    </tr>

</table>

<table class="table table-hover">
  <caption>Consulta tasas de cambio</caption>
  <thead> <tr> <th>#</th> <th>Funcionalidad</th> <th>Descripci&oacute;n</th> <th>M&eacute;todo</th> <th>Ruta</th> <th>Par&aacute;metros</th> </tr> </thead>
        <tr>
            <td>1</td>
            <td> Tasa actual de cambio </td>
            <td>Obtiene la tasa de cambio actual del Sol</td>
            <td><span class="label label-primary">GET</span></td>
            <td><code>/api/soles</code></td>
            <td><code>moneda [alfanum&eacute;rico, opcional]</code></td>
        </tr>
        <tr>
            <td>2</td>
            <td> Tasa de cambio</td>
            <td>Obtiene la tasa de cambio del Sol en una fecha indicada</td>
            <td><span class="label label-primary">GET</span></td>
            <td><code>/api/soles</code></td>
            <td><code>moneda [alfanum&eacute;rico], fecha [d-m-Y]</code></td>
        </tr>
        <tr>
            <td>3</td>
            <td><span class="label label-default">Nuevo</span> C&aacute;lculo de cambio actual</td>
            <td>Calcula el monto del cambio de moneda</td>
            <td><span class="label label-primary">GET</span></td>
            <td><code>api/calculadora</code></td>
            <td><code>de [caracteres], a [caracteres], valor [num&eacute;rico]</code></td>
        </tr>
        <tr>
      <td>3</td>
      <td><span class="label label-default">Nuevo</span> C&aacute;lculo de cambio</td>
      <td>Calcula el monto del cambio de moneda</td>
      <td><span class="label label-primary">GET</span></td>
      <td><code>api/calculadora</code></td>
      <td><code>de [caracteres], a [caracteres], valor [num&eacute;rico], fecha [d-m-Y]</code></td>
      </tr>

  </table>
