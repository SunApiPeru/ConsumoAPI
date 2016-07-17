Introducción

¿Que es Sunapi?
Basicamente  es una API orientada específicamente a ofrecer servicios de integración que le permitirá a su empresa obtener a través de sus aplicaciones, consultas de contribuyentes e información financiera del Perú. Proporciona una forma directa de acceder a esos servicios a través de una solicitud HTTPS.

A modo de aclaración:
Esta API está orientada a desarrolladores de aplicativos de gestión empresarial, móviles u otros que quieran usar información de contribuyentes y al mismo tiempo información financiera correspondientes a las políticas monetarias y de tasas de cambio del sol y otras monedas en Perú. Para usar dicha API, es necesario una API key o token (secuencia de numeros alfanúmericos). Si desea obtener este token debe ingresar a nuestra pagina oficial <https://sunapiperu.com> y loggearse con su usuario de Gmail o GitHub. Acto seguido puede verificar u obtener su API key en la sección de configuración del menu que se encuentra ubicado justo en la esquina superior derecha del sitio, representado con su imagen de perfil(Gmail o GitHub).

A continuación se describen todas las funcionalidades de nuestra API y se muestran ejemplos de como debe ser una solicitud HTTPS. Estas consultas se dividen en tres tipos: contribuyentes, tasas de cambio y cálculo.La respuesta se brinda en formato JSON.

FORMATO DE SOLICITUD

Una solicitud al API de tipo contribuyente debe respetar el siguiente formato:
<https://sunapiperu.com/api/contribuyente?parameters> donde:

parameters: son los parámetros que espera el servicio.Algunos parámetros son obligatorios y otros opcionales. Como es norma en las direcciones URL, los parámetros se separan con el carácter de Y comercial (&).

CONSULTAS DE CONTRIBUYENTE

1.Obtener lista de contribuyente por nombre
	- Descripción:
	El servicio realiza una búsqueda de contribuyentes por nombre y devuelve una lista,si no existen coincidencias devuelve un mensaje.Permite filtrar la búsqueda por el estado del contribuyente, activos o inactivos.
	
	- Solicitud:
	<https://sunapiperu.com/api/contribuyente?nombre=bar restaurant&apikey=YOUR_API_KEY&todos=true>
	
	- Parámetros obligatorios:
	.nombre: Es el nombre por el cual se realiza la búsqueda del contribuyente.
	.ApiKey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.
	
	- Parámetros opcionales:
	.todos: Parámetro opcional que permite filtrar los contribuyentes por su estado, acepta valores "True" o "False". El primer valor filtra todos los contribuyentes, mientras que el segundo solo los activos. Si se ignora este parámetro, se filtra solo los contribuyentes activos.

2.Obtener contribuyente por RUC
	Descripción:
	El servicio realiza una busqueda de contribuyente por ruc,devuelve un único contribuyente si existe.Si el ruc ingresado es incorrecto devuelve un mensaje de error, de la misma manera si no existe,devuelve el mensaje correspondiente.

	Solicitud:
	<https://sunapiperu.com/api/contribuyente?ruc=20100094640&apikey=YOUR_API_KEY>

	Parametros obligatorios:
	.ruc: Es el ruc por el que se realiza la busqueda
	.ApiKey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

3.Validar RUC
	Descripción:
	El servicio valida que un RUC sea correcto o no.

	Solicitud:
	<https://sunapiperu.com/api/validar_ruc?ruc=20100094640&apikey=YOUR_API_KEY>

	Parámetros Obligatorios:
	.ruc: Es el ruc que es validado.
	.apikey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

CONSULTAS DE TASA DE CAMBIO Y CALCULO

1.Obtener tasa de cambio actual del sol peruano
	Descripción:
	Obtiene la tasa de cambio actual del sol con respecto a la moneda que se pase como parámetro y a la fecha . Las monedas permitidas son:"USD, EUR, CAD, GBP, SEK, CHF, JPY". Si no se le pasa moneda, devuelve la tasa del USD por defecto. Si no se le pasa fecha toma la actual.

	Solicitud:
	<https://sunapiperu.com/api/soles?moneda=eur&apikey=YOUR_API_KEY&fecha=10-03-2016>

	Parámetros Obligatorios:
	.apikey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

	Parámetros Opcionales:
	.moneda: Es la moneda a la que se le aplica la tasa de cambio("USD, EUR, CAD, GBP, SEK, CHF, JPY"). Si no se especifica devuelve la tasa de cambio al USD por defecto.
	.fecha: Es la fecha en la que se desea ver la tasa de cambio. Si no existe esa fecha en la base de datos, se retorna para la inmediata inferior.

2.Calcula monto segun tasa actual del sol

	Descripción:
	Calcula el monto de acuerdo a la tasa de cambio actual del sol con respecto a las monedas que se pase como parámetro, la fecha y el valor inicial . Las monedas permitidas son:"USD, EUR, CAD, GBP, SEK, CHF, JPY". Si no se pasa fecha toma la actual.

	Solicitud:
	<https://sunapiperu.com/api/calculadora?valor=500&de=usd&a=eur&apikey=YOUR_API_KEY&fecha=10-03-2016>

	Parámetros Obligatorios:
	.valor: Es el valor inicial de la moneda a ser cambiada.
	.de: Tipo de moneda al que pertenece el valor inicial a ser cambiado.
	.a: Tipo de moneda a la que se desea cambiar.
	.apikey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

	Parámetros Opcionales:	
	.fecha: Es la fecha en la que se desea ver la tasa de cambio. si no existe esa fecha en la base de datos, el servicio devuelve la inmediata inferior.

	Nota: Si no se le pasa los parámetros ("de","a") el servicio convierte de PEN a USD por defecto.
