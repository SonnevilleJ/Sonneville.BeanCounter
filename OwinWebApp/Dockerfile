FROM mono:latest

MAINTAINER John Sonneville <SonnevilleJ@gmail.com>

COPY * /opt/BeanCounter/
COPY Resources/* /opt/BeanCounter/Resources/

EXPOSE 80

CMD ["mono", "/opt/BeanCounter/Sonneville.BeanCounter.OwinWebApp.exe"]
