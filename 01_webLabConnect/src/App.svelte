<script>
	let poblacionInicial = ""; // Dato ingresado en el formulario
	let datosEntrada = []; // Almacena los datos enviados
	let datosSalida = []; // Almacena los datos recibidos del servidor
  
	const enviarDatos = async () => {
	  if (!poblacionInicial) {
		alert("Por favor, ingresa la población inicial.");
		return;
	  }
  
	  // Generar datos de entrada basados en la población inicial
	  const anios = Array.from({ length: 11 }, (_, i) => i * 10); // [0, 10, 20, ..., 100]
	  const tasaCrecimiento = 0.2; // Tasa de crecimiento fija para este ejemplo
	  const poblacion = anios.map((anio) =>
		Math.round(poblacionInicial * (1 + tasaCrecimiento) ** (anio / 10))
	  );
  
	  datosEntrada = { anios, poblacion }; // Almacena los datos generados localmente
  
	  // Crear el XML
	  const xmlData = `
		<?xml version="1.0" encoding="UTF-8"?>
		<resultados>
		  <anios>${anios.join(" ")}</anios>
		  <poblacion>${poblacion.join(" ")}</poblacion>
		</resultados>
	  `;
  
	  try {
		// Enviar datos al servidor
		const response = await fetch("http://localhost:8080/datos.xml", {
		  method: "POST",
		  headers: {
			"Content-Type": "application/xml", // Indicar que enviamos XML
		  },
		  body: xmlData, // Enviar el XML como cuerpo de la solicitud
		});
  
		if (!response.ok) {
		  throw new Error("Error al enviar los datos al servidor en A");
		}
  
		// Si el servidor devuelve una respuesta, procesarla
		const responseData = await response.text();
		const parser = new DOMParser();
		const xmlDoc = parser.parseFromString(responseData, "text/xml");
  
		const aniosRespuesta = xmlDoc.getElementsByTagName("anios")[0]?.textContent.split(" ") || [];
		const poblacionRespuesta = xmlDoc.getElementsByTagName("poblacion")[0]?.textContent.split(" ") || [];
  
		datosSalida = { anios: aniosRespuesta, poblacion: poblacionRespuesta }; // Actualizar datos de salida
	  } catch (error) {
		console.error("Error:", error);
		alert("Hubo un error al enviar los datos al servidor. en B");
	  }
  
	  // Limpiar el formulario
	  poblacionInicial = "";
	};
  </script>
  
  <style>
	/* Tus estilos aquí */
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
		<h2 text-aling="center">Formulario</h2>
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