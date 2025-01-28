# LabConect_WebApp

https://secihti.mx/sistema-nacional-de-investigadores/tramites-y-servicios/?fbclid=IwY2xjawIAOV1leHRuA2FlbQIxMAABHb2lZ0chPBvB1Qcbu6SUbrpSEukVMoqKNJj7gywVHZsTd1aQ-N6T-Zj4xg_aem_nCPY7DorHByArbUBpPhJwA

## 02 web LabConnect 
### Entorno de desarrollo

Instalación de depedencias de Svelte en el prototipado: 
```bash
nom install svelte --save

npm install @babel/core @babel/present-env babel-loader svelte-loader --save-dev

npm install webpack webpack webpack-cli html-webpack-pugin --save-dev
```

Es necesario realizar en el eentorno rai del proyecto un archivo para registrar las onfiguraciones de webpack, para ello se nombra como _webpack.config.js_ y contendrá lo siguiente: 

```javascript
const path =  require('path')
const htlmlWebpackplugin = require('html-webpack-plugin')

module.exports = {
    entry: './src/index.js',
    ouput: {
        path: path.resolve(__dirname, 'dist'),
        filename: 'bundele.js'
    }, 
    resolve:{
        extensions: ['*', '.mjs', '.js', '.svelte']
    },
    module: {
        rules:[
            {
                rest: /\.js?$/,
                exlude: /node_modules/,
                use: {
                    loader:'babel-loader'
                }
            },
            {
                test: /\-svelte$/,
                exclude: /node_modules/,
                use:
                {
                    loader: 'svelte-loader'
                }
            }
        ]
    }, 
    plugins: [
        new HtmlWebpackPlugin({
            inject: true, 
            template: './public/inddex.html',
            filename: './index.html'
        })
    ]
}
```

Para realizar las pruebas del entorno locar se emplea webpack dev serrver el cual se cconfigura de la siguiente forma: 

```bash
npm install webpack-dev-server --save-dev
```
Dentro de _package.json_ en "scripts" el apartado de _"test": "echo \"Error: no test specified\" && exit 1"_ de prueas se enuentra pausada para realizar las pruebas de desarrollo, build y start deben cambiar su estado al momento dde estar en producción. 
Las pruebas de funcionamiento pasan por:
```bash 
npm run build
```
y después: 
```bash
npm run start
```
Instalación de las dependenccias para el uso de la base de datos: 
```bash
npm init -y
npm iinstall express mysql12 cors body-parser
```

Es necesario teneer instalado el complemento de mysql2: 
```bash
npm install mysql2
```

Inicializacion del servidor:
```bash
node server.js
```

Version LTS - Lng-Term Support de Node.js:
```bash
nvm install --lts
nvm use --lts 
```