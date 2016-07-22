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

# URL donde se realiza la petición https. (Ver https://www.sunapiperu.com/pruebas)
API_URL = "https://sunapiperu.com/api_qa/historial/contribuyente"

# Api key para poder consultar la API de pruebas
API_KEY = 'sunapi'

mensaje_bienvenida = "Hola, bienvenido a este pequeño script sobre como obtener información de un contribuyente dado de baja usando su RUC. Esperamos que "+\
			  		 "te sea de utilidad en tus futuras implementaciones. Cualquier duda o inquietud no dudes en comunicarte con nuestro "+\
			  		 "equipo utilizando el formulario de contacto en nuestra página web https://www.sunapiperu.com. Saludos pythonicos, "+\
		  			 "equipo de desarrollo SunApiPerú.\n"

# Captura la entrada del usuario, realiza la solicitud e imprime el resultado en pantalla
def realiza_solicitud():	
	try:
		# Captura la entrada del usuario
		ruc = input('A continuación escriba el RUC del contribuyente que desea consultar y presione la tecla Enter:\n')
		# Prepara los parametros para realiza la solicitud
		parametros = {'apikey':API_KEY, 'ruc':ruc}
		# Realiza la solicitud teniendo en cuenta un timeout de 5 segundos
		respuesta = requests.get(API_URL, params = parametros, timeout=5.0)
		# Parsea la respuesta del servidor a un json utilizando el json decoder provisto por requests
		respuesta_json = respuesta.json()
		# Verifica la respuesta del servidor e imprime en consola de acorde a los resultados
		if "mensaje" in respuesta_json:
			print(respuesta_json['mensaje'])
		else: 
			print("El servidor respondió:\n")						
			for key in respuesta_json:
				print('- ' + key + ': ' + str(respuesta_json[key]))			
	except Exception as e:
		# Ante cualquier excepción imprime la excepción
		print (e)	

# Asegura la ejecución procedural del script como módulo primario de ejecución
if __name__ == '__main__':
	print(mensaje_bienvenida)
	realiza_solicitud()
else:
	print ("Ejecuta este script directamente, no lo importes.Gracias!")