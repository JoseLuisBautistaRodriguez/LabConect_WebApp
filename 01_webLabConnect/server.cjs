const express = require("express");

const app = require("express")();
const PORT = 3000;

// Verificar si el puerto está disponible
const server = app.listen(PORT, () => {
  console.log(`Servidor escuchando en http://localhost:${PORT}`);
});

server.on("error", (err) => {
  if (err.code === "EADDRINUSE") {
    console.error(`El puerto ${PORT} está ocupado. Usa otro puerto.`);
  } else {
    console.error(err);
  }
});

// Ruta para devolver el archivo XML
app.get("/data.xml", (req, res) => {
  const tasaCrecimiento = 0.2;
  const poblacionInicial = 1000; // Cambiar según tu lógica
  const anios = Array.from({ length: 11 }, (_, i) => i * 10);
  const poblacion = anios.map((anio) => Math.round(poblacionInicial * (1 + tasaCrecimiento) ** (anio / 10)));

  const xmlResponse = `
    <?xml version="1.0" encoding="UTF-8"?>
    <resultados>
      <anios>${anios.join(" ")}</anios>
      <poblacion>${poblacion.join(" ")}</poblacion>
    </resultados>
  `;

  res.set("Content-Type", "application/xml");
  res.send(xmlResponse);
});

// Sirve los archivos de tu aplicación Svelte
app.use(express.static("public")); // Asegúrate de que `public` contenga tu aplicación Svelte compilada

// Inicia el servidor
app.listen(PORT, () => {
  console.log(`Servidor escuchando en http://localhost:${PORT}`);
});
