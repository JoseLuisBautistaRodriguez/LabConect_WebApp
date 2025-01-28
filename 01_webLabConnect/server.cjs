const express = require("express");
const mysql = require("mysql2");
const bodyParser = require("body-parser");
const cors = require("cors");

const app = express();
const port = 3000;

// Middleware
app.use(cors());
app.use(bodyParser.json());

// Conexión a MySQL
const connection = mysql.createConnection({
  host: "localhost",
  user: "root", // Usuario de MySQL
  password: "24445", // Contraseña de MySQL
  database: "labconnect_smc",
});

connection.connect((err) => {
  if (err) {
    console.error("Error conectando a MySQL:", err);
    return;
  }
  console.log("Conectado a MySQL");
});

// Ruta para guardar datos de entrada
app.post("/guardar-entrada", (req, res) => {
  const { poblacionInicial } = req.body;

  if (!poblacionInicial) {
    return res.status(400).json({ error: "Población inicial es requerida" });
  }

  const query = "INSERT INTO datos_entrada (poblacion_inicial) VALUES (?)";
  connection.query(query, [poblacionInicial], (err, results) => {
    if (err) {
      console.error("Error insertando en datos_entrada:", err);
      return res.status(500).json({ error: "Error en el servidor" });
    }

    const idEntrada = results.insertId;
    res.json({ idEntrada });
  });
});

// Ruta para consultar datos de salida
app.get("/consultar-salida/:idEntrada", (req, res) => {
  const { idEntrada } = req.params;

  const query = "SELECT * FROM datos_salida WHERE id_entrada = ?";
  connection.query(query, [idEntrada], (err, results) => {
    if (err) {
      console.error("Error consultando datos_salida:", err);
      return res.status(500).json({ error: "Error en el servidor" });
    }

    if (results.length > 0) {
      res.json(results[0]); // Devuelve el primer resultado (si existe)
    } else {
      res.json(null); // No hay datos de salida aún
    }
  });
});

// Iniciar el servidor
app.listen(port, () => {
  console.log(`Servidor backend corriendo en http://localhost:${port}`);
});