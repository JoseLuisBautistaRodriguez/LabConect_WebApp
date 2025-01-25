<script>
    let datosRecibidos = {};
  
    // Escuchar datos enviados desde la ventana principal
    window.addEventListener("message", (event) => {
      if (event.data) {
        datosRecibidos = event.data;
  
        // Simular procesamiento y enviar resultados de regreso
        const resultados = {
          resultados: `Resultado de ${datosRecibidos.parametro1} y ${datosRecibidos.parametro2}`,
          datos: datosRecibidos,
        };
  
        window.opener.postMessage(resultados, "*");
      }
    });
  </script>
  
  <style>
    main {
      display: flex;
      justify-content: center;
      align-items: center;
      height: 100vh;
      font-family: Arial, sans-serif;
    }
  </style>
  
  <main>
    <h1>Procesando datos...</h1>
    <p>{datosRecibidos.parametro1} - {datosRecibidos.parametro2}</p>
  </main>
  