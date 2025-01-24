function resultados = growth_plot(input_file, file_format)
    % growth_plot - Genera una gráfica de crecimiento poblacional a 100 años
    % Parámetros:
    %   input_file (string): Nombre del archivo de entrada (XML).
    %   file_format (string): Formato del archivo ('xml').
    % Salida:
    %   resultados: Estructura con datos de entrada y salida.

    % Validar formato (solo acepta XML en este ajuste)
    %if nargin < 2 || isempty(file_format) || ~strcmp(file_format, 'xml')
    %    error('Formato inválido. Este código solo soporta archivos en formato ''xml''.');
    %end

    % Verificar si el archivo existe
    if nargin < 1 || isempty(input_file) || ~isfile(input_file)
        disp('Archivo no encontrado. Generando datos aleatorios preestablecidos...');
        % Generar datos aleatorios entre 1000 y 5000 como valores iniciales
        anios = 0:10:100;
        poblacion_inicial = randi([1000, 5000], 1); % Población inicial
        tasa_crecimiento = rand() * 0.05 + 0.01; % Tasa de crecimiento entre 1% y 6%
        poblacion = poblacion_inicial * (1 + tasa_crecimiento).^(anios / 10);
    else
        % Leer datos desde el archivo XML
        disp(['Cargando datos desde ', input_file, '...']);
        xml_data = xmlread(input_file);
        anios = str2num(char(xml_data.getElementsByTagName('anios').item(0).getTextContent())); %#ok<ST2NM>
        poblacion = str2num(char(xml_data.getElementsByTagName('poblacion').item(0).getTextContent())); %#ok<ST2NM>
    end

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

    % Guardar resultados en archivo XML
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

    % Escribir archivo XML
    xmlwrite(output_file, docNode);
    disp(['Resultados guardados en ', output_file, '.']);
end
