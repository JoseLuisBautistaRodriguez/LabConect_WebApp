<script>
	export let name;

	import { onMount } from "svelte";
  let datosFormulario = { parametro1: "", parametro2: "" };
  let datosTabla = [];
  let resultados = [];

  const enviarDatos = () => {
    const nuevaVentana = window.open(
      "/ventana-secundaria",
      "_blank",
      "width=800,height=600"
    );

    const datosParaEnviar = { ...datosFormulario };
    nuevaVentana.onload = () => {
      nuevaVentana.postMessage(datosParaEnviar, "*");
    };

    // Limpiar formulario
    datosFormulario = { parametro1: "", parametro2: "" };
  };

  // Escuchar datos devueltos por la ventana secundaria
  onMount(() => {
    window.addEventListener("message", (event) => {
      if (event.data && event.data.resultados) {
        resultados = event.data.resultados;
        datosTabla.push(event.data.datos);
      }
    });
  });

</script>

<main>
	
	<aside>
		<h1>LabConnect SMC</h1>
		<p>Conexión en tiempo real con MATLAB y resultados integrados.</p>
	  </aside>
	  <section>
		<table>
		  <thead>
			<tr>
			  <th>Parámetro 1</th>
			  <th>Parámetro 2</th>
			  <th>Resultados</th>
			</tr>
		  </thead>
		  <tbody>
			{#each datosTabla as fila, i}
			  <tr>
				<td>{fila.parametro1}</td>
				<td>{fila.parametro2}</td>
				<td>{resultados[i] || "Pendiente"}</td>
			  </tr>
			{/each}
		  </tbody>
		</table>
	
		<form on:submit|preventDefault={enviarDatos}>
		  <div>
			<label>Parámetro 1:</label>
			<input
			  type="text"
			  bind:value={datosFormulario.parametro1}
			  placeholder="Ingrese dato"
			  required
			/>
		  </div>
		  <div>
			<label>Parámetro 2:</label>
			<input
			  type="text"
			  bind:value={datosFormulario.parametro2}
			  placeholder="Ingrese dato"
			  required
			/>
		  </div>
		  <button type="submit">Enviar</button>
		</form>
	  </section>

</main>

<style>
	main {
    display: flex;
    flex-direction: row;
    height: 100vh;
    padding: 0;
    margin: 0;
    box-sizing: border-box;
  }
  aside {
    flex: 1;
    padding: 1em;
    background: #f4f4f4;
    text-align: center;
  }
  section {
    flex: 2;
    padding: 1em;
  }
  table {
    width: 100%;
    border-collapse: collapse;
    margin-bottom: 1em;
  }
  th,
  td {
    border: 1px solid #ddd;
    padding: 8px;
  }

</style>