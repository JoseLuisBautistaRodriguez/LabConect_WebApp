<script>
	let poblacionInicial = ""; // Dato ingresado en el formulario
	let datosEntrada = []; // Almacena los datos enviados
	let datosSalida = []; // Almacena los datos recibidos del servidor
	let idEntrada = null; // Almacena el ID de entrada generado
	let esperandoDatos = false; // Indica si estamos esperando datos de salida
  
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
  
	  try {
		// Enviar datos de entrada al backend
		const responseEntrada = await fetch("http://localhost:3000/guardar-entrada", {
		  method: "POST",
		  headers: {
			"Content-Type": "application/json",
		  },
		  body: JSON.stringify({ poblacionInicial: parseInt(poblacionInicial) }),
		});
  
		if (!responseEntrada.ok) {
		  throw new Error("Error al enviar los datos de entrada");
		}
  
		const { idEntrada: id } = await responseEntrada.json();
		idEntrada = id; // Guardar el ID de entrada
  
		// Iniciar polling para verificar datos de salida
		esperandoDatos = true;
		consultarDatosSalida();
	  } catch (error) {
		console.error("Error:", error);
		alert("Hubo un error al enviar los datos al servidor.");
	  }
  
	  // Limpiar el formulario
	  poblacionInicial = "";
	};
  
	const consultarDatosSalida = async () => {
	  if (!idEntrada) return;
  
	  try {
		const response = await fetch(`http://localhost:3000/consultar-salida/${idEntrada}`);
		if (!response.ok) {
		  throw new Error("Error al consultar datos de salida");
		}
  
		const data = await response.json();
  
		if (data) {
		  // Si hay datos de salida, actualizar la interfaz
		  const anios = data.datos_xml.match(/<anios>(.*?)<\/anios>/)[1].split(" ");
		  const poblacion = data.datos_xml.match(/<poblacion>(.*?)<\/poblacion>/)[1].split(" ");
		  datosSalida = { anios, poblacion };
		  esperandoDatos = false; // Detener el polling
		} else {
		  // Si no hay datos, volver a consultar en 5 segundos
		  setTimeout(consultarDatosSalida, 5000);
		}
	  } catch (error) {
		console.error("Error:", error);
		esperandoDatos = false; // Detener el polling en caso de error
	  }
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