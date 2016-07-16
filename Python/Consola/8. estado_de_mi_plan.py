# coding=utf-8
# Ejemplo de consumo de API, versión de pruebas.
# Elaborado por: Marlon Jodar, miembro del equipo de desarrollo SunApiPerú.
# Mas información en: https://www.sunapiperu.com/pruebas

'''
IMPORTANTE:
Este script esta elaborado para ejecutarse en una versión de Python igual o posterior a la 2.7.9.
Esta limitante viene dada por el uso del módulo requests que internamente hace uso de la librería urllib3.
En la documentación de dicha librería se especifica que las versiones de python anteriores a la 2.7.9 presentan
restricciones en su módulo ssl lo cuál limita la configuración que urllib3 puede aplicar. En particular esto causa 
que peticiones Https fallen y ciertas caracteristicas de seguridad no esten disponibles emitiendo como resultado
un InsecurePlatformWarning. Mas información en: http://urllib3.readthedocs.org/en/latest/security.html#certifi-with-urllib3.
'''

# Módulo para realizar las peticiones https. (Mas información: http://docs.python-requests.org/)
import requests

# URL donde se realiza la petición https. Ver: https://sunapiperu.com/pruebas#consultaEstadoPlan
API_URL = "https://sunapiperu.com/api_qa/plan" 

mensaje_bienvenida = "Hola, bienvenido a este pequeño script sobre como consultar el estado de tu plan. Esperamos que te sea "+\
			  		 "de utilidad en tus futuras implementaciones. Cualquier duda o inquietud no dudes en comunicarte con nuestro "+\
			  		 "equipo utilizando el formulario de contacto en nuestra página web https://www.sunapiperu.com. Saludos pythonicos, "+\
		  			 "equipo de desarrollo SunApiPerú.\n"

# Imprime los campos del json de respuesta del servidor en el ordén deseado
def imprime_json_en_orden(objeto_json):
	print ("El estado de su plan es:")
	print ('- Tipo de plan: ' + objeto_json['plan'])
	print ('- Peticiones disponibles: ' + str(objeto_json['disponibles']))
	print ('- Peticiones realizadas: ' + str(objeto_json['peticiones']))
	print ('- Fecha de renovación: ' + objeto_json['renueva'])

# Captura la entrada del usuario, realiza la solicitud e imprime el resultado en pantalla
def realiza_solicitud():	
	try:
		# Captura la entrada del usuario
		api_key = input('A continuación escriba su apikey y presione la tecla Enter:\n')
		# Prepara los parametros para realizar la solicitud
		parametros = {'apikey': api_key}
		# Realiza la solicitud teniendo en cuenta un timeout de 5 segundos
		respuesta = requests.get(API_URL, params = parametros, timeout = 5.0)
		# Parsea la respuesta del servidor a un json utilizando el json decoder provisto por requests
		respuesta_json = respuesta.json()
		# Imprime la respuesta	
		if "mensaje" in respuesta_json:
			print (respuesta_json['mensaje'])
		else: 
			imprime_json_en_orden(respuesta_json)							
	except Exception as e:
		# De haber una excepción la imprime		
		print (e)

# Asegura la ejecución procedural del script como módulo primario de ejecución
if __name__ == '__main__':
	print(mensaje_bienvenida)
	realiza_solicitud()
else:
	print ("Ejecuta este script directamente, no lo importes.Gracias!")