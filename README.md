# Sonneville.BeanCounter

A webapp to view and manage finances. Connects to Fidelity accounts through [FidelityWebDriver](https://github.com/SonnevilleJ/FidelityWebDriver).

Build status: ![Build Status](http://sonnevillej.privatedns.org:9000/app/rest/builds/buildType:(id:BeanCounter_Build)/statusIcon)

## Developing
After cloning this repo, there are two things you must do before launching the app.

1. Update [Google API Credentials.json](https://github.com/SonnevilleJ/Sonneville.BeanCounter/blob/master/OwinWebApp/Google%20API%20Credentials.json) with your own Google API key.
1. [Per Microsoft](https://msdn.microsoft.com/en-us/library/ms733768(v=vs.110).aspx), if you're developing on Windows, you'll need to run the following command to allow non-administrator apps to provision the port when the app runs: `netsh http add urlacl url=http://*:80/ user=DOMAIN\USER listen=yes`

## Docker
This project can be built into a [Docker](https://www.docker.com/) container using the following process:

1. Build the application.
1. Open a terminal and `cd` into the `bin/{configuration}/` directory.
3. Run `docker build . -t beancounter` to create the image.
4. Launch an instance of the new container by running `docker run -p 80:80 beancounter`
