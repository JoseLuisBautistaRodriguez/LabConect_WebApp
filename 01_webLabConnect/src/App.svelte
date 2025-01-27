<script>
	let poblacionInicial = ""; // Dato ingresado en el formulario
	let datosEntrada = []; // Almacena los datos enviados
	let datosSalida = []; // Almacena los datos recibidos de la ventana secundaria
  
	const enviarDatos = () => {
	  if (!poblacionInicial) {
		alert("Por favor, ingresa la población inicial.");
		return;
	  }
  
	  // Generar datos de entrada basados en la población inicial
	  const anios = Array.from({ length: 11 }, (_, i) => i * 10); // [0, 10, 20, ..., 100]
	  const tasaCrecimiento = 0.2; // Tasa de crecimiento fija para este ejemplo
	  const poblacion = anios.map((anio) => Math.round(poblacionInicial * (1 + tasaCrecimiento) ** (anio / 10)));
  
	  datosEntrada = { anios, poblacion }; // Almacena los datos generados localmente
  
	  // Crear una nueva ventana para enviar los datos
	  const nuevaVentana = window.open(
		"/ventana-secundaria",
		"_blank",
		"width=800,height=600"
	  );
  
	  // Enviar datos en formato XML
	  const xmlData = `
		<?xml version="1.0" encoding="UTF-8"?>
		<resultados>
		  <anios>${anios.join(" ")}</anios>
		  <poblacion>${poblacion.join(" ")}</poblacion>
		</resultados>
	  `;
	  nuevaVentana.onload = () => {
		nuevaVentana.postMessage(xmlData, "*");
	  };
  
	  // Limpiar el formulario
	  poblacionInicial = "";
	};
  
	// Escuchar datos de la ventana secundaria
	window.addEventListener("message", (event) => {
	  if (event.data) {
		// Parsear datos recibidos como XML
		const parser = new DOMParser();
		const xmlDoc = parser.parseFromString(event.data, "text/xml");
  
		const anios = xmlDoc.getElementsByTagName("anios")[0]?.textContent.split(" ") || [];
		const poblacion = xmlDoc.getElementsByTagName("poblacion")[0]?.textContent.split(" ") || [];
  
		datosSalida = { anios, poblacion }; // Actualiza los datos de salida
	  }
	});
</script>

<style>
	

</style>


<main>
	<!-- Encabezado -->
	<aside>
	  <h1>LabConnect SMC</h1>
	  <p>Conexión con MATLAB y procesamiento de datos.</p>
	</aside>
  
	<!-- Secciones principales -->
	<div class="container">
	  <!-- Formulario -->
	  <div class="formulario">
		<h2 text-aling="center" >Formulario</h2>
		<form on:submit|preventDefault={enviarDatos}>
		  <label>
			Población inicial:
			<input
			  type="number"
			  bind:value={poblacionInicial}
			  placeholder="Ingresa la población inicial"
			  required
			/>
		  </label>
		  <button type="submit">Enviar</button>
		</form>
	  </div>
  
	  <!-- Tabla de datos de entrada -->
	  <div class="datos-entrada">
		<h2>Datos de entrada</h2>
		<table>
		  <thead>
			<tr>
			  <th>Años</th>
			  <th>Población</th>
			</tr>
		  </thead>
		  <tbody>
			{#if datosEntrada.anios && datosEntrada.poblacion}
			  {#each datosEntrada.anios as anio, i}
				<tr>
				  <td>{anio}</td>
				  <td>{datosEntrada.poblacion[i]}</td>
				</tr>
			  {/each}
			{:else}
			  <tr>
				<td colspan="2">Sin datos de entrada</td>
			  </tr>
			{/if}
		  </tbody>
		</table>
	  </div>
  
	  <!-- Tabla de datos de salida -->
	  <div class="datos-salida">
		<h2>Datos de salida</h2>
		<table>
		  <thead>
			<tr>
			  <th>Años</th>
			  <th>Población</th>
			</tr>
		  </thead>
		  <tbody>
			{#if datosSalida.anios && datosSalida.poblacion}
			  {#each datosSalida.anios as anio, i}
				<tr>
				  <td>{anio}</td>
				  <td>{datosSalida.poblacion[i]}</td>
				</tr>
			  {/each}
			{:else}
			  <tr>
				<td colspan="2">Esperando datos...</td>
			  </tr>
			{/if}
		  </tbody>
		</table>
	  </div>
	</div>

</main>
  
  