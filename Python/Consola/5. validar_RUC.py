# coding=utf-8
# Ejemplo de consumo de API de prueba, SunApiPerú.
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
# Importa la librería requests para realizar las peticiones https. (Mas información: http://docs.python-requests.org/)
import requests

# Variable global
API_URL = "https://sunapiperu.com/api/validar_ruc" # URL donde se realiza la petición https. (Ver https://www.sunapiperu.com/features)

mensaje_bienvenida = "Hola, bienvenido a este pequeño demo sobre como validar la estructura de un RUC. Esperamos que te sea "+\
			  		 "de utilidad en tus futuras implementaciones. Cualquier duda o inquietud no dudes en comunicarte con nuestro "+\
			  		 "equipo utilizando el formulario de contacto en nuestra página web https://www.sunapiperu.com. Saludos pythonicos, "+\
		  			 "equipo de desarrollo SunApiPerú.\n"

# Función que captura la entrada del usuario, realiza la solicitud e imprime el resultado en pantalla
def realiza_solicitud():	
	try:
		# Captura la entrada del usuario
		ruc = input('A continuación escriba el RUC del contribuyente que desea consultar y presione la tecla Enter:\n')
		# Prepara los parametros para realiza la solicitud
		parametros = {'ruc':ruc}
		# Realiza la solicitud teniendo en cuenta un timeout de 5 segundos
		respuesta = requests.get(API_URL, params = parametros, timeout=5.0)
		# Parsea la respuesta del servidor a un json utilizando el json decoder provisto por requests
		respuesta_json = respuesta.json()	
		# Imprime en pantalla la respuesta del servidor
		print(respuesta_json['message'] + ".")						
	except:
		# Ante cualquier excepción imprime un mensaje genérico.
		print ("Lo sentimos ha ocurrido un error, intente nuevamente.")	

# Asegura la ejecución procedural del script como módulo primario de ejecución
if __name__ == '__main__':
	print(mensaje_bienvenida)
	realiza_solicitud()
else:
	print ("Ejecuta este script directamente, no lo importes.Gracias!")