FROM mono:latest

MAINTAINER John Sonneville <SonnevilleJ@gmail.com>

ADD OwinWebApp/bin/Release/ /opt/BeanCounter/
ADD OwinWebApp/Resources/ /opt/BeanCounter/Resources

EXPOSE 1234

CMD ["mono", "/opt/BeanCounter/OwinWebApp.exe"]
