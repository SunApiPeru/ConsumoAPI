Introducción

¿Que es Sunapi?
Basicamente  es una API orientada específicamente a ofrecer servicios de integración que le permitirá a su empresa obtener a través de sus aplicaciones, consultas de contribuyentes e información financiera del Perú.Proporciona una forma directa de acceder a esos servicios a través de una solicitud HTTPS.

A modo de aclaración:
Esta API está orientada a desarrolladores de aplicativos de gestión empresarial, móviles u otros que quieran usar información de contribuyentes y al mismo tiempo información financiera correspondientes a las políticas monetarias y de tasas de cambio del sol y otras monedas en Perú.Para usar Sunapi, necesitas una ApiKey(secuencia de numeros alfanúmericos). Para obtener esta ApiKey debe ingresar a nuestra pagina oficial <https://sunapiperu.com> y loggearse con su usuario de Gmail o GitHub. Acto seguido puede verificar u obtener su ApiKey en la sección de configuración del menu que se encuentra ubicado justo en la esquina superior derecha del sitio, representado con su imagen de perfil(Gmail o GitHub).

A continuación se describen todas las funcionalidades de nuestra Api y se muestran ejemplos de como debe ser una solicitud HTTPS. Estas consultas se dividen en dos tipos: Contribuyente y Tasas de Cambio y Calculo.La respuesta estará dada en formato JSON

FORMATO DE SOLICITUD

Una solicitud de SunapiPeru de contribuyente debe respetar la siguiente forma:
<https://sunapiperu.com/api/contribuyente?parameters>

parameters: son los parametros que espera el servicio.Algunos parámetros son obligatorios y otros opcionales. Como es norma en las direcciones URL, los parámetros se separan con el carácter de Y comercial (&).


CONSULTAS DE CONTRIBUYENTE

1.Obtener lista de contribuyente por nombre
	Descripción:
	El servicio realiza una busqueda de contribuyentes por nombre y devuelve una lista,si no existe devuelve un mensaje.Permite filtrar la busqueda por el estado del contribuyente, activos o inactivos.

	Solicitud:
	<https://sunapiperu.com/api/contribuyente?nombre=bar restaurant&apikey=YOUR_API_KEY&todos=true>

	Parametros obligatorios:
	.nombre: Es el nombre por el cual se realiza la busqueda del contribuyente.
	.ApiKey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

	Parametros opcionales:
	.todos: Parametro opcional que permite filtrar los contribuyentes por su estado, acepta valores "True" o "False". El primer valor filtra todos los contribuyentes, mientras que el segundo solo los activos. Si se ignora este parametro, se filtra solo los contribuyentes activos.

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

	Parametros Obligatorios:
	.ruc: Es el ruc que es validado.
	.ApiKey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

CONSULTAS DE TASA DE CAMBIO Y CALCULO

1.Obtener tasa de cambio actual del sol
	Descripción:
	Obtiene la tasa de cambio actual del sol con respecto a la moneda que le pases como parámetro y a la fecha . Las monedas permitidas son:"USD, EUR, CAD, GBP, SEK, CHF, JPY".si no le pasas moneda, devuelve la tasa del USD por defecto. Si no le pasas fecha toma la actual.

	Solicitud:
	<https://sunapiperu.com/api/soles?moneda=eur&apikey=YOUR_API_KEY&fecha=10-03-2016>

	Parametros Obligatorios:
	.ApiKey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

	Parametros Opcionales:
	.moneda: Es la moneda a la que se le aplica la tasa de cambio("USD, EUR, CAD, GBP, SEK, CHF, JPY"). Si no se especifica devuelve la tasa de cambio al USD por defecto
	.fecha: Es la fecha a la que quieres la tasa de cambio. si no existe esa fecha en base, el servicio devuelve la inmediata inferior.

2.Calcula monto segun tasa actual del sol

	Descripción:
	Calcula el monto de acuerdo a la tasa de cambio actual del sol con respecto a las monedas que le pases como parámetro, la fecha y el valor inicial . Las monedas permitidas son:"USD, EUR, CAD, GBP, SEK, CHF, JPY".Si no le pasas fecha toma la actual.

	Solicitud:
	<https://sunapiperu.com/api/calculadora?valor=500&de=usd&a=eur&apikey=YOUR_API_KEY&fecha=10-03-2016>

	Parametros Obligatorios:
	.valor: Es el valor inicial de la moneda que quieres cambiar.
	.de: Tipo de moneda al que pertenece el valor inicial que quieres cambiar
	.a: Tipo de moneda a la que quieres cambiar
	.ApiKey: Es la clave que se le asigna al usuario del cliente, una vez tenga un plan, para poder tener acceso al servicio.

	Parametros Opcionales:	
	.fecha: Es la fecha a la que quieres la tasa de cambio. si no existe esa fecha en base, el servicio devuelve la inmediata inferior.

	Nota: Si no se le pasa los parametros ("de","a") el servicio convierte de PEN a USD por defecto.








