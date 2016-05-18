<?php
	if(isset($_GET['Nombre']))
	{
		$nombre = $_GET['Nombre'];
		// Creo la url con la direccion del servicio y sus parametros
		$dir = "https://sunapiperu.com/api/contribuyente?nombre=".$nombre."";
		// Obtengo el resultado del servicio en formato json
		$dir_json = file_get_contents($dir);
		// Convierto la cadena json en un array php de objetos json
		$dir_array = json_decode($dir_json,true);
		//var_dump($dir_array);			
	}	
?>

 <!DOCTYPE html>
<html lang="en">
    <head>
    	<meta charset="UTF-8" />
        <title>Resultado de Json</title>        
		<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
		<link rel="stylesheet" href="css/bootstrap.min.css">
		<link rel="stylesheet" href="css/estilos.css">
	</head>
    <body>
    <div class="container">
    	<div class="table-responsive">
						
				<table class="table">
				<caption class="text-info text-center">Resultado de la cadena json que brinda el servicio REST</caption>
					<thead >
						<tr class="info">
							<th>RUC</th>
							<th>Estado</th>
							<th>Nombre</th>
							<th>Calle</th>
							<th>Numero</th>
						</tr>
					</thead>
					<tbody>
						<?php
						foreach ($dir_array as $row) {
						?>
						<tr >
							<td><?php echo $row['ruc']; ?></td>
							<td><?php echo $row['estado']; ?></td>
							<td><?php echo $row['nombre']; ?></td>
							<td><?php echo $row['calle']; ?></td>
							<td><?php echo $row['numero']; ?></td>
						</tr>						
						<?php } ?>
					</tbody>
				</table>
		   	
		</div> 
    </div>
    	
		<script src="js/jquery.js"></script>
		<script src="js/bootstrap.min.js"></script>
	</body>
</html>