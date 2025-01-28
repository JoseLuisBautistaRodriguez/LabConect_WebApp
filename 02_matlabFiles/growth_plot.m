function resultados = growth_plot(input_file)
    % growth_plot - Genera una gráfica de crecimiento poblacional a 100 años
    % a partir de un archivo XML con un único valor de población inicial.
    % Parámetros:
    %   input_file (string): Nombre del archivo de entrada (XML).
    % Salida:
    %   resultados: Estructura con datos de entrada y salida.

    % Verificar si el archivo existe
    if nargin < 1 || isempty(input_file) || ~isfile(input_file)
        error('El archivo de entrada no fue encontrado. Proporcione un archivo válido.');
    end

    % Leer el archivo XML de entrada
    disp(['Cargando datos desde ', input_file, '...']);
    xml_data = xmlread(input_file);

    % Obtener el valor de la población inicial
    poblacion_inicial_node = xml_data.getElementsByTagName('poblacion').item(0);
    if isempty(poblacion_inicial_node)
        error('El archivo de entrada no contiene un nodo de población inicial.');
    end
    poblacion_inicial = str2double(poblacion_inicial_node.getTextContent());
    if isnan(poblacion_inicial)
        error('El valor de población inicial no es un número válido.');
    end

    % Calcular los datos para 100 años
    anios = 0:10:100; % Intervalos de 10 años
    tasa_crecimiento = 0.02; % Tasa de crecimiento fija (2%)
    poblacion = poblacion_inicial * (1 + tasa_crecimiento).^(anios / 10);

    % Graficar los datos
    figure;
    plot(anios, poblacion, '-o', 'LineWidth', 2, 'MarkerSize', 8);
    title('Crecimiento Poblacional a 100 años');
    xlabel('Años');
    ylabel('Población');
    grid on;

    % Guardar resultados en la estructura de salida
    resultados.anios = anios;
    resultados.poblacion = poblacion;

    % Generar el archivo XML de salida
    output_file = 'resultados.xml';
    docNode = com.mathworks.xml.XMLUtils.createDocument('resultados');
    root = docNode.getDocumentElement;

    % Crear nodo de años
    anios_node = docNode.createElement('anios');
    anios_node.appendChild(docNode.createTextNode(num2str(anios)));
    root.appendChild(anios_node);

    % Crear nodo de población
    poblacion_node = docNode.createElement('poblacion');
    poblacion_node.appendChild(docNode.createTextNode(num2str(poblacion)));
    root.appendChild(poblacion_node);

    % Escribir el archivo XML
    xmlwrite(output_file, docNode);
    disp(['Resultados guardados en ', output_file, '.']);
end
